/*
 *      Copyright 2016 Jean-Pierre Hotz
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 *
 *        .o                                .o88       .o88
 *       .88                                "888       "888
 *      o8888oo  ooo  oooo  ooo. .oo.  .oo.   888oooo.   888  oooo d8b
 *      ""888""  888  "888  "888P"Y88bP"Y88b  d88' `88b  888  "888""8P
 *        888    888   888   888   888   888  888   888  888   888
 *        888 .  888   888   888   888   888  888.  888  888   888    .o.
 *        "888Y  `V88V"V8P' o888o o888o o888o 88`bod8P' o888o d888b   Y8P
 *
 */

package de.jeanpierrehotz.tumblrmaterialthemequotesgenerator;

import android.app.Dialog;
import android.graphics.Color;
import android.os.Bundle;
import android.os.Environment;
import android.support.design.widget.Snackbar;
import android.support.design.widget.TabLayout;
import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentManager;
import android.support.v4.app.FragmentPagerAdapter;
import android.support.v4.view.ViewPager;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.view.MenuItem;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;

import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.aFileDialog.FileChooserDialog;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.data.HTMLPreviewGenerator;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.data.Quote;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.data.QuotesXMLParser;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.fragments.CodeFragment;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.fragments.PreviewFragment;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.fragments.QuotesFragment;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.fragments.SettingsFragment;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.views.ColoredSnackbar;

public class MainActivity extends AppCompatActivity{

    private TabLayout tabLayout;
    private ViewPager viewPager;

    private QuotesFragment mQuotesFragment;
    private CodeFragment mCodeFragment;
    private PreviewFragment mPreviewFragment;
    private SettingsFragment mSettingsFragment;

    private HTMLPreviewGenerator mHTMLPreviewGenerator;
    private ArrayList<Quote> mQuotes;

    private FileChooserDialog mSaveQuotesFileChooserDialog;
    private FileChooserDialog.OnFileSelectedListener mSaveQuotesOnFileSelectedListener = new FileChooserDialog.OnFileSelectedListener(){
        @Override
        public void onFileSelected(Dialog source, File file){
            source.hide();

            try{
                QuotesXMLParser.writeQuotes(mQuotes, file.getAbsolutePath());
            }catch(IOException e){
                ColoredSnackbar.make(tabLayout, getString(R.string.fileselector_error_write), Snackbar.LENGTH_LONG, Color.WHITE).show();
            }
        }

        @Override
        public void onFileSelected(Dialog source, File folder, String name){
            source.hide();

            try{
                QuotesXMLParser.writeQuotes(mQuotes, folder + ((folder.getAbsolutePath().endsWith(File.separator))? "": File.separator) + name);
            }catch(IOException e){
                ColoredSnackbar.make(tabLayout, getString(R.string.fileselector_error_write), Snackbar.LENGTH_LONG, Color.WHITE).show();
            }
        }
    };


    private FileChooserDialog mLoadQuotesFileChooserDialog;
    private FileChooserDialog.OnFileSelectedListener mLoadQuotesOnFileSelectedListener = new FileChooserDialog.OnFileSelectedListener(){
        @Override
        public void onFileSelected(Dialog source, File file){
            source.hide();

            try{
                mQuotes = QuotesXMLParser.readQuotes(file.getAbsolutePath());
                mQuotesFragment.refreshQuotes();
            }catch(IOException e){
                ColoredSnackbar.make(tabLayout, getString(R.string.fileselector_error_load), Snackbar.LENGTH_LONG, Color.WHITE).show();
            }
        }

        @Override
        public void onFileSelected(Dialog source, File folder, String name){}
    };


    @Override
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_test);

        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        mLoadQuotesFileChooserDialog = new FileChooserDialog(this, Environment.getExternalStorageDirectory().getAbsolutePath());
        mLoadQuotesFileChooserDialog.setFilter(".*xml");
        mLoadQuotesFileChooserDialog.addListener(mLoadQuotesOnFileSelectedListener);
        mLoadQuotesFileChooserDialog.setShowOnlySelectable(false);
        mLoadQuotesFileChooserDialog.setFolderMode(false);
        mLoadQuotesFileChooserDialog.setCanCreateFiles(false);
        mLoadQuotesFileChooserDialog.setShowCancelButton(true);
        mLoadQuotesFileChooserDialog.setShowConfirmation(true, true);
        mLoadQuotesFileChooserDialog.setShowFullPath(true);

        mSaveQuotesFileChooserDialog = new FileChooserDialog(this, Environment.getExternalStorageDirectory().getAbsolutePath());
        mSaveQuotesFileChooserDialog.setFilter(".*xml");
        mSaveQuotesFileChooserDialog.addListener(mSaveQuotesOnFileSelectedListener);
        mSaveQuotesFileChooserDialog.setShowOnlySelectable(false);
        mSaveQuotesFileChooserDialog.setFolderMode(false);
        mSaveQuotesFileChooserDialog.setCanCreateFiles(true);
        mSaveQuotesFileChooserDialog.setShowCancelButton(true);
        mSaveQuotesFileChooserDialog.setShowConfirmation(true, true);
        mSaveQuotesFileChooserDialog.setShowFullPath(true);

        mQuotes = Quote.loadFromSharedPreferences(getSharedPreferences(getString(R.string.preferences_code_quotes), MODE_PRIVATE));
        mHTMLPreviewGenerator = new HTMLPreviewGenerator(getSharedPreferences(getString(R.string.preferences_preview), MODE_PRIVATE));

        tabLayout = (TabLayout) findViewById(R.id.tabLayout);
        viewPager = (ViewPager) findViewById(R.id.tabLayoutPager);

        viewPager.setAdapter(new TumblrMaterialThemePagerAdapter(getSupportFragmentManager()));
        tabLayout.setupWithViewPager(viewPager);
        tabLayout.setOnTabSelectedListener(new TabLayout.OnTabSelectedListener(){
            @Override
            public void onTabSelected(TabLayout.Tab tab){
                viewPager.setCurrentItem(tab.getPosition());
                invalidateOptionsMenu();
            }
            @Override
            public void onTabUnselected(TabLayout.Tab tab){}
            @Override
            public void onTabReselected(TabLayout.Tab tab){}
        });

        if(tabLayout.getTabAt(0) != null) { tabLayout.getTabAt(0).setIcon(R.drawable.ic_tab_quote); }
        if(tabLayout.getTabAt(1) != null) { tabLayout.getTabAt(1).setIcon(R.drawable.ic_tab_code); }
        if(tabLayout.getTabAt(2) != null) { tabLayout.getTabAt(2).setIcon(R.drawable.ic_tab_preview); }
        if(tabLayout.getTabAt(3) != null) { tabLayout.getTabAt(3).setIcon(R.drawable.ic_tab_settings); }
    }

    @Override
    protected void onPause(){
        super.onPause();

        Quote.saveToSharedPreferences(mQuotes, getSharedPreferences(getString(R.string.preferences_code_quotes), MODE_PRIVATE));
        mHTMLPreviewGenerator.save(getSharedPreferences(getString(R.string.preferences_preview), MODE_PRIVATE));
    }

    @Override
    public boolean onPrepareOptionsMenu(Menu menu){
        menu.clear();
        switch(tabLayout.getSelectedTabPosition()){
            case 0:
                if(mQuotesFragment != null)
                    mQuotesFragment.onCreateOptionsMenu(menu, getMenuInflater());
                break;
            case 1:
                if(mCodeFragment != null)
                    mCodeFragment.onCreateOptionsMenu(menu, getMenuInflater());
                break;
            case 2:
                if(mPreviewFragment != null)
                    mPreviewFragment.onCreateOptionsMenu(menu, getMenuInflater());
                break;
            case 3:
                if(mSettingsFragment != null)
                    mSettingsFragment.onCreateOptionsMenu(menu, getMenuInflater());
                break;
        }
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item){
        if(mQuotesFragment != null && mQuotesFragment.onOptionsItemSelected(item)){
            return true;
        }else if(mCodeFragment != null && mCodeFragment.onOptionsItemSelected(item)){
            return true;
        }else if(mPreviewFragment != null && mPreviewFragment.onOptionsItemSelected(item)){
            return true;
        }else if(mSettingsFragment != null && mSettingsFragment.onOptionsItemSelected(item)){
            return true;
        }else{
            return super.onOptionsItemSelected(item);
        }
    }

    public String generateQuotesCode(){
        String text = "";

        for(int i = 0; i < mQuotes.size(); i++){
            text += "\"\\\"" + mQuotes.get(i).getQuote().replace("\"", "\\\"").replace("\n", "<br/>") + "\\\" - " + mQuotes.get(i).getArtist().replace("\"", "\\\"") + ", " + mQuotes.get(i).getSong().replace("\"", "\\\"") + "\"";
            if(i != mQuotes.size() - 1){
                text += ", ";
            }
        }

        return text;
    }

    public void generateAndShowQuoteCode(){
        mCodeFragment.setCode(generateQuotesCode());
    }

    public ArrayList<Quote> getQuotes(){
        return mQuotes;
    }

    public HTMLPreviewGenerator getHTMLPreviewGenerator(){
        return mHTMLPreviewGenerator;
    }

    public void saveQuotes(){
        mSaveQuotesFileChooserDialog.show();
    }

    public void loadQuotes(){
        mLoadQuotesFileChooserDialog.show();
    }

    public class TumblrMaterialThemePagerAdapter extends FragmentPagerAdapter{

        public TumblrMaterialThemePagerAdapter(FragmentManager fm){
            super(fm);
        }

        @Override
        public Fragment getItem(int position){
            switch(position){
                case 0:
                    mQuotesFragment = new QuotesFragment();
                    return mQuotesFragment;
                case 1:
                    mCodeFragment = new CodeFragment();
                    return mCodeFragment;
                case 2:
                    mPreviewFragment = new PreviewFragment();
                    return mPreviewFragment;
                case 3:
                    mSettingsFragment = new SettingsFragment();
                    return mSettingsFragment;
                default: return null;
            }
        }

        @Override
        public int getCount(){
            return 4;
        }

        @Override
        public CharSequence getPageTitle(int position){
            switch(position){
                case 0: return getString(R.string.tab_caption_quotes);
                case 1: return getString(R.string.tab_caption_code);
                case 2: return getString(R.string.tab_caption_preview);
                case 3: return getString(R.string.tab_caption_settings);
                default: return null;
            }
        }
    }
}

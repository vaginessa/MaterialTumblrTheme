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

package de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.fragments;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.graphics.Color;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.design.widget.Snackbar;
import android.support.v4.app.Fragment;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;
import android.widget.RelativeLayout;

import java.util.ArrayList;

import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.MainActivity;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.R;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.data.Quote;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.views.ColoredSnackbar;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.views.QuotesRecyclerViewAdapter;

public class QuotesFragment extends Fragment{

    private ArrayList<Quote> mQuotes;

    private RecyclerView mQuotesRecyclerView;
    private QuotesRecyclerViewAdapter mQuotesRecyclerViewAdapter;
    private RecyclerView.LayoutManager mQuotesRecyclerViewLayoutManager;

    private RelativeLayout mEmptyView;

    private QuotesRecyclerViewAdapter.OnItemLongClickListener mQuotesRecyclerViewOnItemLongClickListener = new QuotesRecyclerViewAdapter.OnItemLongClickListener(){
        @Override
        public boolean onItemLongClick(View v, final int pos, long id){
            // Let the user decide what to do with given quote
            new AlertDialog.Builder(getContext())
                    .setTitle(getString(R.string.quotes_onclick_selectaction))
                    .setItems(getResources().getStringArray(R.array.quotes_onclick_actions), new DialogInterface.OnClickListener(){
                        @Override
                        public void onClick(DialogInterface dialogInterface, int i){
                            switch(i){
                                case 0:
                                    // change quote
                                    changeQuote(pos);
                                    break;
                                case 1:
                                    // delete quote
                                    mQuotes.remove(pos);
                                    mQuotesRecyclerViewAdapter.notifyDataSetChanged();
                                    updateEmptyList();
                                    break;
                            }
                        }
                    })
                    .show();

            return true;
        }
    };

    @Override
    public void onCreateOptionsMenu(Menu menu, MenuInflater inflater){
        inflater.inflate(R.menu.menu_fragment_quotes, menu);
    }

    private AlertDialog quotesDialog;

    @Override
    public boolean onOptionsItemSelected(MenuItem item){
        switch(item.getItemId()){
            case R.id.menu_fragment_quotes_add:
                // Add quote
                // Showing a dialog
                quotesDialog = new AlertDialog.Builder(getContext())
                        .setTitle(getString(R.string.quotes_add_caption))
                        .setPositiveButton(getString(R.string.dialog_add), new DialogInterface.OnClickListener(){
                            @Override
                            public void onClick(DialogInterface dialogInterface, int i){
                                // obtain input as soon as the user clicks ok
                                String artist = ((EditText) quotesDialog.findViewById(R.id.layout_dialog_quote_artist)).getText().toString();
                                String song = ((EditText) quotesDialog.findViewById(R.id.layout_dialog_quote_song)).getText().toString();
                                String quote = ((EditText) quotesDialog.findViewById(R.id.layout_dialog_quote_quote)).getText().toString();

                                try{
                                    // create the quote
                                    Quote q = new Quote(quote, artist, song);
                                    // add it if there was no error
                                    mQuotes.add(q);
                                    mQuotesRecyclerViewAdapter.notifyDataSetChanged();
                                    updateEmptyList();
                                }catch(IllegalArgumentException exc){
                                    // show error if there is one
                                    ColoredSnackbar.make(mQuotesRecyclerView, getString(R.string.error_missingvalue), Snackbar.LENGTH_LONG, Color.WHITE).show();
                                }
                            }
                        })
                        .setNegativeButton(getString(R.string.dialog_abort), null)
                        .setView(R.layout.layout_dialog_quote)
                        .show();
                return true;
            case R.id.menu_fragment_quotes_shuffle:
                // Shuffle quotes
                // We don't need to check for the list being empty since if the list
                // were empty the loop wouldn't execute (since 0 < 0 evaluates to false)
                for(int i = 0; i < mQuotes.size() * 5; i++){
                    // Select two random indices that are not equal
                    int a = (int) (Math.random() * mQuotes.size());
                    int b;

                    do{
                        b = (int) (Math.random() * mQuotes.size());
                    }while(a == b);

                    // Swapping the two indices
                    Quote quoteA = mQuotes.get(a);
                    mQuotes.set(a, mQuotes.get(b));
                    mQuotes.set(b, quoteA);
                }
                mQuotesRecyclerViewAdapter.notifyDataSetChanged();
                return true;
            case R.id.menu_fragment_quotes_loadfromfile:
                ((MainActivity) getActivity()).loadQuotes();
                return true;
            case R.id.menu_fragment_quotes_writetofile:
                ((MainActivity) getActivity()).saveQuotes();
                return true;
            default:
                return false;
        }
    }

    public void refreshQuotes(){
        mQuotes = ((MainActivity) getActivity()).getQuotes();

        mQuotesRecyclerView.setLayoutManager(mQuotesRecyclerViewLayoutManager);

        mQuotesRecyclerViewAdapter = new QuotesRecyclerViewAdapter(mQuotes);
        mQuotesRecyclerView.setAdapter(mQuotesRecyclerViewAdapter);
        mQuotesRecyclerViewAdapter.setOnItemLongClickListener(mQuotesRecyclerViewOnItemLongClickListener);

        updateEmptyList();
    }

    @Nullable
    @Override
    public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState){
        mQuotes = ((MainActivity) getActivity()).getQuotes();

        View inflated = inflater.inflate(R.layout.layout_fragment_quotes, container, false);
        mQuotesRecyclerView = (RecyclerView) inflated.findViewById(R.id.tab_quotes_quotesrecyclerview);
        mQuotesRecyclerViewLayoutManager = new LinearLayoutManager(getContext());
        mQuotesRecyclerView.setLayoutManager(mQuotesRecyclerViewLayoutManager);

        mQuotesRecyclerViewAdapter = new QuotesRecyclerViewAdapter(mQuotes);
        mQuotesRecyclerView.setAdapter(mQuotesRecyclerViewAdapter);
        mQuotesRecyclerViewAdapter.setOnItemLongClickListener(mQuotesRecyclerViewOnItemLongClickListener);

        mEmptyView = (RelativeLayout) inflated.findViewById(R.id.tab_quotes_emptyview);

        updateEmptyList();

        return inflated;
    }

    public void updateEmptyList(){
        if(mQuotes.isEmpty()){
            mEmptyView.setVisibility(View.VISIBLE);
            mQuotesRecyclerView.setVisibility(View.GONE);
        }else{
            mEmptyView.setVisibility(View.GONE);
            mQuotesRecyclerView.setVisibility(View.VISIBLE);
        }
    }

    public void changeQuote(final int pos){
        quotesDialog = new AlertDialog.Builder(getContext())
                .setTitle(getString(R.string.quotes_change_caption))
                .setView(R.layout.layout_dialog_quote)
                .setPositiveButton(getString(R.string.dialog_change), new DialogInterface.OnClickListener(){
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i){
                        String artist = ((EditText) quotesDialog.findViewById(R.id.layout_dialog_quote_artist)).getText().toString();
                        String song = ((EditText) quotesDialog.findViewById(R.id.layout_dialog_quote_song)).getText().toString();
                        String quote = ((EditText) quotesDialog.findViewById(R.id.layout_dialog_quote_quote)).getText().toString();

                        try{
                            Quote q = new Quote(quote, artist, song);
                            mQuotes.set(pos, q);
                            mQuotesRecyclerViewAdapter.notifyDataSetChanged();
                            updateEmptyList();
                        }catch(IllegalArgumentException exc){
                            ColoredSnackbar.make(mQuotesRecyclerView, getString(R.string.error_missingvalue), Snackbar.LENGTH_LONG, Color.WHITE).show();
                        }
                    }
                })
                .setNegativeButton(getString(R.string.dialog_abort), null)
                .show();

        ((EditText) quotesDialog.findViewById(R.id.layout_dialog_quote_artist)).setText(mQuotes.get(pos).getArtist());
        ((EditText) quotesDialog.findViewById(R.id.layout_dialog_quote_song)).setText(mQuotes.get(pos).getSong());
        ((EditText) quotesDialog.findViewById(R.id.layout_dialog_quote_quote)).setText(mQuotes.get(pos).getQuote());
    }
}

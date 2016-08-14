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

import android.graphics.Color;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;

import com.pes.androidmaterialcolorpickerdialog.ColorPicker;

import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.MainActivity;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.R;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.data.HTMLPreviewGenerator;

public class SettingsFragment extends Fragment{


    private EditText mTitleEditText;
    private EditText mDescriptionEditText;
    private Spinner mAvatarShapeSpinner;
    private TextView mBackgroundColorTextView;
    private CheckBox mShowHeaderCheckBox;
    private CheckBox mShowAvatarCheckBox;
    private CheckBox mShowTitleCheckBox;
    private CheckBox mShowDescriptionCheckBox;
    private TextView mFirstBackgroundStripeColorTextView;
    private TextView mSecondBackgroundStripeColorTextView;
    private TextView mAvatarBorderColorTextView;
    private Spinner mThemeColorSpinner;
    private CheckBox mEndlessScrollingCheckBox;
    private CheckBox mSlidingHeaderCheckBox;
    private CheckBox mBackgroundAsStripesCheckBox;
    private CheckBox mShowQuotesCheckBox;
    private CheckBox mPayRespectToMyHardWorkCheckBox;

    private ColorPicker mBackgroundColorColorPicker;
    private ColorPicker mFirstBackgroundStripeColorColorPicker;
    private ColorPicker mSecondBackgroundStripeColorColorPicker;
    private ColorPicker mAvatarBorderColorColorPicker;

    private HTMLPreviewGenerator mHTMLPreviewGenerator;

    @Override
    public void onCreateOptionsMenu(Menu menu, MenuInflater inflater){
        inflater.inflate(R.menu.menu_fragment_settings, menu);
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item){
        return false;
    }

    @Nullable
    @Override
    public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState){
        mHTMLPreviewGenerator = ((MainActivity) getActivity()).getHTMLPreviewGenerator();

        View v = inflater.inflate(R.layout.layout_fragment_settings, container, false);

        mTitleEditText = (EditText) v.findViewById(R.id.layout_fragment_settings_title_edittext);
        mTitleEditText.setText(mHTMLPreviewGenerator.getTitle());
        mTitleEditText.addTextChangedListener(new TextWatcher(){
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2){
            }

            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2){
            }

            @Override
            public void afterTextChanged(Editable editable){
                mHTMLPreviewGenerator.setTitle(mTitleEditText.getText().toString());
            }
        });

        mDescriptionEditText = (EditText) v.findViewById(R.id.layout_fragment_settings_description_edittext);
        mDescriptionEditText.setText(mHTMLPreviewGenerator.getDescription());
        mDescriptionEditText.addTextChangedListener(new TextWatcher(){
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2){
            }

            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2){
            }

            @Override
            public void afterTextChanged(Editable editable){
                mHTMLPreviewGenerator.setDescription(mDescriptionEditText.getText().toString());
            }
        });

        mAvatarShapeSpinner = (Spinner) v.findViewById(R.id.layout_fragment_settings_avatarshape_spinner);
        mAvatarShapeSpinner.setSelection(getIndexFromImageShape(mHTMLPreviewGenerator.getAvatarShape()));
        mAvatarShapeSpinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener(){
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l){
                mHTMLPreviewGenerator.setAvatarShape(getImageShapeFromIndex(mAvatarShapeSpinner.getSelectedItemPosition()));
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView){
            }
        });

        mBackgroundColorTextView = (TextView) v.findViewById(R.id.layout_fragment_settings_backgroundcolor_textview);
        setTextViewColor(mBackgroundColorTextView, mHTMLPreviewGenerator.getBackgroundColor());
        mBackgroundColorTextView.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view){
                mBackgroundColorColorPicker.show();
                mBackgroundColorColorPicker.findViewById(R.id.okColorButton).setOnClickListener(new View.OnClickListener(){
                    @Override
                    public void onClick(View view){
                        mHTMLPreviewGenerator.setBackgroundColor(mBackgroundColorColorPicker.getColor());
                        setTextViewColor(mBackgroundColorTextView, mHTMLPreviewGenerator.getBackgroundColor());
                        mBackgroundColorColorPicker.dismiss();
                    }
                });
            }
        });
        mBackgroundColorColorPicker = new ColorPicker(
                getActivity(),
                Color.red(mHTMLPreviewGenerator.getBackgroundColor()),
                Color.green(mHTMLPreviewGenerator.getBackgroundColor()),
                Color.blue(mHTMLPreviewGenerator.getBackgroundColor())
        );

        mShowHeaderCheckBox = (CheckBox) v.findViewById(R.id.layout_fragment_settings_showheaderimage_checkbox);
        mShowHeaderCheckBox.setChecked(mHTMLPreviewGenerator.isShowHeaderImage());
        mShowHeaderCheckBox.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener(){
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b){
                mHTMLPreviewGenerator.setShowHeaderImage(mShowHeaderCheckBox.isChecked());
            }
        });

        mShowAvatarCheckBox = (CheckBox) v.findViewById(R.id.layout_fragment_settings_showavatar_checkbox);
        mShowAvatarCheckBox.setChecked(mHTMLPreviewGenerator.isShowAvatar());
        mShowAvatarCheckBox.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener(){
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b){
                mHTMLPreviewGenerator.setShowAvatar(mShowAvatarCheckBox.isChecked());
            }
        });

        mShowTitleCheckBox = (CheckBox) v.findViewById(R.id.layout_fragment_settings_showtitle_checkbox);
        mShowTitleCheckBox.setChecked(mHTMLPreviewGenerator.isShowTitle());
        mShowTitleCheckBox.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener(){
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b){
                mHTMLPreviewGenerator.setShowTitle(mShowTitleCheckBox.isChecked());
            }
        });

        mShowDescriptionCheckBox = (CheckBox) v.findViewById(R.id.layout_fragment_settings_showdescription_checkbox);
        mShowDescriptionCheckBox.setChecked(mHTMLPreviewGenerator.isShowDescription());
        mShowDescriptionCheckBox.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener(){
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b){
                mHTMLPreviewGenerator.setShowDescription(mShowDescriptionCheckBox.isChecked());
            }
        });

        mFirstBackgroundStripeColorTextView = (TextView) v.findViewById(R.id.layout_fragment_settings_firstbackgroundstripecolor_textview);
        setTextViewColor(mFirstBackgroundStripeColorTextView, mHTMLPreviewGenerator.getFirstStripeColor());
        mFirstBackgroundStripeColorTextView.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view){
                mFirstBackgroundStripeColorColorPicker.show();
                mFirstBackgroundStripeColorColorPicker.findViewById(R.id.okColorButton).setOnClickListener(new View.OnClickListener(){
                    @Override
                    public void onClick(View view){
                        mHTMLPreviewGenerator.setFirstStripeColor(mFirstBackgroundStripeColorColorPicker.getColor());
                        setTextViewColor(mFirstBackgroundStripeColorTextView, mHTMLPreviewGenerator.getFirstStripeColor());
                        mFirstBackgroundStripeColorColorPicker.dismiss();
                    }
                });
            }
        });
        mFirstBackgroundStripeColorColorPicker = new ColorPicker(
                getActivity(),
                Color.red(mHTMLPreviewGenerator.getFirstStripeColor()),
                Color.green(mHTMLPreviewGenerator.getFirstStripeColor()),
                Color.blue(mHTMLPreviewGenerator.getFirstStripeColor())
        );

        mSecondBackgroundStripeColorTextView = (TextView) v.findViewById(R.id.layout_fragment_settings_secondbackgroundstripecolor_textview);
        setTextViewColor(mSecondBackgroundStripeColorTextView, mHTMLPreviewGenerator.getSecondStripeColor());
        mSecondBackgroundStripeColorTextView.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view){
                mSecondBackgroundStripeColorColorPicker.show();
                mSecondBackgroundStripeColorColorPicker.findViewById(R.id.okColorButton).setOnClickListener(new View.OnClickListener(){
                    @Override
                    public void onClick(View view){
                        mHTMLPreviewGenerator.setSecondStripeColor(mSecondBackgroundStripeColorColorPicker.getColor());
                        setTextViewColor(mSecondBackgroundStripeColorTextView, mHTMLPreviewGenerator.getSecondStripeColor());
                        mSecondBackgroundStripeColorColorPicker.dismiss();
                    }
                });
            }
        });
        mSecondBackgroundStripeColorColorPicker = new ColorPicker(
                getActivity(),
                Color.red(mHTMLPreviewGenerator.getSecondStripeColor()),
                Color.green(mHTMLPreviewGenerator.getSecondStripeColor()),
                Color.blue(mHTMLPreviewGenerator.getSecondStripeColor())
        );

        mAvatarBorderColorTextView = (TextView) v.findViewById(R.id.layout_fragment_settings_avatarbordercolor_textview);
        setTextViewColor(mAvatarBorderColorTextView, mHTMLPreviewGenerator.getAvatarBorderColor());
        mAvatarBorderColorTextView.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view){
                mAvatarBorderColorColorPicker.show();
                mAvatarBorderColorColorPicker.findViewById(R.id.okColorButton).setOnClickListener(new View.OnClickListener(){
                    @Override
                    public void onClick(View view){
                        mHTMLPreviewGenerator.setAvatarBorderColor(mAvatarBorderColorColorPicker.getColor());
                        setTextViewColor(mAvatarBorderColorTextView, mHTMLPreviewGenerator.getAvatarBorderColor());
                        mAvatarBorderColorColorPicker.dismiss();
                    }
                });
            }
        });
        mAvatarBorderColorColorPicker = new ColorPicker(
                getActivity(),
                Color.red(mHTMLPreviewGenerator.getAvatarBorderColor()),
                Color.green(mHTMLPreviewGenerator.getAvatarBorderColor()),
                Color.blue(mHTMLPreviewGenerator.getAvatarBorderColor())
        );

        mThemeColorSpinner = (Spinner) v.findViewById(R.id.layout_fragment_settings_themecolor_spinner);
        mThemeColorSpinner.setSelection(getIndexFromMaterialColor(mHTMLPreviewGenerator.getThemeColor()));
        mThemeColorSpinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener(){
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l){
                mHTMLPreviewGenerator.setThemeColor(getMaterialColorFromIndex(mThemeColorSpinner.getSelectedItemPosition()));
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView){
            }
        });

        mEndlessScrollingCheckBox = (CheckBox) v.findViewById(R.id.layout_fragment_settings_endlessscrolling_checkbox);
        mEndlessScrollingCheckBox.setChecked(mHTMLPreviewGenerator.isInfiniteScrolling());
        mEndlessScrollingCheckBox.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener(){
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b){
                mHTMLPreviewGenerator.setInfiniteScrolling(mEndlessScrollingCheckBox.isChecked());
            }
        });

        mSlidingHeaderCheckBox = (CheckBox) v.findViewById(R.id.layout_fragment_settings_slidingheader_checkbox);
        mSlidingHeaderCheckBox.setChecked(mHTMLPreviewGenerator.isSlidingHeader());
        mSlidingHeaderCheckBox.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener(){
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b){
                mHTMLPreviewGenerator.setSlidingHeader(mSlidingHeaderCheckBox.isChecked());
            }
        });

        mBackgroundAsStripesCheckBox = (CheckBox) v.findViewById(R.id.layout_fragment_settings_backgroundasstripes_checkbox);
        mBackgroundAsStripesCheckBox.setChecked(mHTMLPreviewGenerator.isBackgroundAsStripes());
        mBackgroundAsStripesCheckBox.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener(){
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b){
                mHTMLPreviewGenerator.setBackgroundAsStripes(mBackgroundAsStripesCheckBox.isChecked());
            }
        });

        mShowQuotesCheckBox = (CheckBox) v.findViewById(R.id.layout_fragment_settings_showquotes_checkbox);
        mShowQuotesCheckBox.setChecked(mHTMLPreviewGenerator.isShowQuotes());
        mShowQuotesCheckBox.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener(){
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b){
                mHTMLPreviewGenerator.setShowQuotes(mShowQuotesCheckBox.isChecked());
            }
        });

        mPayRespectToMyHardWorkCheckBox = (CheckBox) v.findViewById(R.id.layout_fragment_settings_payrespecttomywork_checkbox);
        mPayRespectToMyHardWorkCheckBox.setChecked(mHTMLPreviewGenerator.isPayRespectToMyWork());
        mPayRespectToMyHardWorkCheckBox.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener(){
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b){
                mHTMLPreviewGenerator.setPayRespectToMyWork(mPayRespectToMyHardWorkCheckBox.isChecked());
            }
        });

        return v;
    }


    ///
    /// Miscellanous methods
    ///

    private int getIndexFromImageShape(HTMLPreviewGenerator.ImageShape shape){
        switch(shape){
            case Rectangular:   return 0;
            case Circular:      return 1;
            default:            return 0;
        }
    }

    private HTMLPreviewGenerator.ImageShape getImageShapeFromIndex(int ind){
        switch(ind){
            case 0:     return HTMLPreviewGenerator.ImageShape.Rectangular;
            case 1:     return HTMLPreviewGenerator.ImageShape.Circular;
            default:    return HTMLPreviewGenerator.ImageShape.Rectangular;
        }
    }

    private int getIndexFromMaterialColor(HTMLPreviewGenerator.MaterialColor color){
        switch(color){
            case Red:           return 0;
            case Purple:        return 1;
            case Deep_Purple:   return 2;
            case Indigo_Blue:   return 3;
            case Blue:          return 4;
            case Light_Blue:    return 5;
            case Cyan:          return 6;
            case Teal:          return 7;
            case Green:         return 8;
            case Light_Green:   return 9;
            case Lime:          return 10;
            case Yellow:        return 11;
            case Amber:         return 12;
            case Orange:        return 13;
            case Deep_Orange:   return 14;
            case Brown:         return 15;
            default:            return 15;
        }
    }

    private HTMLPreviewGenerator.MaterialColor getMaterialColorFromIndex(int ind){
        switch(ind){
            case 0:     return HTMLPreviewGenerator.MaterialColor.Red;
            case 1:     return HTMLPreviewGenerator.MaterialColor.Purple;
            case 2:     return HTMLPreviewGenerator.MaterialColor.Deep_Purple;
            case 3:     return HTMLPreviewGenerator.MaterialColor.Indigo_Blue;
            case 4:     return HTMLPreviewGenerator.MaterialColor.Blue;
            case 5:     return HTMLPreviewGenerator.MaterialColor.Light_Blue;
            case 6:     return HTMLPreviewGenerator.MaterialColor.Cyan;
            case 7:     return HTMLPreviewGenerator.MaterialColor.Teal;
            case 8:     return HTMLPreviewGenerator.MaterialColor.Green;
            case 9:     return HTMLPreviewGenerator.MaterialColor.Light_Green;
            case 10:    return HTMLPreviewGenerator.MaterialColor.Lime;
            case 11:    return HTMLPreviewGenerator.MaterialColor.Yellow;
            case 12:    return HTMLPreviewGenerator.MaterialColor.Amber;
            case 13:    return HTMLPreviewGenerator.MaterialColor.Orange;
            case 14:    return HTMLPreviewGenerator.MaterialColor.Deep_Orange;
            case 15:    return HTMLPreviewGenerator.MaterialColor.Brown;
            default:    return HTMLPreviewGenerator.MaterialColor.Brown;
        }
    }

    private void setTextViewColor(TextView v, int col){
        v.setBackgroundColor(col);
        v.setTextColor(0xFF000000|~col);
    }
}

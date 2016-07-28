/* 
    Copyright 2016 Jean-Pierre Hotz
Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
 */

using System;
using System.IO;
using System.Windows.Forms;

using ContextNS;
using System.Diagnostics;
using System.Drawing;

namespace TumblrMaterialThemeQuotesGenerator
{
    public partial class Form1 : Form
    {
        private static readonly string APPLICATION_FOLDER = @"C:\preferences";
        private static readonly string APPLICATION_INTERN_ID = "TumblrMaterialThemeQuotesGenerator_exe";

        private MaterialDesignTumblrThemeHTMLPreview Preview;

        private Preference ApplicationPreferences;
        private bool Saved;
        private bool Editing;

        public Form1()
        {
            InitializeComponent();

            Saved = true;
            Editing = false;

            ApplicationPreferences = new Preference(APPLICATION_INTERN_ID);

            Preview = MaterialDesignTumblrThemeHTMLPreview.LoadPreview(ApplicationPreferences);

            if (ApplicationPreferences.getBoolean(ID.FIRST, true))
            {
                ApplicationPreferences.edit()
                    .putBoolean(ID.FIRST, false)
                    .putString(ID.LAST_LOADED, "")
                    .commit();
            }

            string path = ApplicationPreferences.getString(ID.LAST_LOADED, "");
            if(!path.Equals("") && File.Exists(path))
            {
                string FolderPath = FindPathName(path);
                string FileName = FindFileName(path);

                LoadFromFile(FolderPath, FileName);
            }

            LoadLanguageDependentTexts();
            LoadPreviewSettings();
        }

        #region Language-independence
        private void LoadLanguageDependentTexts()
        {
            this.Text = Context.getString(ContextIDs.FORM_CAPTION);
            this.FileToolStripMenuItem.Text = Context.getString(ContextIDs.FILE_MENUITEM);
            this.NewToolStripMenuItem.Text = Context.getString(ContextIDs.FILE_NEW_MENUITEM);
            this.OpenToolStripMenuItem.Text = Context.getString(ContextIDs.FILE_OPEN_MENUITEM);
            this.SaveAsProjectToolStripMenuItem.Text = Context.getString(ContextIDs.FILE_SAVEASPROJECT_MENUITEM);
            this.GenerateCodeToolStripMenuItem.Text = Context.getString(ContextIDs.FILE_GENERATECODE_MENUITEM);
            this.ExitProgramToolStripMenuItem.Text = Context.getString(ContextIDs.FILE_EXITPROGRAM_MENUITEM);
            this.ErrorLabel.Text = Context.getString(ContextIDs.STATUS_INIT);
            this.OpenFileDialog.Title = Context.getString(ContextIDs.LOADDIALOG_CAPTION);
            this.TabPage2.Text = Context.getString(ContextIDs.TABCAPTIONS_GENERATEDCODE);
            this.TabPage1.Text = Context.getString(ContextIDs.TABCAPTIONS_QUOTES);
            this.MixQuotesButton.Text = Context.getString(ContextIDs.QUOTES_BUTTON_MIX);
            this.DeleteSelectedQuoteButton.Text = Context.getString(ContextIDs.QUOTES_BUTTON_DELETE);
            this.ChangeSelectedQuoteButton.Text = Context.getString(ContextIDs.QUOTES_BUTTON_CHANGE);
            this.AddQuoteButton.Text = Context.getString(ContextIDs.QUOTES_BUTTON_ADD);
            this.SongLabel.Text = Context.getString(ContextIDs.QUOTES_LABEL_SONG);
            this.ArtistLabel.Text = Context.getString(ContextIDs.QUOTES_LABEL_ARTIST);
            this.QuoteLabel.Text = Context.getString(ContextIDs.QUOTES_LABEL_QUOTE);
            this.ListViewHeaderQuote.Text = Context.getString(ContextIDs.QUOTES_LISTVIEWCAPTION_QUOTES);
            this.ListViewHeaderArtist.Text = Context.getString(ContextIDs.QUOTES_LISTVIEWCAPTION_ARTIST);
            this.ListViewHeaderSong.Text = Context.getString(ContextIDs.QUOTES_LISTVIEWCAPTION_SONG);

            this.PreviewTabPage.Text = Context.getString(ContextIDs.TABCAPTIONS_PREVIEW);
            this.PreviewToolStripMenuItem.Text = Context.getString(ContextIDs.TABCAPTIONS_PREVIEW);
            this.GeneratePreviewToolStripMenuItem.Text = Context.getString(ContextIDs.PREVIEW_GENERATE);
            this.OpenInExtBrowserToolStripMenuItem.Text = Context.getString(ContextIDs.PREVIEW_OPENINEXTBROWSER);

            this.PreviewSettingsTabPage.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_CAPTION);
            this.PreviewSettingsTitleLabel.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_TITLE);
            this.PreviewSettingsDescriptionLabel.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_DESCRIPTION);
            this.PreviewSettingsAvatarShapeLabel.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_AVATARSHAPE);
            this.PreviewSettingsAvatarShapeComboBox.Items.AddRange(new object[] {
                Context.getString(ContextIDs.PREVIEW_SETTINGS_IMAGESHAPE_CIRCLE),
                Context.getString(ContextIDs.PREVIEW_SETTINGS_IMAGESHAPE_RECTANGLE),
            });
            this.PreviewSettingsBackgroundColorLabel.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_BACKGROUNDCOLOR);
            this.PreviewSettingsBackgroundColorButton.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_CHANGECOLOR);
            this.PreviewSettingsShowHeaderImageCheckBox.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_SHOWHEADERIMAGE);
            this.PreviewSettingsShowAvatarCheckBox.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_SHOWAVATAR);
            this.PreviewSettingsShowTitleCheckBox.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_SHOWTITLE);
            this.PreviewSettingsShowDescriptionCheckBox.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_SHOWDESCRIPTION);
            this.PreviewSettingsFirstStripeColorLabel.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_FIRSTSTRIPECOLOR);
            this.PreviewSettingsFirstStripeColoButton.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_CHANGECOLOR);
            this.PreviewSettingsSecondStripeColorLabel.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_SECONDSTRIPECOLOR);
            this.PreviewSettingsSecondStripeColorButton.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_CHANGECOLOR);
            this.PreviewSettingsAvatarBorderColorLabel.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_AVATARBORDERCOLOR);
            this.PreviewSettingsAvatarBorderColorButton.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_CHANGECOLOR);
            this.PreviewSettingsThemeColorLabel.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_THEMECOLOR);
            this.PreviewSettingsThemeColorComboBox.Items.AddRange(new object[]{
                Context.getString(ContextIDs.PREVIEW_SETTINGS_MATERIALCOLOR_RED),
                Context.getString(ContextIDs.PREVIEW_SETTINGS_MATERIALCOLOR_PURPLE),
                Context.getString(ContextIDs.PREVIEW_SETTINGS_MATERIALCOLOR_DEEPPURPLE),
                Context.getString(ContextIDs.PREVIEW_SETTINGS_MATERIALCOLOR_INDIGOBLUE),
                Context.getString(ContextIDs.PREVIEW_SETTINGS_MATERIALCOLOR_BLUE),
                Context.getString(ContextIDs.PREVIEW_SETTINGS_MATERIALCOLOR_LIGHTBLUE),
                Context.getString(ContextIDs.PREVIEW_SETTINGS_MATERIALCOLOR_CYAN),
                Context.getString(ContextIDs.PREVIEW_SETTINGS_MATERIALCOLOR_TEAL),
                Context.getString(ContextIDs.PREVIEW_SETTINGS_MATERIALCOLOR_GREEN),
                Context.getString(ContextIDs.PREVIEW_SETTINGS_MATERIALCOLOR_LIGHTGREEN),
                Context.getString(ContextIDs.PREVIEW_SETTINGS_MATERIALCOLOR_LIME),
                Context.getString(ContextIDs.PREVIEW_SETTINGS_MATERIALCOLOR_YELLOW),
                Context.getString(ContextIDs.PREVIEW_SETTINGS_MATERIALCOLOR_AMBER),
                Context.getString(ContextIDs.PREVIEW_SETTINGS_MATERIALCOLOR_ORANGE),
                Context.getString(ContextIDs.PREVIEW_SETTINGS_MATERIALCOLOR_DEEPORANGE),
                Context.getString(ContextIDs.PREVIEW_SETTINGS_MATERIALCOLOR_BROWN)
            });
            this.PreviewSettingsEndlessScrollingCheckBox.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_ENDLESSSCROLLING);
            this.PreviewSettingsSlidingHeaderCheckBox.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_SLIDINGHEADER);
            this.PreviewSettingsBackgroundStripesCheckBox.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_BACKGROUNDSTRIPES);
            this.PreviewSettingsShowQuotesCheckBox.Text = Context.getString(ContextIDs.PREVIEW_SETTINGS_SHOWQUOTES);
        }
        #endregion

        #region EventHandlers
        private void PreviewSettingsTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            Preview.Title = PreviewSettingsTitleTextBox.Text;
        }

        private void PreviewSettingsDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            Preview.Description = PreviewSettingsDescriptionTextBox.Text;
        }

        private void PreviewSettingsAvatarShapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Preview.AvatarShape = GetAvatarShape();
        }

        private void PreviewSettingsBackgroundColorButton_Click(object sender, EventArgs e)
        {
            SelectColor(PreviewSettingsBackgroundColorButton, Preview, 0);
        }

        private void PreviewSettingsShowHeaderImageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Preview.ShowHeaderImage = PreviewSettingsShowHeaderImageCheckBox.Checked;
        }

        private void PreviewSettingsShowAvatarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Preview.ShowAvatar = PreviewSettingsShowAvatarCheckBox.Checked;
        }

        private void PreviewSettingsShowTitleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Preview.ShowTitle = PreviewSettingsShowTitleCheckBox.Checked;
        }

        private void PreviewSettingsShowDescriptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Preview.ShowDescription = PreviewSettingsShowDescriptionCheckBox.Checked;
        }

        private void PreviewSettingsFirstStripeColoButton_Click(object sender, EventArgs e)
        {
            SelectColor(PreviewSettingsFirstStripeColoButton, Preview, 1);
        }

        private void PreviewSettingsSecondStripeColorButton_Click(object sender, EventArgs e)
        {
            SelectColor(PreviewSettingsSecondStripeColorButton, Preview, 2);
        }

        private void PreviewSettingsAvatarBorderColorButton_Click(object sender, EventArgs e)
        {
            SelectColor(PreviewSettingsAvatarBorderColorButton, Preview, 3);

        }

        private void PreviewSettingsThemeColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Preview.ThemeColor = GetThemeColor();
        }

        private void PreviewSettingsEndlessScrollingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Preview.InfiniteScrolling = PreviewSettingsEndlessScrollingCheckBox.Checked;
        }

        private void PreviewSettingsSlidingHeaderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Preview.SlidingHeader = PreviewSettingsSlidingHeaderCheckBox.Checked;
        }

        private void PreviewSettingsBackgroundStripesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Preview.BackgroundAsStripes = PreviewSettingsBackgroundStripesCheckBox.Checked;
        }

        private void PreviewSettingsShowQuotesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Preview.ShowQuotes = PreviewSettingsShowQuotesCheckBox.Checked;
        }

        private void GeneratePreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preview.QuotesJavaScriptCode = GenerateCode();
            PreviewWebControl.WebView.LoadHtml(Preview.GenerateHTML(), "");
            ErrorLabel.Text = Context.getString(ContextIDs.SUCCESS_PREVIEW_GENERATE);
        }

        private void OpenInExtBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preview.QuotesJavaScriptCode = GenerateCode();
            File.WriteAllText(APPLICATION_FOLDER + "\\temp.html", Preview.GenerateHTML());
            Process.Start(APPLICATION_FOLDER + "\\temp.html");
            ErrorLabel.Text = String.Format(Context.getString(ContextIDs.SUCCESS_PREVIEW_OPENINEXTBROWSER), APPLICATION_FOLDER + "\\temp.html");
        }

        private void ExitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Saved)
            {
                Application.Exit();
            }
            else
            {
                DialogResult exitAlthoughNotSavedResult = MessageBox.Show(
                    Context.getString(ContextIDs.ERROR_UNSAVEDCHANGES_EXITING),
                    Context.getString(ContextIDs.ERROR_UNSAVEDCHANGES_CAPTION),
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.None
                );

                if (exitAlthoughNotSavedResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Saved)
            {
                ResetListView();
                GeneratedCodeBox.Clear();
            }
            else
            {
                DialogResult newAlthoughNotSavedResult = MessageBox.Show(
                    Context.getString(ContextIDs.ERROR_UNSAVEDCHANGES_CREATING),
                    Context.getString(ContextIDs.ERROR_UNSAVEDCHANGES_CAPTION),
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.None
                );

                if (newAlthoughNotSavedResult == DialogResult.Yes)
                {
                    ResetListView();
                    GeneratedCodeBox.Clear();
                }
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Saved)
            {
                LoadFile();
            }
            else
            {
                DialogResult loadAlthoughNotSavedResult = MessageBox.Show(
                    Context.getString(ContextIDs.ERROR_UNSAVEDCHANGES_LOADING),
                    Context.getString(ContextIDs.ERROR_UNSAVEDCHANGES_CAPTION),
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.None
                );

                if (loadAlthoughNotSavedResult == DialogResult.Yes)
                {
                    LoadFile();
                }
            }
        }

        private void SaveAsProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = SaveFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                string path = FindPathName(SaveFileDialog1.FileName);
                string filename = FindFileName(SaveFileDialog1.FileName);

                SaveProjectTo(path, filename);
            }
        }

        private void GenerateCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateAndDisplayCode();
        }

        private void QuotesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Editing)
            {
                if (QuotesList.SelectedIndices.Count > 0)
                {
                    int i = QuotesList.SelectedIndices[0];

                    QuoteTextBox.Text = QuotesList.Items[i].SubItems[0].Text;
                    ArtistTextBox.Text = QuotesList.Items[i].SubItems[1].Text;
                    SongTextBox.Text = QuotesList.Items[i].SubItems[2].Text;
                }
                else
                {
                    QuoteTextBox.Clear();
                    ArtistTextBox.Clear();
                    SongTextBox.Clear();
                }
            }
        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            if(QuoteTextBox.Text.Trim().Equals("") || ArtistTextBox.Text.Trim().Equals("") || SongTextBox.Text.Trim().Equals(""))
            {
                ErrorLabel.Text = Context.getString(ContextIDs.ERROR_NOVALUE_ADDQUOTE);
            }
            else
            {
                Saved = false;

                QuotesList.Items.Add(new ListViewItem(new string[] {
                    QuoteTextBox.Text,
                    ArtistTextBox.Text,
                    SongTextBox.Text
                }));

                ErrorLabel.Text = Context.getString(ContextIDs.SUCCESS_ADDQUOTE);

                QuoteTextBox.Clear();
                ArtistTextBox.Clear();
                SongTextBox.Clear();
            }
        }

        private void ChangeSelectedQuoteButton_Click(object sender, EventArgs e)
        {
            if(QuotesList.SelectedIndices.Count > 0)
            {
                Editing = true;
                int i = QuotesList.SelectedIndices[0];
                ListViewItem item = QuotesList.Items[i];

                QuotesList.Items.RemoveAt(i);

                if (QuoteTextBox.Text.Trim().Equals("") || ArtistTextBox.Text.Trim().Equals("") || SongTextBox.Text.Trim().Equals(""))
                {
                    ErrorLabel.Text = Context.getString(ContextIDs.ERROR_NOVALUE_CHANGEQUOTE);
                }
                else
                {
                    item = new ListViewItem(new string[] {
                        QuoteTextBox.Text,
                        ArtistTextBox.Text,
                        SongTextBox.Text
                    });

                    Saved = false;
                    Editing = false;
                    ErrorLabel.Text = Context.getString(ContextIDs.SUCCES_CHANGEQUOTE);
                }

                QuotesList.Items.Insert(i, item);
            }
            else
            {
                if (QuoteTextBox.Text.Trim().Equals("") || ArtistTextBox.Text.Trim().Equals("") || SongTextBox.Text.Trim().Equals(""))
                {
                    ErrorLabel.Text = Context.getString(ContextIDs.ERROR_NOSELECT_NOVALUE_CHANGEQUOTE);
                }
                else
                {
                    Saved = false;

                    QuotesList.Items.Add(new ListViewItem(new string[] {
                        QuoteTextBox.Text,
                        ArtistTextBox.Text,
                        SongTextBox.Text
                    }));

                    ErrorLabel.Text = Context.getString(ContextIDs.SUCCESS_NOSELECT_CHANGEQUOTE);

                    QuoteTextBox.Clear();
                    ArtistTextBox.Clear();
                    SongTextBox.Clear();
                }
            }
        }

        private void DeleteSelectedQuoteButton_Click(object sender, EventArgs e)
        {
            if(QuotesList.SelectedIndices.Count > 0)
            {
                QuotesList.SelectedItems[0].Remove();

                Saved = false;
                ErrorLabel.Text = Context.getString(ContextIDs.SUCCESS_DELETEQUOTE);
            }
            else
            {
                ErrorLabel.Text = Context.getString(ContextIDs.ERROR_NOSELECT_DELETEQUOTE);
            }
        }

        private void MixQuotesButton_Click(object sender, EventArgs e)
        {
            if(QuotesList.Items.Count > 2)
            {
                Random randomizer = new Random();

                for(int i = 0; i < 15 * QuotesList.Items.Count; i++)
                {
                    int i_1 = randomizer.Next(QuotesList.Items.Count);
                    int i_2 = 0;
                    do
                    {
                        i_2 = randomizer.Next(QuotesList.Items.Count);
                    } while (i_1 == i_2);

                    ListViewItem item_1 = QuotesList.Items[i_1];
                    ListViewItem item_2 = QuotesList.Items[i_2];

                    if(i_1 > i_2)
                    {
                        QuotesList.Items.RemoveAt(i_1);
                        QuotesList.Items.RemoveAt(i_2);

                        QuotesList.Items.Insert(i_2, item_1);
                        QuotesList.Items.Insert(i_1, item_2);
                    }
                    else
                    {
                        QuotesList.Items.RemoveAt(i_2);
                        QuotesList.Items.RemoveAt(i_1);

                        QuotesList.Items.Insert(i_1, item_2);
                        QuotesList.Items.Insert(i_2, item_1);
                    }
                }

                ErrorLabel.Text = Context.getString(ContextIDs.SUCCESS_MIXQUOTES);
            }
            else
            {
                ErrorLabel.Text = Context.getString(ContextIDs.ERROR_TOOFEW_MIXQUOTES);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MaterialDesignTumblrThemeHTMLPreview.PutMaterialDesignTumblrThemeHTMLPreview(ApplicationPreferences.edit(), Preview).commit();
        }
        #endregion

        #region Codegeneration
        private void GenerateAndDisplayCode()
        {
            GeneratedCodeBox.Text = GenerateCode();
            ErrorLabel.Text = Context.getString(ContextIDs.SUCCESS_CODEGENERATION);
        }

        private string GenerateCode()
        {
            string text = "";

            for (int i = 0; i < QuotesList.Items.Count; i++)
            {
                text += "\"\\\"" + QuotesList.Items[i].SubItems[0].Text.Replace("\"", "\\\"").Replace(System.Environment.NewLine, "<br/>") + "\\\" - " + QuotesList.Items[i].SubItems[1].Text.Replace("\"", "\\\"") + ", " + QuotesList.Items[i].SubItems[2].Text.Replace("\"", "\\\"") + "\"";
                if (i != QuotesList.Items.Count - 1)
                {
                    text += ",";
                }
            }

            return text;
        }
        #endregion

        #region File IO
        private void LoadFile()
        {
            DialogResult result = OpenFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = FindPathName(OpenFileDialog.FileName);
                string filename = FindFileName(OpenFileDialog.FileName);

                LoadFromFile(path, filename);
            }
        }

        private void SaveProjectTo(string path, string filename)
        {
            Preference.Editor tempPreferences = new Preference(path, filename).edit();

            tempPreferences.putInt(ID.LOAD.LENGTH, QuotesList.Items.Count);
            for(int i = 0; i < QuotesList.Items.Count; i++)
            {
                tempPreferences.putString(ID.LOAD.QUOTE_AT + i, QuotesList.Items[i].SubItems[0].Text);
                tempPreferences.putString(ID.LOAD.ARTIST_AT + i, QuotesList.Items[i].SubItems[1].Text);
                tempPreferences.putString(ID.LOAD.SONG_AT + i, QuotesList.Items[i].SubItems[2].Text);
            }

            if (tempPreferences.commit())
            {
                Saved = true;
                ErrorLabel.Text = String.Format(Context.getString(ContextIDs.SUCCESS_SAVETO), path + ((path.EndsWith("\\")) ? "" : "\\") + filename);
            }
            else
            {
                ErrorLabel.Text = String.Format(Context.getString(ContextIDs.ERROR_SAVETO), path + ((path.EndsWith("\\")) ? "" : "\\") + filename);
            }
        }

        private void LoadFromFile(string path, string filename)
        {
            ResetListView();
            
            Preference tempPreferences = new Preference(path, filename);

            int length = tempPreferences.getInt(ID.LOAD.LENGTH, 0);
            for(int i = 0; i < length; i++)
            {
                QuotesList.Items.Add(new ListViewItem(new string[]{
                    tempPreferences.getString(ID.LOAD.QUOTE_AT + i, ""),
                    tempPreferences.getString(ID.LOAD.ARTIST_AT + i, ""),
                    tempPreferences.getString(ID.LOAD.SONG_AT + i, "")
                }));
            }

            ApplicationPreferences.edit().putString(ID.LAST_LOADED, path + ((path.EndsWith("\\")) ? "" : "\\") + filename + ".xml").commit();
            ErrorLabel.Text = String.Format(Context.getString(ContextIDs.SUCCESS_LOADFROM), path + ((path.EndsWith("\\")) ? "" : "\\") + filename);
            Saved = true;
        }
        #endregion

        #region Miscellanous
        private void LoadPreviewSettings()
        {
            PreviewSettingsTitleTextBox.Text = Preview.Title;
            PreviewSettingsDescriptionTextBox.Text = Preview.Description;
            PreviewSettingsAvatarShapeComboBox.SelectedIndex = GetAvatarShapeIndex();
            SetButtonColor(PreviewSettingsBackgroundColorButton, Preview.BackgroundColor);
            PreviewSettingsShowHeaderImageCheckBox.Checked = Preview.ShowHeaderImage;
            PreviewSettingsShowAvatarCheckBox.Checked = Preview.ShowAvatar;
            PreviewSettingsShowTitleCheckBox.Checked = Preview.ShowTitle;
            PreviewSettingsShowDescriptionCheckBox.Checked = Preview.ShowDescription;
            SetButtonColor(PreviewSettingsFirstStripeColoButton, Preview.FirstStripeColor);
            SetButtonColor(PreviewSettingsSecondStripeColorButton, Preview.SecondStripeColor);
            SetButtonColor(PreviewSettingsAvatarBorderColorButton, Preview.AvatarBorderColor);
            PreviewSettingsThemeColorComboBox.SelectedIndex = GetThemeColorIndex();
            PreviewSettingsEndlessScrollingCheckBox.Checked = Preview.InfiniteScrolling;
            PreviewSettingsSlidingHeaderCheckBox.Checked = Preview.SlidingHeader;
            PreviewSettingsBackgroundStripesCheckBox.Checked = Preview.BackgroundAsStripes;
            PreviewSettingsShowQuotesCheckBox.Checked = Preview.ShowQuotes;
        }

        private ImageShape GetAvatarShape()
        {
            switch (PreviewSettingsAvatarShapeComboBox.SelectedIndex)
            {
                case 0: return ImageShape.Circular;
                case 1: return ImageShape.Rectangular;
                default: return ImageShape.Circular;
            }
        }

        private int GetAvatarShapeIndex()
        {
            switch (Preview.AvatarShape)
            {
                case ImageShape.Circular: return 0;
                case ImageShape.Rectangular: return 1;
                default: return -1;
            }
        }

        private void SelectColor(Button btn, MaterialDesignTumblrThemeHTMLPreview previewToSetColor, int color)
        {
            DialogResult res = PreviewSettingsColorDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                Color col = PreviewSettingsColorDialog.Color;

                switch (color)
                {
                    case 0: previewToSetColor.BackgroundColor = col; break;
                    case 1: previewToSetColor.FirstStripeColor = col; break;
                    case 2: previewToSetColor.SecondStripeColor = col; break;
                    case 3: previewToSetColor.AvatarBorderColor = col; break;
                }

                SetButtonColor(btn, col);
            }
        }

        private void SetButtonColor(Button btn, Color col)
        {
            btn.BackColor = col;
            btn.ForeColor = Color.FromArgb(255 - col.R, 255 - col.G, 255 - col.B);
        }

        private MaterialColor GetThemeColor()
        {
            switch (PreviewSettingsThemeColorComboBox.SelectedIndex)
            {
                case 0: return MaterialColor.Red;
                case 1: return MaterialColor.Purple;
                case 2: return MaterialColor.Deep_Purple;
                case 3: return MaterialColor.Indigo_Blue;
                case 4: return MaterialColor.Blue;
                case 5: return MaterialColor.Light_Blue;
                case 6: return MaterialColor.Cyan;
                case 7: return MaterialColor.Teal;
                case 8: return MaterialColor.Green;
                case 9: return MaterialColor.Light_Green;
                case 10: return MaterialColor.Lime;
                case 11: return MaterialColor.Yellow;
                case 12: return MaterialColor.Amber;
                case 13: return MaterialColor.Orange;
                case 14: return MaterialColor.Deep_Orange;
                case 15: return MaterialColor.Brown;
                default: return MaterialColor.Brown;
            }
        }

        private int GetThemeColorIndex()
        {
            switch (Preview.ThemeColor)
            {
                case MaterialColor.Red: return 0;
                case MaterialColor.Purple: return 1;
                case MaterialColor.Deep_Purple: return 2;
                case MaterialColor.Indigo_Blue: return 3;
                case MaterialColor.Blue: return 4;
                case MaterialColor.Light_Blue: return 5;
                case MaterialColor.Cyan: return 6;
                case MaterialColor.Teal: return 7;
                case MaterialColor.Green: return 8;
                case MaterialColor.Light_Green: return 9;
                case MaterialColor.Lime: return 10;
                case MaterialColor.Yellow: return 11;
                case MaterialColor.Amber: return 12;
                case MaterialColor.Orange: return 13;
                case MaterialColor.Deep_Orange: return 14;
                case MaterialColor.Brown: return 15;
                default: return -1;
            }
        }

        private void ResetListView()
        {
            QuotesList.Clear();
            QuotesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]{
                    ListViewHeaderQuote,
                    ListViewHeaderArtist,
                    ListViewHeaderSong
            });

            QuoteTextBox.Clear();
            ArtistTextBox.Clear();
            SongTextBox.Clear();
        }

        private string FindPathName(string file)
        {
            return file.Substring(0, file.LastIndexOf('\\'));
        }

        private string FindFileName(string file)
        {
            return file.Substring(file.LastIndexOf('\\') + 1, file.Length - file.LastIndexOf('\\') - 5);
        }
        #endregion

        #region ID classes
        private static class ID
        {
            public static readonly string FIRST = "Is this the first time that this application was loaded on this computer?";
            public static readonly string LAST_LOADED = "Which is the file that was loaded at the end of execution of this program the last time?";

            public static class LOAD
            {
                public static readonly string LENGTH = "This is the amount of things saved in this preference.";
                public static readonly string QUOTE_AT = "This is the quote at the index ";
                public static readonly string ARTIST_AT = "This is the artist at the index ";
                public static readonly string SONG_AT = "This is the song at the index ";
            }
        }
        #endregion
    }
}

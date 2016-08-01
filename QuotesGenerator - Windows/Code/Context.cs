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
using System.Threading;

namespace ContextNS
{
    public class Context
    {
        private static readonly string APPLICATION_LANGUAGE;

        private Context(){}

        static Context()
        {
            APPLICATION_LANGUAGE = /* "en"; // */Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            // Console.Write(APPLICATION_LANGUAGE);
        }

        public static string getString(int id)
        {
            if (id < 0) throw new ArgumentException("ID cannot be less than zero; ID given: " + id + "; ID expected: 0 <= id <= " + (Ressources.en.Length - 1) + ";");

            if(APPLICATION_LANGUAGE == "en" && Ressources.en.Length > id)
            {
                return Ressources.en[id];
            }
            else if(APPLICATION_LANGUAGE == "de" && Ressources.de.Length > id)
            {
                return Ressources.de[id];
            }
            else if(Ressources.en.Length > id)
            {
                return Ressources.en[id];
            }
            else
            {
                throw new ArgumentException("ID is not defined; ID given: " + id + "; ID expected: 0 <= id <= " + (Ressources.en.Length - 1) + ";");
            }
        }

        private static class Ressources
        {
            public static readonly string[] en = {
                "Generate Quotes for Material Design Theme on Tumblr",
                "File",
                "New",
                "Open",
                "Save as project",
                "Generate code",
                "Exit program",
                "Quotes",
                "generated Code",
                "Quote",
                "Artist",
                "Song",
                "Quote:",
                "Artist:",
                "Song:",
                "Add quote",
                "Change selected quote",
                "Delete selected quote",
                "Mix quotes",
                "Unsaved changes",
                "Your current quotes are not saved yet! Do you still want to continue exiting this program? Your progress will not be saved and you will not be able to bring it back!",
                "Your current quotes are not saved yet! Do you still want to continue creating new quotes? Your progress will not be saved and you will not be able to bring it back!",
                "Your current quotes are not saved yet! Do you still want to continue loading other quotes? Your progress will not be saved and you will not be able to bring it back!",
                "You must give a value for Quote, Artist and Song!",
                "Successfully added quote.",
                "You must give a value for Quote, Artist and Song! Didn't change quote.",
                "Successfully changed quote.",
                "You didn't select any quote. Trying adding it: You must give a value for Quote, Artist and Song!",
                "You didn't select any quote. Trying adding it: Successfully added quote.",
                "Successfully deleted quote.",
                "You didn't select a quote to delete.",
                "Successfully mixed the quotes.",
                "You have too few quotes to mix.",
                "Successfully generated code. Copy && Paste it into your Theme Option, and have fun with it! :) Note: You should save your quotes as project to access them again.",
                "Successfully saved to: {0}.xml",
                "Error occured while saving to file: {0}.xml; Please try again.",
                "Successfully loaded from: {0}.xml",
                "Ready",
                "Select a quotes-file to open",
                "Preview",
                "Generate",
                "Open in ext. Browser",
                "Preview successfully generated.",
                "Preview will open in your standard HTML-program. File has been cached in {0}.",
                "Preview settings",
                "Title",
                "Description",
                "Avatar shape",
                "Circle",
                "Rectangle",
                "Background color",
                "Change color",
                "Show header image",
                "Show avatar",
                "Show title",
                "Show description",
                "First Background stripe color",
                "Second Background stripe color",
                "Avatar border color",
                "ThemeColor",
                "Red",
                "Purple",
                "Deep Purple",
                "Indigo Blue",
                "Blue",
                "Light Blue",
                "Cyan",
                "Teal",
                "Green",
                "Light Green",
                "Lime",
                "Yellow",
                "Amber",
                "Orange",
                "Deep Orange",
                "Brown",
                "Endless scrolling",
                "Sliding header",
                "Background as stripes",
                "Show quotes",
                "Pay respect to my hard work",
            };

            public static readonly string[] de = {
                "Generiere Zitate für das Material Design Theme auf Tumblr",
                "Datei",
                "Neu",
                "Öffnen",
                "Als Projekt speichern",
                "Code generieren",
                "Beende Programm",
                "Zitate",
                "Generierter Code",
                "Zitat",
                "Künstler",
                "Lied",
                "Zitat:",
                "Künstler:",
                "Lied:",
                "Zitat hinzufügen",
                "Ausgewähltes Zitat ändern",
                "Ausgewähltes Zitat löschen",
                "Zitate mischen",
                "Ungespeicherter Fortschritt",
                "Ihre derzeitigen Zitate wurden noch nicht gespeichert! Möchten Sie dennoch das Programm beenden? Ihr Fortschritt wird nicht wiederherstellbar gelöscht werden!",
                "Ihre derzeitigen Zitate wurden noch nicht gespeichert! Möchten Sie dennoch ein neues Projekt erstellen? Ihr Fortschritt wird nicht wiederherstellbar gelöscht werden!",
                "Ihre derzeitigen Zitate wurden noch nicht gespeichert! Möchten Sie dennoch andere Zitate laden? Ihr Fortschritt wird nicht wiederherstellbar gelöscht werden!",
                "Sie müssen für das Zitat, den Künstler und das Lied einen Wert eingeben!",
                "Zitat erfolgreich hinzugefügt.",
                "Sie müssen für das Zitat, den Künstler und das Lied einen Wert eingeben! Zitat wurde nicht verändert.",
                "Zitat erfolgreich verändert.",
                "Sie haben kein Zitat ausgewählt. Versuche es hinzuzufügen: Sie müssen für das Zitat, den Künstler und das Lied einen Wert eingeben!",
                "Sie haben kein Zitat ausgewählt. Versuche es hinzuzufügen: Zitat erfolgreich hinzugefügt.",
                "Zitat erfolgreich gelöscht.",
                "Sie haben kein Zitat zum Löschen ausgewählt.",
                "Zitate erfolgreich gemischt.",
                "Sie haben zu wenige Zitate, die man mischen kann.",
                "Code wurde erfolgreich generiert. Copy && Pasten Sie es in ihre Theme Optionen, und haben Sie Spaß damit! :) Hinweis: Sie sollten Ihre Zitate als Projekt speichern, um diese wieder nutzen zu können.",
                "Erfolgeich in folgender Datei gespeichert: {0}.xml",
                "Es trat ein Fehler auf, während in folgende Datei geschrieben werden sollte: {0}.xml; Versuchen Sie es bitte erneut.",
                "Erfolgreich von folgender Datei geladen: {0}.xml",
                "Bereit",
                "Wählen Sie eine Zitat-Datei, die geöffnet werden soll, aus.",
                "Vorschau",
                "Generieren",
                "In ext. Browser öffnen",
                "Vorschau erfolgreich generiert.",
                "Vorschau wird mit ihrem Standard-HTML-Programm geöffnet. Datei wurde in {0} zwischengespeichert.",
                "Einstellungen für die Vorschau",
                "Titel",
                "Beschreibung",
                "Avatarform",
                "Kreis",
                "Rechteck",
                "Hintergrundfarbe",
                "Farbe auswählen",
                "Headerbild zeigen",
                "Avatar zeigen",
                "Titel zeigen",
                "Beschreibung zeigen",
                "Farbe des ersten Hintergrundstreifens",
                "Farbe des zweiten Hintergrundstreifens",
                "Rahmenfarbe des Avatars",
                "Themefarbe",
                "Rot",
                "Lila",
                "Dunkellila",
                "Indigo Blau",
                "Blau",
                "Hellblau",
                "Cyan",
                "Blau-Grün",
                "Grün",
                "Hellgrün",
                "Lime Hellgrün",
                "Gelb",
                "Bernstein",
                "Orange",
                "Dunkelorange",
                "Braun",
                "Endloses Scrollen",
                "Mitgleitendes Headerbild",
                "Hintergrund als Streifen",
                "Zitate zeigen",
                "Meiner harten Arbeit Respekt zollen",
            };
        }
    }

    public class ContextIDs
    {
        public static readonly int FORM_CAPTION                                     = 0;
        public static readonly int FILE_MENUITEM                                    = 1;
        public static readonly int FILE_NEW_MENUITEM                                = 2;
        public static readonly int FILE_OPEN_MENUITEM                               = 3;
        public static readonly int FILE_SAVEASPROJECT_MENUITEM                      = 4;
        public static readonly int FILE_GENERATECODE_MENUITEM                       = 5;
        public static readonly int FILE_EXITPROGRAM_MENUITEM                        = 6;
        public static readonly int TABCAPTIONS_QUOTES                               = 7;
        public static readonly int TABCAPTIONS_GENERATEDCODE                        = 8;
        public static readonly int QUOTES_LISTVIEWCAPTION_QUOTES                    = 9;
        public static readonly int QUOTES_LISTVIEWCAPTION_ARTIST                    = 10;
        public static readonly int QUOTES_LISTVIEWCAPTION_SONG                      = 11;
        public static readonly int QUOTES_LABEL_QUOTE                               = 12;
        public static readonly int QUOTES_LABEL_ARTIST                              = 13;
        public static readonly int QUOTES_LABEL_SONG                                = 14;
        public static readonly int QUOTES_BUTTON_ADD                                = 15;
        public static readonly int QUOTES_BUTTON_CHANGE                             = 16;
        public static readonly int QUOTES_BUTTON_DELETE                             = 17;
        public static readonly int QUOTES_BUTTON_MIX                                = 18;
        public static readonly int ERROR_UNSAVEDCHANGES_CAPTION                     = 19;
        public static readonly int ERROR_UNSAVEDCHANGES_EXITING                     = 20;
        public static readonly int ERROR_UNSAVEDCHANGES_CREATING                    = 21;
        public static readonly int ERROR_UNSAVEDCHANGES_LOADING                     = 22;
        public static readonly int ERROR_NOVALUE_ADDQUOTE                           = 23;
        public static readonly int SUCCESS_ADDQUOTE                                 = 24;
        public static readonly int ERROR_NOVALUE_CHANGEQUOTE                        = 25;
        public static readonly int SUCCES_CHANGEQUOTE                               = 26;
        public static readonly int ERROR_NOSELECT_NOVALUE_CHANGEQUOTE               = 27;
        public static readonly int SUCCESS_NOSELECT_CHANGEQUOTE                     = 28;
        public static readonly int SUCCESS_DELETEQUOTE                              = 29;
        public static readonly int ERROR_NOSELECT_DELETEQUOTE                       = 30;
        public static readonly int SUCCESS_MIXQUOTES                                = 31;
        public static readonly int ERROR_TOOFEW_MIXQUOTES                           = 32;
        public static readonly int SUCCESS_CODEGENERATION                           = 33;
        public static readonly int SUCCESS_SAVETO                                   = 34;
        public static readonly int ERROR_SAVETO                                     = 35;
        public static readonly int SUCCESS_LOADFROM                                 = 36;
        public static readonly int STATUS_INIT                                      = 37;
        public static readonly int LOADDIALOG_CAPTION                               = 38;
        public static readonly int TABCAPTIONS_PREVIEW                              = 39;
        public static readonly int PREVIEW_GENERATE                                 = 40;
        public static readonly int PREVIEW_OPENINEXTBROWSER                         = 41;
        public static readonly int SUCCESS_PREVIEW_GENERATE                         = 42;
        public static readonly int SUCCESS_PREVIEW_OPENINEXTBROWSER                 = 43;
        public static readonly int PREVIEW_SETTINGS_CAPTION                         = 44;
        public static readonly int PREVIEW_SETTINGS_TITLE                           = 45;
        public static readonly int PREVIEW_SETTINGS_DESCRIPTION                     = 46;
        public static readonly int PREVIEW_SETTINGS_AVATARSHAPE                     = 47;
        public static readonly int PREVIEW_SETTINGS_IMAGESHAPE_CIRCLE               = 48;
        public static readonly int PREVIEW_SETTINGS_IMAGESHAPE_RECTANGLE            = 49;
        public static readonly int PREVIEW_SETTINGS_BACKGROUNDCOLOR                 = 50;
        public static readonly int PREVIEW_SETTINGS_CHANGECOLOR                     = 51;
        public static readonly int PREVIEW_SETTINGS_SHOWHEADERIMAGE                 = 52;
        public static readonly int PREVIEW_SETTINGS_SHOWAVATAR                      = 53;
        public static readonly int PREVIEW_SETTINGS_SHOWTITLE                       = 54;
        public static readonly int PREVIEW_SETTINGS_SHOWDESCRIPTION                 = 55;
        public static readonly int PREVIEW_SETTINGS_FIRSTSTRIPECOLOR                = 56;
        public static readonly int PREVIEW_SETTINGS_SECONDSTRIPECOLOR               = 57;
        public static readonly int PREVIEW_SETTINGS_AVATARBORDERCOLOR               = 58;
        public static readonly int PREVIEW_SETTINGS_THEMECOLOR                      = 59;
        public static readonly int PREVIEW_SETTINGS_MATERIALCOLOR_RED               = 60;
        public static readonly int PREVIEW_SETTINGS_MATERIALCOLOR_PURPLE            = 61;
        public static readonly int PREVIEW_SETTINGS_MATERIALCOLOR_DEEPPURPLE        = 62;
        public static readonly int PREVIEW_SETTINGS_MATERIALCOLOR_INDIGOBLUE        = 63;
        public static readonly int PREVIEW_SETTINGS_MATERIALCOLOR_BLUE              = 64;
        public static readonly int PREVIEW_SETTINGS_MATERIALCOLOR_LIGHTBLUE         = 65;
        public static readonly int PREVIEW_SETTINGS_MATERIALCOLOR_CYAN              = 66;
        public static readonly int PREVIEW_SETTINGS_MATERIALCOLOR_TEAL              = 67;
        public static readonly int PREVIEW_SETTINGS_MATERIALCOLOR_GREEN             = 68;
        public static readonly int PREVIEW_SETTINGS_MATERIALCOLOR_LIGHTGREEN        = 69;
        public static readonly int PREVIEW_SETTINGS_MATERIALCOLOR_LIME              = 70;
        public static readonly int PREVIEW_SETTINGS_MATERIALCOLOR_YELLOW            = 71;
        public static readonly int PREVIEW_SETTINGS_MATERIALCOLOR_AMBER             = 72;
        public static readonly int PREVIEW_SETTINGS_MATERIALCOLOR_ORANGE            = 73;
        public static readonly int PREVIEW_SETTINGS_MATERIALCOLOR_DEEPORANGE        = 74;
        public static readonly int PREVIEW_SETTINGS_MATERIALCOLOR_BROWN             = 75;
        public static readonly int PREVIEW_SETTINGS_ENDLESSSCROLLING                = 76;
        public static readonly int PREVIEW_SETTINGS_SLIDINGHEADER                   = 77;
        public static readonly int PREVIEW_SETTINGS_BACKGROUNDSTRIPES               = 78;
        public static readonly int PREVIEW_SETTINGS_SHOWQUOTES                      = 79;
        public static readonly int PREVIEW_SETTINGS_PAYRESPECTTOMYWORK              = 80;
    }
}

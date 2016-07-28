using System;
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

using System.Drawing;

namespace TumblrMaterialThemeQuotesGenerator
{
    class MaterialDesignTumblrThemeHTMLPreview
    {
        private static string ThemeText;

        #region Attributes of the Material Design Tumblr Theme
        public string Title { set; get; }
        public string Description { set; get; }
        public string HeaderImage { set; get; }
        public string AvatarImage { set; get; }
        public ImageShape AvatarShape { set; get; }
        public string TitleFont { set; get; }
        public bool TitleBold { set; get; }
        public Color BackgroundColor { set; get; }
        public bool ShowHeaderImage { set; get; }
        public bool ShowAvatar { set; get; }
        public bool ShowTitle { set; get; }
        public bool ShowDescription { set; get; }
        public Color FirstStripeColor { set; get; }
        public Color SecondStripeColor { set; get; }
        public Color AvatarBorderColor { set; get; }
        public MaterialColor ThemeColor { set; get; }
        public bool SlidingHeader { set; get; }
        public bool BackgroundAsStripes { set; get; }
        public bool ShowQuotes { set; get; }
        public string QuotesJavaScriptCode { set; get; }
        public bool InfiniteScrolling { set; get; }
        public string CustomCSS { get; set; }
        #endregion

        #region Constructors
        public MaterialDesignTumblrThemeHTMLPreview()
        {
            Title = DefaultValues.Title;
            Description = DefaultValues.Description;

            HeaderImage = DefaultValues.HeaderImage;
            AvatarImage = DefaultValues.AvatarImage;

            AvatarShape = DefaultValues.AvatarShape;
            TitleFont = DefaultValues.TitleFont;
            TitleBold = DefaultValues.TitleBold;

            BackgroundColor = DefaultValues.BackgroundColor;
            ShowHeaderImage = DefaultValues.ShowHeaderImage;
            ShowAvatar = DefaultValues.ShowAvatar;
            ShowTitle = DefaultValues.ShowTitle;
            ShowDescription = DefaultValues.ShowDescription;

            FirstStripeColor = DefaultValues.FirstStripeColor;
            SecondStripeColor = DefaultValues.SecondStripeColor;
            AvatarBorderColor = DefaultValues.AvatarBorderColor;

            ThemeColor = DefaultValues.ThemeColor;

            SlidingHeader = DefaultValues.SlidingHeader;
            BackgroundAsStripes = DefaultValues.BackgroundAsStripes;
            ShowQuotes = DefaultValues.ShowQuotes;

            QuotesJavaScriptCode = DefaultValues.QuotesJavaScriptCode;

            InfiniteScrolling = DefaultValues.InfiniteScrolling;

            CustomCSS = DefaultValues.CustomCSS;
        }

        public MaterialDesignTumblrThemeHTMLPreview(string title, string description, string headerimage, string avatarimage, ImageShape avatarShape, string titleFont, bool titleBold,
                Color bgColor, bool showHeaderImage, bool showAvatar, bool showTitle, bool showDescription, Color firstStripeColor, Color secondStripeColor, Color avatarBorderColor,
                MaterialColor themeColor, bool slidingHeader, bool backgroundAsStripes, bool showQuotes, string quotesJavaScriptCode, bool infinitescrolling, string customcss)
        {
            if(title == null)
                this.Title = DefaultValues.Title;
            else
                this.Title = title;

            if (description == null)
                this.Description = DefaultValues.Description;
            else
                this.Description = description;

            if (headerimage == null)
                this.HeaderImage = DefaultValues.HeaderImage;
            else
                this.HeaderImage = headerimage;

            if (avatarimage == null)
                this.AvatarImage = DefaultValues.AvatarImage;
            else
                this.AvatarImage = avatarimage;

            this.AvatarShape = avatarShape;

            if (titleFont == null)
                this.TitleFont = DefaultValues.TitleFont;
            else
                this.TitleFont = titleFont;

            this.TitleBold = titleBold;

            if (bgColor == null)
                this.BackgroundColor = DefaultValues.BackgroundColor;
            else
                this.BackgroundColor = bgColor;

            this.ShowHeaderImage = showHeaderImage;
            this.ShowAvatar = showAvatar;
            this.ShowTitle = showTitle;
            this.ShowDescription = showDescription;

            if (firstStripeColor == null)
                this.FirstStripeColor = DefaultValues.FirstStripeColor;
            else
                this.FirstStripeColor = firstStripeColor;

            if (secondStripeColor == null)
                this.SecondStripeColor = DefaultValues.SecondStripeColor;
            else
                this.SecondStripeColor = secondStripeColor;

            if (avatarBorderColor == null)
                this.AvatarBorderColor = DefaultValues.AvatarBorderColor;
            else
                this.AvatarBorderColor = avatarBorderColor;

            this.ThemeColor = themeColor;
            this.SlidingHeader = slidingHeader;
            this.BackgroundAsStripes = backgroundAsStripes;
            this.ShowQuotes = showQuotes;

            if (quotesJavaScriptCode == null)
                this.QuotesJavaScriptCode = DefaultValues.QuotesJavaScriptCode;
            else
                this.QuotesJavaScriptCode = quotesJavaScriptCode;

            this.InfiniteScrolling = infinitescrolling;

            if (customcss == null)
                this.CustomCSS = DefaultValues.CustomCSS;
            else
                this.CustomCSS = customcss;
        }
        #endregion

        public string GenerateHTML()
        {
            if (ThemeText == null)
                ThemeText = Properties.Resources.MaterialTheme;


/*
<!--

0 - Title
1 - AvatarImage
2 - Quotes Array text
3 - Infinite Scrolling text
4 - Banner css
5 - Stripes css
6 - TitleFont
7 - TitleBold
8 - Avatar Border Color
9 - {block:ShowTitle}margin-bottom: -65px;{/block:ShowTitle}
10 - Custom CSS
11 - ThemeColor
12 - {block:ShowAvatar}<div class="row center avatar-wrapper">
            <a href="/"><img src="{PortraitURL-128}" class="{AvatarShape} avatar hoverable"></a>
        </div>{/block:ShowAvatar}
13 - {block:ShowTitle}<a href="{BlogURL}"><h1 class="title header center {select:ThemeColor}-text">{Title}</h1></a>{/block:ShowTitle}
14 - {block:ShowDescription}<div class="row center">
            <h5 class="header col s12 light">{Description}</h5>
        </div>{/block:ShowDescription}
15 - {block:IfShowQuotes}<div class="container">
            <div class="row center">
                <div class="col s10 offset-s1">
                    <div class="card {select:ThemeColor} hoverable">
                        <div class="card-content white-text">
                            <span class="card-title" id="quote-caption">Quote of the week</span>
                            <p id="quote-text"></p>
                        </div>
                        <div class="card-action">
                            <a href="#" onclick="setRandomQuote(); return false;">Get a new quote</a>
                            <a href="#" onclick="setNextQuote(); return false;">Get the next quote</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>{/block:IfShowQuotes}
        {block:IfNotShowQuotes}<div style="height: 15px;"></div>{/block:IfNotShowQuotes}
16 - {{block:IfNotEndlessScrolling}}{{block:Pagination}}<div class="card {{select:ThemeColor}} hoverable">
            <div class="card-content">
                <br/>
                <div class="row center">
                    {{block:PreviousPage}}<a href="{{PreviousPage}}" id="previous-page-button" class="btn waves-effect waves-light not-disabled {{select:ThemeColor}}">&lt;&lt;</a>{{/block:PreviousPage}}
                    <a href="#" onclick="return false;" class="btn waves-effect waves-light {{select:ThemeColor}}">{{CurrentPage}} / {{TotalPages}}</a>
                    {{block:NextPage}}<a href="{{NextPage}}" id="next-page-button" class="btn waves-effect waves-light not-disabled {{select:ThemeColor}}">&gt;&gt;</a>{{/block:NextPage}}
                </div>
            </div>
        </div>{{/block:Pagination}}{{/block:IfNotEndlessScrolling}}
17 - {{block:IfEndlessScrolling}}<div class="row center">
            <h3 class="grey-text text-lighten-4">This seems to be it with this blog.</h3>
        </div>{{/block:IfEndlessScrolling}}
18 - {{block:IfShowQuotes}}<script type="text/javascript">
var setWeeklyQuote = function(){{
    if(quotes.length != 0){{
        var now = new Date();
        var onejan = new Date(now.getFullYear(), 0, 1);
        var week = Math.ceil( (((now - onejan) / 86400000) + onejan.getDay() + 1) / 7 );

        current_quote_index = week % quotes.length;
        document.getElementById("quote-text").innerHTML = quotes[current_quote_index];
    }}
}};

var setRandomQuote = function(){{
    if(quotes.length != 0){{
        document.getElementById("quote-caption").innerHTML = "Quote";
        current_quote_index = Math.floor(Math.random() * quotes.length);
        document.getElementById("quote-text").innerHTML = quotes[current_quote_index];
    }}
}}

var setNextQuote = function(){{
    if(quotes.length != 0){{
        document.getElementById("quote-caption").innerHTML = "Quote";
        current_quote_index = (current_quote_index + 1) % quotes.length;
        document.getElementById("quote-text").innerHTML = quotes[current_quote_index];
    }}
}}

setWeeklyQuote();
        </script>{{/block:IfShowQuotes}}

-->
*/

            string quotes = (ShowQuotes) ? "<script type=\"text/javascript\">\nvar current_quote_index = 0;\nvar quotes = [\n\t" + QuotesJavaScriptCode + "\n];\n\t\t</script>\n\t\t": "";
            string infinitescrolling = (InfiniteScrolling) ? "<script type=\"text/javascript\" src=\"http://static.tumblr.com/q0etgkr/EIBmz7s0p/infinitescrolling.js\"></script>\n\t\t": "";
            string banner = (ShowHeaderImage) ? "background-image: url(" + HeaderImage + ");\n\tbackground-repeat: no-repeat;\n\tbackground-size: cover;\n\tbackground-position: center;\n\tbackground-attachment: " + ((SlidingHeader)? "fixed":"scroll") + ";" : "";
            string stripesbackground = (BackgroundAsStripes) ? "background: repeating-linear-gradient(45deg, " + ColorToHex(FirstStripeColor) + ", " + ColorToHex(FirstStripeColor) + " 30px, " + ColorToHex(SecondStripeColor) + " 30px, " + ColorToHex(SecondStripeColor) + " 60px);" : "background-color: " + ColorToHex(BackgroundColor) + ";";
            string titlebold = (TitleBold) ? "bold" : "normal";
            string avatarwrappercss = (ShowTitle) ? "margin-bottom: -65px;" : "";
            string avatar = (ShowAvatar) ? "<div class=\"row center avatar-wrapper\">\n\t\t\t\t\t<a href=\"#\"><img src=\"" + AvatarImage + "\" class=\"" + ImageShapeToString(AvatarShape) + " avatar hoverable\"></a>\n\t\t\t\t</div>\n\t\t\t\t" : "";
            string title = (ShowTitle) ? "<a href=\"#\"><h1 class=\"title header center " + MaterialColorToString(ThemeColor) + "-text\">" + Title + "</h1></a>\n\t\t\t\t" : "";
            string description = (ShowDescription) ? "<div class=\"row center\">\n\t\t\t\t\t\t\t<h5 class=\"header col s12 light\">" + Description + "</h5>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t\t" : "";
            string quotescontainer = (ShowQuotes) ?
                "<div class=\"container\">\n\t\t\t\t\t<div class=\"row center\">\n\t\t\t\t\t\t<div class=\"card " + MaterialColorToString(ThemeColor) + " hoverable\">\n\t\t\t\t\t\t\t<div class=\"card-content white-text\">\n\t\t\t\t\t\t\t\t<span " +
                "class=\"card-title\" id=\"quote-caption\">Quote of the week</span>\n\t\t\t\t\t\t\t\t<p id=\"quote-text\"></p>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t<div class=\"card-action\">\n\t\t\t\t\t\t\t\t<a href=\"#\" onclick=\"setRandomQuote(); " + 
                "return false;\">Get a new quote</a>\n\t\t\t\t\t\t\t\t<a href=\"#\" onclick=\"setNextQuote(); return false;\">Get the next quote</a>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t</div>\n\t\t\t\t</div>" :
                "<div style=\"height: 15px; \"></div>\n\t\t\t\t";
            string pagination = (!InfiniteScrolling) ? "<div class=\"card " + MaterialColorToString(ThemeColor) + " hoverable\">\n\t\t\t\t\t\t\t<div class=\"card-content\">\n\t\t\t\t\t\t\t\t<br/>\n\t\t\t\t\t\t\t\t<div class=\"row center\">\n\t\t\t\t\t\t\t\t<a href=\"#\" onclick=\"return false;\" class=\"btn waves-effect waves-light " + 
                MaterialColorToString(ThemeColor) + "\">1 / 2</a>\n\t\t\t\t\t\t\t\t<a href=\"#\" onclick=\"return false;\" id=\"next-page-button\" class=\"btn waves-effect waves-light not-disabled " + MaterialColorToString(ThemeColor) + "\">&gt;&gt;</a>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t</div>" : "";
            string endcaption = (InfiniteScrolling) ? "<div class=\"row center\">\n\t\t\t\t\t\t\t<h3 class=\"grey-text text-lighten-4\">This seems to be it with this blog.</h3>\n\t\t\t\t\t\t</div>" : "";
            string showquotescode = (ShowQuotes) ? "<script type=\"text/javascript\">\nvar setWeeklyQuote = function(){\n\tif (quotes.length != 0){\n\t\tvar now = new Date();\n\t\tvar onejan = new Date(now.getFullYear(), 0, 1);\n\t\tvar week = " +
                "Math.ceil((((now - onejan) / 86400000) + onejan.getDay() + 1) / 7);\n\t\t\n\t\tcurrent_quote_index = week % quotes.length;\n\t\tdocument.getElementById(\"quote-text\").innerHTML = quotes[current_quote_index];\n\t}\n};\n\nvar setRandomQuote " +
                "= function(){\n\tif (quotes.length != 0){\n\t\tdocument.getElementById(\"quote-caption\").innerHTML = \"Quote\";\n\t\tcurrent_quote_index = Math.floor(Math.random() * quotes.length);\n\t\tdocument.getElementById(\"quote-text\").innerHTML = " +
                "quotes[current_quote_index];\n\t}\n};\n\nvar setNextQuote = function(){\n\tif (quotes.length != 0){\n\t\tdocument.getElementById(\"quote-caption\").innerHTML = \"Quote\";\n\t\tcurrent_quote_index = (current_quote_index + 1) % quotes.length;\n" +
                "\t\tdocument.getElementById(\"quote-text\").innerHTML = quotes[current_quote_index];\n\t}\n};\n\nsetWeeklyQuote();\n\t\t</script>" : "";

            return String.Format(
                ThemeText, 
                Title, //0
                AvatarImage, //1
                quotes, //2
                infinitescrolling, //3
                banner, //4
                stripesbackground, //5
                TitleFont, //6
                titlebold, //7
                ColorToHex(AvatarBorderColor), //8
                avatarwrappercss, //9
                CustomCSS, //10
                MaterialColorToString(ThemeColor), //11
                avatar, //12
                title, //13
                description, //14
                quotescontainer, //15
                pagination, //16
                endcaption, //17
                showquotescode //18
            );
        }

        #region Static context
        #region Preference methods
        public static MaterialDesignTumblrThemeHTMLPreview LoadPreview(Preference pref)
        {
            return new MaterialDesignTumblrThemeHTMLPreview(
                pref.getString(PreferenceIDs.TITLE, DefaultValues.Title),
                pref.getString(PreferenceIDs.DESCRIPTION, DefaultValues.Description),
                pref.getString(PreferenceIDs.HEADER_IMG, DefaultValues.HeaderImage),
                pref.getString(PreferenceIDs.AVATAR_IMG, DefaultValues.AvatarImage),
                FromIntToImageShape(pref.getInt(PreferenceIDs.AVATAR_SHAPE, FromImageShapeToInt(DefaultValues.AvatarShape))),
                pref.getString(PreferenceIDs.TITLEFONT, DefaultValues.TitleFont),
                pref.getBoolean(PreferenceIDs.TITLEBOLD, DefaultValues.TitleBold),
                Color.FromArgb(pref.getInt(PreferenceIDs.BACKGROUND_COLOR, DefaultValues.BackgroundColor.ToArgb())),
                pref.getBoolean(PreferenceIDs.SHOW_HEADER_IMG, DefaultValues.ShowHeaderImage),
                pref.getBoolean(PreferenceIDs.SHOW_AVATAR_IMG, DefaultValues.ShowAvatar),
                pref.getBoolean(PreferenceIDs.SHOW_TITLE, DefaultValues.ShowTitle),
                pref.getBoolean(PreferenceIDs.SHOW_DESCRIPTION, DefaultValues.ShowDescription),
                Color.FromArgb(pref.getInt(PreferenceIDs.FIRST_STRIPE_COLOR, DefaultValues.FirstStripeColor.ToArgb())),
                Color.FromArgb(pref.getInt(PreferenceIDs.SECOND_STRIPE_COLOR, DefaultValues.SecondStripeColor.ToArgb())),
                Color.FromArgb(pref.getInt(PreferenceIDs.AVATAR_BORDER_COLOR, DefaultValues.AvatarBorderColor.ToArgb())),
                FromIntToMaterialColor(pref.getInt(PreferenceIDs.THEMECOLOR, FromMaterialColorToInt(DefaultValues.ThemeColor))),
                pref.getBoolean(PreferenceIDs.SLIDING_HEADER, DefaultValues.SlidingHeader),
                pref.getBoolean(PreferenceIDs.BACKGROUND_STRIPES, DefaultValues.BackgroundAsStripes),
                pref.getBoolean(PreferenceIDs.SHOW_QUOTES, DefaultValues.ShowQuotes),
                pref.getString(PreferenceIDs.QUOTESJAVASCRIPTCODE, DefaultValues.QuotesJavaScriptCode),
                pref.getBoolean(PreferenceIDs.INFINITESCROLLING, DefaultValues.InfiniteScrolling),
                pref.getString(PreferenceIDs.CUSTOMCSS, DefaultValues.CustomCSS)
            );
        }

        public static Preference.Editor PutMaterialDesignTumblrThemeHTMLPreview(Preference.Editor edit, MaterialDesignTumblrThemeHTMLPreview preview)
        {
            return edit
                .putString(PreferenceIDs.TITLE,                 preview.Title)
                .putString(PreferenceIDs.DESCRIPTION,           preview.Description)
                .putString(PreferenceIDs.HEADER_IMG,            preview.HeaderImage)
                .putString(PreferenceIDs.AVATAR_IMG,            preview.AvatarImage)
                .putInt(PreferenceIDs.AVATAR_SHAPE,             FromImageShapeToInt(preview.AvatarShape))
                .putString(PreferenceIDs.TITLEFONT,             preview.TitleFont)
                .putBoolean(PreferenceIDs.TITLEBOLD,            preview.TitleBold)
                .putInt(PreferenceIDs.BACKGROUND_COLOR,         preview.BackgroundColor.ToArgb())
                .putBoolean(PreferenceIDs.SHOW_HEADER_IMG,      preview.ShowHeaderImage)
                .putBoolean(PreferenceIDs.SHOW_AVATAR_IMG,      preview.ShowAvatar)
                .putBoolean(PreferenceIDs.SHOW_TITLE,           preview.ShowTitle)
                .putBoolean(PreferenceIDs.SHOW_DESCRIPTION,     preview.ShowDescription)
                .putInt(PreferenceIDs.FIRST_STRIPE_COLOR,       preview.FirstStripeColor.ToArgb())
                .putInt(PreferenceIDs.SECOND_STRIPE_COLOR,      preview.SecondStripeColor.ToArgb())
                .putInt(PreferenceIDs.AVATAR_BORDER_COLOR,      preview.AvatarBorderColor.ToArgb())
                .putInt(PreferenceIDs.THEMECOLOR,               FromMaterialColorToInt(preview.ThemeColor))
                .putBoolean(PreferenceIDs.SLIDING_HEADER,       preview.SlidingHeader)
                .putBoolean(PreferenceIDs.BACKGROUND_STRIPES,   preview.BackgroundAsStripes)
                .putBoolean(PreferenceIDs.SHOW_QUOTES,          preview.ShowQuotes)
                .putString(PreferenceIDs.QUOTESJAVASCRIPTCODE,  preview.QuotesJavaScriptCode)
                .putBoolean(PreferenceIDs.INFINITESCROLLING,    preview.InfiniteScrolling)
                .putString(PreferenceIDs.CUSTOMCSS,             preview.CustomCSS);
        }
        #endregion

        #region ToString-Methods
        private static string ImageShapeToString(ImageShape shape)
        {
            switch (shape)
            {
                case ImageShape.Circular:       return "circle";
                case ImageShape.Rectangular:    return "square";
                default:                        return null;
            }
        }

        private static string MaterialColorToString(MaterialColor color)
        {
            switch (color)
            {
                case MaterialColor.Red:             return "red";
                case MaterialColor.Purple:          return "purple";
                case MaterialColor.Deep_Purple:     return "deep-purple";
                case MaterialColor.Indigo_Blue:     return "indigo";
                case MaterialColor.Blue:            return "blue";
                case MaterialColor.Light_Blue:      return "light-blue";
                case MaterialColor.Cyan:            return "cyan";
                case MaterialColor.Teal:            return "teal";
                case MaterialColor.Green:           return "green";
                case MaterialColor.Light_Green:     return "light-green";
                case MaterialColor.Lime:            return "lime";
                case MaterialColor.Yellow:          return "yellow";
                case MaterialColor.Amber:           return "amber";
                case MaterialColor.Orange:          return "orange";
                case MaterialColor.Deep_Orange:     return "deep-orange";
                case MaterialColor.Brown:           return "brown";
                default:                            return null;
            }
        }
        
        private static string ColorToHex(Color col)
        {
            return "#" + string.Format("{0:x6}", col.ToArgb() & 0xFFFFFF);
        }
        #endregion
        #endregion

        #region Misc-Methods for saving and loading
        private static int FromImageShapeToInt(ImageShape shape)
        {
            switch (shape)
            {
                case ImageShape.Circular:       return 0x123;
                case ImageShape.Rectangular:    return 0x321;
                default:                        return -1;
            }
        }

        private static ImageShape FromIntToImageShape(int shape)
        {
            switch (shape)
            {
                case 0x123:     return ImageShape.Circular;
                case 0x321:     return ImageShape.Rectangular;
                default:        return ImageShape.Circular;
            }
        }

        private static int FromMaterialColorToInt(MaterialColor color)
        {
            switch (color)
            {
                case MaterialColor.Red:             return 12;
                case MaterialColor.Purple:          return 23;
                case MaterialColor.Deep_Purple:     return 34;
                case MaterialColor.Indigo_Blue:     return 45;
                case MaterialColor.Blue:            return 56;
                case MaterialColor.Light_Blue:      return 67;
                case MaterialColor.Cyan:            return 78;
                case MaterialColor.Teal:            return 89;
                case MaterialColor.Green:           return 910;
                case MaterialColor.Light_Green:     return 1011;
                case MaterialColor.Lime:            return 1112;
                case MaterialColor.Yellow:          return 1213;
                case MaterialColor.Amber:           return 1314;
                case MaterialColor.Orange:          return 1415;
                case MaterialColor.Deep_Orange:     return 1516;
                case MaterialColor.Brown:           return 1617;
                default:                            return -1;
            }
        }

        private static MaterialColor FromIntToMaterialColor(int color)
        {
            switch (color)
            {
                case 12:        return MaterialColor.Red;
                case 23:        return MaterialColor.Purple;
                case 34:        return MaterialColor.Deep_Purple;
                case 45:        return MaterialColor.Indigo_Blue;
                case 56:        return MaterialColor.Blue;
                case 67:        return MaterialColor.Light_Blue;
                case 78:        return MaterialColor.Cyan;
                case 89:        return MaterialColor.Teal;
                case 910:       return MaterialColor.Green;
                case 1011:      return MaterialColor.Light_Green;
                case 1112:      return MaterialColor.Lime;
                case 1213:      return MaterialColor.Yellow;
                case 1314:      return MaterialColor.Amber;
                case 1415:      return MaterialColor.Orange;
                case 1516:      return MaterialColor.Deep_Orange;
                case 1617:      return MaterialColor.Brown;
                default:        return MaterialColor.Brown;
            }
        }
        #endregion

        private static class DefaultValues
        {
            public static readonly string Title = "Test Material Design Theme";
            public static readonly string Description = "Hello World, this is a quick description of me. I don't actually write anything reasonable here, but it's also just thought as a filler, so... :)";

            public static readonly string HeaderImage = "http://static.tumblr.com/62567c4dbf482efd0f3598d8b1a5431a/642aqpc/YVjo8bckd/tumblr_static_40bqiokp5ta8sksog8c0o8kk0_2048_v2.jpg";
            public static readonly string AvatarImage = "http://67.media.tumblr.com/avatar_ff17e3193309_128.png";

            public static readonly ImageShape AvatarShape = ImageShape.Circular;
            public static readonly string TitleFont = "'Typewriter FS', serif;";
            public static readonly bool TitleBold = true;

            public static readonly Color BackgroundColor = Color.FromArgb(0xFF, 0xCE, 0x0E, 0x0E);

            public static readonly bool ShowHeaderImage = true;
            public static readonly bool ShowAvatar = true;
            public static readonly bool ShowTitle = true;
            public static readonly bool ShowDescription = true;

            public static readonly Color FirstStripeColor = Color.FromArgb(0xFF, 0xFF, 0x00, 0x11);
            public static readonly Color SecondStripeColor = Color.FromArgb(0xFF, 0x80, 0xFF, 0x00);
            public static readonly Color AvatarBorderColor = Color.FromArgb(0xFF, 0x64, 0x4B, 0x74);

            public static readonly MaterialColor ThemeColor = MaterialColor.Brown;

            public static readonly bool SlidingHeader = true;
            public static readonly bool BackgroundAsStripes = true;
            public static readonly bool ShowQuotes = true;

            public static readonly string QuotesJavaScriptCode = "Look into the footer of the theme for an explanation!";

            public static readonly bool InfiniteScrolling = true;
            public static readonly string CustomCSS = "";
        }

        private static class PreferenceIDs
        {
            public static readonly string TITLE = "Title of your testblog ^^";
            public static readonly string DESCRIPTION = "Description of your testblog ^^";
            public static readonly string HEADER_IMG = "The path to the header-image of your testblog ^^";
            public static readonly string AVATAR_IMG = "The path to the avatar-image of your testblog ^^";
            public static readonly string AVATAR_SHAPE = "The shape of the avatar-image of your testblog ^^";
            public static readonly string BACKGROUND_COLOR = "The background-color of the non-browser version of your testblog ^^";
            public static readonly string SHOW_HEADER_IMG = "Whether the header-image is supposed to be shown on your testblog ^^";
            public static readonly string SHOW_AVATAR_IMG = "Whether the avatar-image is supposed to be shown on your testblog ^^";
            public static readonly string SHOW_TITLE = "Whether the title of your testblog is supposed to be shown ^^";
            public static readonly string SHOW_DESCRIPTION = "Whether the description of your testblog is supposed to be shown ^^";
            public static readonly string FIRST_STRIPE_COLOR = "The color of the first stripe in your testblog ^^";
            public static readonly string SECOND_STRIPE_COLOR = "The color of the second stripe in your testblog ^^";
            public static readonly string AVATAR_BORDER_COLOR = "The color of the border of your avatar in your testblog ^^";
            public static readonly string THEMECOLOR = "The themecolor of your testblog ^^";
            public static readonly string SLIDING_HEADER = "Whether the header-image of your testblog is supposed to be siliding ^^";
            public static readonly string BACKGROUND_STRIPES = "Whether the background of your testblog is supposed to be stripes ^^";
            public static readonly string SHOW_QUOTES = "Whether the quotes are supposed to be shown in your testblog ^^";
            public static readonly string TITLEFONT = "The font of the title of your testblog ^^";
            public static readonly string TITLEBOLD = "Whether the title of your testblog is supposed to be bold ^^";
            public static readonly string QUOTESJAVASCRIPTCODE = "The quotes of your testblog in javascript code ^^";
            public static readonly string INFINITESCROLLING = "Whether the posts of your testblog are supposed to be automatically loaded ^^";
            public static readonly string CUSTOMCSS = "The customizing css of your testblog ^^";
        }
    }

    enum ImageShape
    {
        Rectangular,
        Circular
    }

    enum MaterialColor
    {
        Red,
        Purple,
        Deep_Purple,
        Indigo_Blue,
        Blue,
        Light_Blue,
        Cyan,
        Teal,
        Green,
        Light_Green,
        Lime,
        Yellow,
        Amber,
        Orange,
        Deep_Orange,
        Brown
    }
}

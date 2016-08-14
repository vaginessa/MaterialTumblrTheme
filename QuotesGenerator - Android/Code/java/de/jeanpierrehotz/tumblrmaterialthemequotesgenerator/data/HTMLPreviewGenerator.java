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

package de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.data;

import android.content.SharedPreferences;
import android.graphics.Color;

public class HTMLPreviewGenerator{
    private static String sThemeText = "<!DOCTYPE HTML>\n" + "<!-- \n" + "    Copyright 2016 Jean-Pierre Hotz\n" + "Licensed under the Apache License, Version 2.0 (the \"License\");\n" + "you may not use this file except in compliance with the License.\n" + "You may obtain a copy of the License at\n" + "\n" + "    http://www.apache.org/licenses/LICENSE-2.0\n" + "\n" + "Unless required by applicable law or agreed to in writing, software\n" + "distributed under the License is distributed on an \"AS IS\" BASIS,\n"
            + "WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.\n" + "See the License for the specific language governing permissions and\n" + "limitations under the License.\n" + "-->\n" + "<html>\n" + "    <head>\n" + "        <title>{0}</title>\n" + "        <meta charset=\"UTF-8\"/>\n" + "        \n" + "        <link rel=\"shortcut icon\" href=\"{1}\">\n" + "        <link href=\"http://fonts.googleapis.com/icon?family=Material+Icons\" rel=\"stylesheet\">\n"
            + "        <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.6/css/materialize.min.css\">\n" + "\n" + "        {2}{3}\n" + "\n" + "        <style type=\"text/css\">\n" + ".white-text a{\n" + "    color:white;\n" + "}\n" + ".white-text a:hover{\n" + "    text-decoration: underline;\n" + "}\n" + ".banner-in-background{\n" + "    {4}\n" + "}\n" + ".alphasized{\n" + "    background: rgba(255, 255, 255, 0.7);\n" + "    border-radius: 10px;\n"
            + "}\n" + ".repeating-background-gradient{\n" + "    {5}\n" + "}\n" + ".content-wrapper{\n" + "    margin-top: -20px;\n" + "    padding-top: 20px;\n" + "}\n" + ".tags{\n" + "    margin-bottom: 0px;\n" + "}\n" + ".tags li{\n" + "    display: inline;\n" + "}\n" + ".tags li:link{\n" + "    color: #121212;\n" + "}\n" + ".tags li:hover{\n" + "    color: #121212;\n" + "    text-decoration: underline;\n" + "}\n" + ".tags li:visited{\n" + "    color: #121212;\n"
            + "}\n" + ".photo-post-img-wrapper{\n" + "    width: 100%;\n" + "}\n" + ".photo-post-img{\n" + "    max-height: 700px;\n" + "    max-width: 100%;\n" + "    border-radius: 5px;\n" + "}\n" + ".photo-post-set-img-wrapper{\n" + "    width: 100%;\n" + "}\n" + ".photo-post-set-img{\n" + "    max-height: 700px;\n" + "    max-width: 100%;\n" + "    border-radius: 5px;\n" + "}\n" + ".link-post-anchor{\n" + "    color: white;\n" + "}\n" + ".link-post-anchor:hover{\n" + "    color: white;\n"
            + "    text-decoration: underline;\n" + "}\n" + ".link-post-anchor:visited{\n" + "    color: white;\n" + "}\n" + ".link-post-anchor:link{\n" + "    color: white;\n" + "}\n" + ".chat-name{\n" + "    color: #bcaaa4;\n" + "    text-decoration: underline;\n" + "}\n" + ".audio-post-content{\n" + "    border-radius: 5px;\n" + "    width: 100%;\n" + "}\n" + ".video-post-content-wrapper{\n" + "    max-width: 100%;\n" + "    max-height: 700px;\n" + "}\n" + ".video-post-content-wrapper iframe{\n"
            + "    width: 100%;\n" + "    border-radius: 5px;\n" + "}\n" + ".answer-person{\n" + "    font-weight: bold;\n" + "    color: white;\n" + "}\n" + ".answer-person:hover{\n" + "    text-decoration: underline;\n" + "}\n" + ".reblog a{\n" + "    font-size: 14px;\n" + "    color: white;\n" + "    text-decoration: none;\n" + "}\n" + ".reblog a:hover{\n" + "    text-decoration: underline;\n" + "}\n" + ".quote a{\n" + "    color: white;\n" + "}\n" + ".quote a:hover{\n"
            + "    text-decoration: underline;\n" + "}\n" + ".tumblr-btn-class{\n" + "    display: inline;\n" + "    float: right;\n" + "}\n" + ".page-footer{\n" + "    margin-bottom: -20px;\n" + "}\n" + ".title{\n" + "    font-family: {6};\n" + "    font-weight: {7};\n" + "}\n" + ".square{\n" + "    border-radius: 10px;\n" + "}\n" + ".circle{\n" + "    border-radius: 1000px;\n" + "}\n" + ".avatar{\n" + "    border-style: solid;\n" + "    border-width: 3px;\n" + "    border-color: {8};\n"
            + "}\n" + ".avatar-wrapper{\n" + "    {9}\n" + "}\n" + ".footer-thanks-item:hover{\n" + "    text-decoration: underline;\n" + "}\n" + ".material-icons{\n" + "    color: white;\n" + "}\n" + ".socialmedia-icon{\n" + "    width: 24px;\n" + "    float: right;\n" + "}\n" + "\n" + "/* Enable custom css, because it's nice to customize */\n" + "{10}\n" + "        </style>\n" + "        <link rel=\"stylesheet\" type=\"text/css\" href=\"http://assets.tumblr.com/fonts/typewriterfs/stylesheet.css?v=1\">\n"
            + "    </head>\n" + "    <body>\n" + "        <nav role=\"navigation\" class=\"{11}\">\n" + "            <div class=\"nav-wrapper container\">\n" + "                <form action=\"/search\" method=\"get\" id=\"search\" >\n" + "                    <label class=\"searchbar-label\">\n" + "                        <input type=\"text\" class=\"search-field\" name=\"q\" id=\"q\" placeholder=\"Search yourtestblogsname\" value=\"\" autocomplete=\"off\">\n" + "                    </label>\n" + "                </form>\n"
            + "            </div>\n" + "        </nav>\n" + "        <div class=\"repeating-background-gradient\">\n" + "            <div class=\"section no-pad-bot banner-in-background\" id=\"index-banner\">\n" + "                <div class=\"container alphasized hoverable\">\n" + "                    <br/><br/>\n" + "                    {12}\n" + "                    {13}\n" + "                    <div class=\"container\">\n" + "                        {14}\n" + "                        <div class=\"row center\">\n"
            + "                            <a href=\"#\" onclick=\"return false;\" id=\"ask-me-anything-button\" class=\"btn waves-effect waves-light {11}\">Ask me anything!</a>\n" + "                            <a href=\"#\" onclick=\"return false;\" id=\"likes-button\" class=\"btn waves-effect waves-light {11}\">Likes</a>\n" + "                            <a href=\"#\" onclick=\"return false;\" id=\"archive-button\" class=\"btn waves-effect waves-light {11}\">Archive</a>\n" + "                        </div>\n" + "                    </div>\n" + "                    <br/>\n"
            + "                </div>\n" + "                {15}\n" + "            </div>\n" + "            <div class=\"section content-wrapper\">\n" + "                <div class=\"container\">\n" + "                    <div class=\"autopagerize_page_element\">\n" + "\n" + "                        <div class=\"card {11} hoverable\">\n" + "                            <div class=\"card-content white-text\">\n" + "                                <h5><span class=\"answer-person\">Anonymous</span> asked:</h5>\n"
            + "                                <p>Hey dude nicer dicer Website, but I have one question... Whacha doing with your freetime m8 xD</p>\n" + "                                <h5><span class=\"answer-person\"><a href=\"#\" class=\"answerer\" onclick=\"return false;\">yourtestblogsname</a></span> answered:</h5>\n" + "                                <p><p>Thanks :*</p><p>Definitely did not sleep last night, could need a coffee rn&hellip; But as you can see in the tags of my posts I made last night this was predictable :D</p></p>\n"
            + "                                <br/><br/>\n" + "                                <p>This is a small test for q&amp;a-posts :*</p><p>please be patient with me :D</p>\n" + "                                <br><span class=\"reblog\">Reblogged from <a href=\"#\" onclick=\"return false;\">yourtestblogsname</a></span>\n" + "                                <div class=\"divider\"></div>\n" + "                                <ul class=\"tags\">\n" + "                                    <a href=\"#\" onclick=\"return false;\"><li>still testing my shit</li></a>\n"
            + "                                    <a href=\"#\" onclick=\"return false;\"><li>hopefully soon over</li></a>\n" + "                                    <a href=\"#\" onclick=\"return false;\"><li>going through hell right now</li></a>\n" + "                                    <a href=\"#\" onclick=\"return false;\"><li>holy shit</li></a>\n" + "                                </ul>\n" + "                            </div>\n" + "                            <div class=\"card-action\">\n"
            + "                                <a href=\"#\" onclick=\"return false;\">1 note</a>\n" + "                                <!-- To stretch the bottom of the card... posts without notes were ugly :/ -->\n" + "                                <a class=\"{11}-text\"> </a>\n" + "                                <div class=\"tumblr-btn-class\"><div class=\"like_button\" data-post-id=\"145504460740\" data-blog-name=\"hellowprl\" id=\"like_button_145504460740\"><a href=\"#\" onclick=\"return false;\"><i class=\"material-icons\">&#xE87D;</i></a></div></div>\n"
            + "                                <div class=\"tumblr-btn-class\"><a href=\"#\" class=\"reblog_button\" style=\"display: block;width:20px;height:20px;\" onclick=\"return false;\"><i class=\"material-icons\">&#xE040;</i></a></div>\n" + "                            </div>\n" + "                        </div>\n" + "\n" + "                        <div class=\"card {11} hoverable\">\n" + "                            <div class=\"card-content white-text\">\n"
            + "                                <h5><span class=\"answer-person\">Anonymous</span> asked:</h5>\n" + "                                <p>Hey dude nicer dicer Website, but I have one question... Whacha doing with your freetime m8 xD</p>\n" + "                                <br/><br/>\n" + "                                <p>Thanks :*</p><p>Definitely did not sleep last night, could need a coffee rn&hellip; But as you can see in the tags of my posts I made last night this was predictable :D</p>\n"
            + "                            </div>\n" + "                            <div class=\"card-action\">\n" + "                                <a href=\"#\" onclick=\"return false;\">1 note</a>\n" + "                                <!-- To stretch the bottom of the card... posts without notes were ugly :/ -->\n" + "                                <a class=\"{11}-text\"> </a>\n" + "                                <div class=\"tumblr-btn-class\"><div class=\"like_button\" data-post-id=\"145504460740\" data-blog-name=\"hellowprl\" id=\"like_button_145504460740\"><a href=\"#\" onclick=\"return false;\"><i class=\"material-icons\">&#xE87D;</i></a></div></div>\n"
            + "                                <div class=\"tumblr-btn-class\"><a href=\"#\" class=\"reblog_button\" style=\"display: block;width:20px;height:20px;\" onclick=\"return false;\"><i class=\"material-icons\">&#xE040;</i></a></div>\n" + "                            </div>\n" + "                        </div>\n" + "\n" + "                        <div class=\"card {11} hoverable\">\n" + "                            <div class=\"card-content white-text\">\n"
            + "                                <span class=\"card-title\">Infinite Scrolling in custom themes</span>\n" + "                                <p><p>Are you trying to create a custom theme with infinite scroll feature, but don&rsquo;t find a proper explanation how to do so?</p><p>Well I had the this problem, and to save you from a pain in the ass I&rsquo;ll just show you here:</p><p>You probably found a couple of tutorials linking to&nbsp;<a href=\"#\" onclick=\"return false;\">http://codysherman.com/tools/infinite-scrolling/code</a>, which would (if you&rsquo;d look into the developer console of your browser on your blog with the theme) only return 404 errors. This is because the blog, which hosted this file has been deleted (I don&rsquo;t know for which reason). Yet this file is still availabe in tumblrs assets with this link:&nbsp;<a href=\"#\" onclick=\"return false;\">http://static.tumblr.com/q0etgkr/EIBmz7s0p/infinitescrolling.js</a></p><p>Now this script though requires you to put a container around your posts with the class&nbsp;&ldquo;autopagerize_page_element&rdquo;.</p><p>So all you have to do is to include the script in your head-Tag and create the wrapper around your posts. This should then look somewhat like this:</p><pre><code>  ...\n" + "  &lt;script type=\"text/javascript\" src=\"http://static.tumblr.com/q0etgkr/EIBmz7s0p/infinitescrolling.js\"&gt;&lt;/script&gt;\n" + "  &lt;/head&gt;\n" + "  &lt;body&gt;\n" + "    ...\n" + "    &lt;div class=\"autopagerize_page_element\"&gt;\n" + "    {block:Posts}\n" + "      ...\n" + "    {/block:Posts}\n" + "    &lt;/div&gt;\n" + "    ...\n" + "  &lt;/body&gt;</code></pre><p>Afterwards simply save your theme and try it out. The infinite scrolling should now work (at least it did for me).</p><p>\n"
            + "  If this post helped you, you should spread the word for others.</p></p>\n" + "                                <div class=\"divider\"></div>\n" + "                                <ul class=\"tags\">\n" + "                                    <a href=\"#\" onclick=\"return false;\"><li>custom theme</li></a>\n" + "                                    <a href=\"#\" onclick=\"return false;\"><li>infinite scroll</li></a>\n" + "                                    <a href=\"#\" onclick=\"return false;\"><li>developer</li></a>\n" + "                                    <a href=\"#\" onclick=\"return false;\"><li>tumblr</li></a>\n"
            + "                                    <a href=\"#\" onclick=\"return false;\"><li>theme</li></a>\n" + "                                    <a href=\"#\" onclick=\"return false;\"><li>custom</li></a>\n" + "                                    <a href=\"#\" onclick=\"return false;\"><li>scroll</li></a>\n" + "                                    <a href=\"#\" onclick=\"return false;\"><li>help</li></a>\n" + "                                </ul>\n" + "                            </div>\n" + "                            <div class=\"card-action\">\n"
            + "                                <!-- To stretch the bottom of the card... posts without notes were ugly :/ -->\n" + "                                <a class=\"{11}-text\"> </a>\n" + "                                <div class=\"tumblr-btn-class\"><div class=\"like_button\" data-post-id=\"145504460740\" data-blog-name=\"hellowprl\" id=\"like_button_145504460740\"><a href=\"#\" onclick=\"return false;\"><i class=\"material-icons\">&#xE87D;</i></a></div></div>\n" + "                                <div class=\"tumblr-btn-class\"><a href=\"#\" class=\"reblog_button\" style=\"display: block;width:20px;height:20px;\" onclick=\"return false;\"><i class=\"material-icons\">&#xE040;</i></a></div>\n"
            + "                            </div>\n" + "                        </div>\n" + "\n" + "                        <div class=\"card {11} hoverable\">\n" + "                            <div class=\"card-image hoverable\">\n" + "                                <a href=\"#\" onclick=\"return false;\">\n" + "                                    <img src=\"http://65.media.tumblr.com/tumblr_md4w7bOQs41qz8q0ho1_r1_500h.jpg\" alt=\"staff:\n" + "&ldquo; This is HUGE!\n" + "Panoramas just got a big new view on Tumblr. Try it on your blog, the Dashboard, and the latest iPhone/iPad app too!\n" + "This works automatically for super-wide (3:1) high-res (1000px wide) photo uploads. And theme developers can...\">\n" + "                                    <span class=\"card-title white-text\">This is HUGE!</span>\n" + "                                </a>\n"
            + "                            </div>\n" + "                            <div class=\"card-content white-text\">\n" + "                                <p><p><a class=\"tumblr_blog\" href=\"#\" onclick=\"return false;\">staff</a>:</p>\n" + "<blockquote>\n" + "<p><strong>This is HUGE!</strong></p>\n" + "<p>Panoramas just got a <em>big new view</em> on Tumblr. Try it on your blog, the Dashboard, and the latest <a href=\"#\" onclick=\"return false;\">iPhone/iPad</a> app too!</p>\n"
            + "<p>This works automatically for super-wide (<code>3:1</code>) high-res (<code>1000px wide</code>) photo uploads. And theme developers can now style panoramas in Tumblr themes with the <code><a href=\"#\" onclick=\"return false;\">{block:Panorama}</a></code> tag.</p>\n" + "<p><em>Panorama by <a href=\"#\" onclick=\"return false;\">Blaine Davis</a></em></p>\n" + "</blockquote></p>\n" + "                                <br><span class=\"reblog\">Reblogged from <a href=\"#\" onclick=\"return false;\">staff</a></span>\n"
            + "                            </div>\n" + "                            <div class=\"card-action\">\n" + "                                <a href=\"#\" onclick=\"return false;\">15,963 notes</a>\n" + "                                <!-- To stretch the bottom of the card... posts without notes were ugly :/ -->\n" + "                                <a class=\"{11}-text\"> </a>\n" + "                                <div class=\"tumblr-btn-class\"><div class=\"like_button\" data-post-id=\"145504460740\" data-blog-name=\"hellowprl\" id=\"like_button_145504460740\"><a href=\"#\" onclick=\"return false;\"><i class=\"material-icons\">&#xE87D;</i></a></div></div>\n"
            + "                                <div class=\"tumblr-btn-class\"><a href=\"#\" class=\"reblog_button\" style=\"display: block;width:20px;height:20px;\" onclick=\"return false;\"><i class=\"material-icons\">&#xE040;</i></a></div>\n" + "                            </div>\n" + "                        </div>\n" + "\n" + "                        <div class=\"card {11} hoverable\">\n" + "                            <div class=\"card-content white-text\">\n"
            + "                                <span class=\"reblog\">Reblogged from <a href=\"#\" onclick=\"return false;\">kaurou</a></span><br><br>\n" + "                                <div class=\"photo-post-img-wrapper center\">\n" + "                                    <a href=\"#\" onclick=\"return false;\"><img src=\"http://66.media.tumblr.com/cc3055fef550cf2019566ba5c65bb69f/tumblr_o7gf1yHJng1uu2lqeo1_1280.jpg\" alt=\"\" class=\"photo-post-img hoverable\"></a>\n"
            + "                                </div><br>\n" + "                            </div>\n" + "                            <div class=\"card-action\">\n" + "                                <a href=\"#\" onclick=\"return false;\">13 notes</a>\n" + "                                <!-- To stretch the bottom of the card... posts without notes were ugly :/ -->\n" + "                                <a class=\"{11}-text\"> </a>\n" + "                                <div class=\"tumblr-btn-class\"><div class=\"like_button\" data-post-id=\"145504460740\" data-blog-name=\"hellowprl\" id=\"like_button_145504460740\"><a href=\"#\" onclick=\"return false;\"><i class=\"material-icons\">&#xE87D;</i></a></div></div>\n"
            + "                                <div class=\"tumblr-btn-class\"><a href=\"#\" class=\"reblog_button\" style=\"display: block;width:20px;height:20px;\" onclick=\"return false;\"><i class=\"material-icons\">&#xE040;</i></a></div>\n" + "                            </div>\n" + "                        </div>\n" + "\n" + "                        <div class=\"card {11} hoverable\">\n" + "                            <div class=\"card-content white-text\">\n"
            + "                                <span class=\"reblog\">Reblogged from <a href=\"#\" onclick=\"return false;\">horridtown</a></span><br><br>\n" + "                                <div class=\"photo-post-img-wrapper center\">\n" + "                                    <a href=\"#\" onclick=\"return false;\"><img src=\"http://67.media.tumblr.com/ca62371c7bc17357c5d8db1c177b6f6c/tumblr_o7xfk8tDjI1v5nypxo1_1280.png\" alt=\"horridtown:\n" + "&ldquo; my first pano of potato!\n"
            + "andprobablymylastughhsohard\n" + "&rdquo;\" class=\"photo-post-img hoverable\"></a>\n" + "                                </div><br>\n" + "                                <p><p><a class=\"tumblr_blog\" href=\"#\" onclick=\"return false;\">horridtown</a>:</p>\n" + "<blockquote>\n" + "<p>my first pano of potato!<br><strike>andprobablymylastughhsohard</strike></p>\n" + "</blockquote></p>\n" + "                            </div>\n" + "                            <div class=\"card-action\">\n"
            + "                                <a href=\"#\" onclick=\"return false;\">193 notes</a>\n" + "                                <!-- To stretch the bottom of the card... posts without notes were ugly :/ -->\n" + "                                <a class=\"{11}-text\"> </a>\n" + "                                <div class=\"tumblr-btn-class\"><div class=\"like_button\" data-post-id=\"145504460740\" data-blog-name=\"hellowprl\" id=\"like_button_145504460740\"><a href=\"#\" onclick=\"return false;\"><i class=\"material-icons\">&#xE87D;</i></a></div></div>\n"
            + "                                <div class=\"tumblr-btn-class\"><a href=\"#\" class=\"reblog_button\" style=\"display: block;width:20px;height:20px;\" onclick=\"return false;\"><i class=\"material-icons\">&#xE040;</i></a></div>\n" + "                            </div>\n" + "                        </div>\n" + "\n" + "                        <div class=\"card {11} hoverable\">\n" + "                            <div class=\"card-content white-text\">\n"
            + "                                <span class=\"reblog\">Reblogged from <a href=\"#\" onclick=\"return false;\">photorator</a></span><br><br>\n" + "                                <div class=\"photo-post-img-wrapper center\">\n" + "                                    <a href=\"#\" onclick=\"return false;\"><img src=\"http://67.media.tumblr.com/a3c5b12b9d504599696937cd31f66a8e/tumblr_o8azoqmSKe1s1qnw8o1_1280.jpg\" alt=\"photorator:\n" + "&ldquo; Denali Panorama\n"
            + "&rdquo;\" class=\"photo-post-img hoverable\"></a>\n" + "                                </div><br>\n" + "                                <p><p><a class=\"tumblr_blog\" href=\"#\" onclick=\"return false;\">photorator</a>:</p>\n" + "<blockquote>\n" + "<p>Denali Panorama</p>\n" + "</blockquote></p>\n" + "                            </div>\n" + "                            <div class=\"card-action\">\n" + "                                <a href=\"#\" onclick=\"return false;\">9 notes</a>\n"
            + "                                <!-- To stretch the bottom of the card... posts without notes were ugly :/ -->\n" + "                                <a class=\"{11}-text\"> </a>\n" + "                                <div class=\"tumblr-btn-class\"><div class=\"like_button\" data-post-id=\"145504460740\" data-blog-name=\"hellowprl\" id=\"like_button_145504460740\"><a href=\"#\" onclick=\"return false;\"><i class=\"material-icons\">&#xE87D;</i></a></div></div>\n" + "                                <div class=\"tumblr-btn-class\"><a href=\"#\" class=\"reblog_button\" style=\"display: block;width:20px;height:20px;\" onclick=\"return false;\"><i class=\"material-icons\">&#xE040;</i></a></div>\n"
            + "                            </div>\n" + "                        </div>\n" + "\n" + "                        <div class=\"card {11} hoverable\">\n" + "                            <div class=\"card-content white-text\">\n" + "                                <span class=\"reblog\">Reblogged from <a href=\"#\" onclick=\"return false;\">smartadze</a></span><br><br>\n" + "                                <div class=\"photo-post-set-img-wrapper center\">\n"
            + "                                    <img src=\"http://67.media.tumblr.com/234480d433d81c26d44b685def2a4b51/tumblr_o84oeguxa31rnxqgho1_1280.jpg\" alt=\"smartadze:\n" + "&ldquo; Mirages\n" + "&rdquo;\" class=\"photo-post-img hoverable\">\n" + "                                </div><br><div class=\"photo-post-set-img-wrapper center\">\n" + "                                    <img src=\"http://67.media.tumblr.com/ae6aecac8ad2722756c58b60bbcb1c55/tumblr_o84oeguxa31rnxqgho2_1280.jpg\" alt=\"smartadze:\n"
            + "&ldquo; Mirages\n" + "&rdquo;\" class=\"photo-post-img hoverable\">\n" + "                                </div><br>\n" + "                                <p><p><a class=\"tumblr_blog\" href=\"#\" onclick=\"return false;\">smartadze</a>:</p>\n" + "<blockquote>\n" + "<p>Mirages</p>\n" + "</blockquote></p>\n" + "                            </div>\n" + "                            <div class=\"card-action\">\n" + "                                <a href=\"#\" onclick=\"return false;\">18 notes</a>\n"
            + "                                <!-- To stretch the bottom of the card... posts without notes were ugly :/ -->\n" + "                                <a class=\"{11}-text\"> </a>\n" + "                                <div class=\"tumblr-btn-class\"><div class=\"like_button\" data-post-id=\"145504460740\" data-blog-name=\"hellowprl\" id=\"like_button_145504460740\"><a href=\"#\" onclick=\"return false;\"><i class=\"material-icons\">&#xE87D;</i></a></div></div>\n" + "                                <div class=\"tumblr-btn-class\"><a href=\"#\" class=\"reblog_button\" style=\"display: block;width:20px;height:20px;\" onclick=\"return false;\"><i class=\"material-icons\">&#xE040;</i></a></div>\n"
            + "                            </div>\n" + "                        </div>\n" + "\n" + "                        <div class=\"card {11} hoverable\">\n" + "                            <div class=\"card-content white-text\">\n" + "                                <p>\n" + "                                    <a href=\"#\" onclick=\"return false;\" class=\"link-post-anchor\">links | Tumblr</a> -- tumblr.com\n" + "                                    <br><br><p>This is the page that shows up, when you search for&nbsp;&ldquo;links&rdquo; on tumblr</p>\n"
            + "                                </p>\n" + "                                <div class=\"divider\"></div>\n" + "                                <ul class=\"tags\">\n" + "                                    <a href=\"#\" onclick=\"return false;\"><li>still testing theme</li></a>\n" + "                                    <a href=\"#\" onclick=\"return false;\"><li>lol</li></a>\n" + "                                    <a href=\"#\" onclick=\"return false;\"><li>dev live</li></a>\n" + "                                    <a href=\"#\" onclick=\"return false;\"><li>its 11pm</li></a>\n"
            + "                                    <a href=\"#\" onclick=\"return false;\"><li>toooo late</li></a>\n" + "                                    <a href=\"#\" onclick=\"return false;\"><li>gonna need coffee tomorrow</li></a>\n" + "                                    <a href=\"#\" onclick=\"return false;\"><li>or why not now?</li></a>\n" + "                                </ul>\n" + "                            </div>\n" + "                            <div class=\"card-action\">\n"
            + "                                <!-- To stretch the bottom of the card... posts without notes were ugly :/ -->\n" + "                                <a class=\"{11}-text\"> </a>\n" + "                                <div class=\"tumblr-btn-class\"><div class=\"like_button\" data-post-id=\"145504460740\" data-blog-name=\"hellowprl\" id=\"like_button_145504460740\"><a href=\"#\" onclick=\"return false;\"><i class=\"material-icons\">&#xE87D;</i></a></div></div>\n" + "                                <div class=\"tumblr-btn-class\"><a href=\"#\" class=\"reblog_button\" style=\"display: block;width:20px;height:20px;\" onclick=\"return false;\"><i class=\"material-icons\">&#xE040;</i></a></div>\n"
            + "                            </div>\n" + "                        </div>\n" + "\n" + "                        <div class=\"card {11} hoverable\">\n" + "                            <div class=\"card-content white-text\">\n" + "                                <span class=\"card-title\">Reason #3 why I should be asleep</span>\n" + "                                <ul>\n" + "                                    <li><span class=\"chat-name\">Oikawa:</span>: *poses for his fan girls*</li>\n"
            + "                                    <li><span class=\"chat-name\">Iwaizumi:</span>: *watches with an irk mark*</li>\n" + "                                    <li><span class=\"chat-name\">Matsu:</span>: You like him don&#039;t you?</li>\n" + "                                    <li><span class=\"chat-name\">Iwaizumi:</span>: I&#039;d like to hit him with a car. </li>\n" + "                                    <li><span class=\"chat-name\">Matsu and Maki:</span>: oh.</li>\n"
            + "                                </ul>\n" + "                                <span class=\"reblog\">Reblogged from <a href=\"#\" onclick=\"return false;\">anime-thoughts-imagines-more</a></span>\n" + "                            </div>\n" + "                            <div class=\"card-action\">\n" + "                                <a href=\"#\" onclick=\"return false;\">15 notes</a>\n" + "                                <!-- To stretch the bottom of the card... posts without notes were ugly :/ -->\n"
            + "                                <a class=\"{11}-text\"> </a>\n" + "                                <div class=\"tumblr-btn-class\"><div class=\"like_button\" data-post-id=\"145504460740\" data-blog-name=\"hellowprl\" id=\"like_button_145504460740\"><a href=\"#\" onclick=\"return false;\"><i class=\"material-icons\">&#xE87D;</i></a></div></div>\n" + "                                <div class=\"tumblr-btn-class\"><a href=\"#\" class=\"reblog_button\" style=\"display: block;width:20px;height:20px;\" onclick=\"return false;\"><i class=\"material-icons\">&#xE040;</i></a></div>\n"
            + "                            </div>\n" + "                        </div>\n" + "                        {16}\n" + "                    </div>\n" + "                </div>\n" + "                <footer class=\"page-footer {11}\" id=\"footer\">\n" + "                    <div class=\"container\">\n" + "                        {17}\n" + "                        {18}\n" + "                    </div>\n" + "                    <div class=\"footer-copyright\">\n" + "                        <div class=\"container\">\n"
            + "                            &copy; 2016 Jean-Pierre Hotz\n" + "                            <a class=\"grey-text text-lighten-4 right\" target=\"_blank\" href=\"#\" onclick=\"return false;\">Powered by tumblr.</a>\n" + "                        </div>\n" + "                    </div>\n" + "                </footer>\n" + "            </div>\n" + "        </div>\n" + "        <script type=\"text/javascript\" src=\"https://code.jquery.com/jquery-2.1.1.min.js\"></script>\n"
            + "        <script src=\"https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.6/js/materialize.min.js\"></script>\n" + "        <script type=\"text/javascript\">\n" + "(function($){\n" + "  $(function(){\n" + "    $('.button-collapse').sideNav();\n" + "  });\n" + "})(jQuery);\n" + "        </script>\n" + "        {19}\n" + "    </body>\n" + "</html>";

    private String          mTitle;
    private String          mDescription;
    private String          mHeaderImage;
    private String          mAvatarImage;
    private ImageShape      mAvatarShape;
    private String          mTitleFont;
    private boolean         mTitleBold;
    private int             mBackgroundColor;
    private boolean         mShowHeaderImage;
    private boolean         mShowAvatar;
    private boolean         mShowTitle;
    private boolean         mShowDescription;
    private int             mFirstStripeColor;
    private int             mSecondStripeColor;
    private int             mAvatarBorderColor;
    private MaterialColor   mThemeColor;
    private boolean         mSlidingHeader;
    private boolean         mBackgroundAsStripes;
    private boolean         mShowQuotes;
    private String          mQuotesJavaScriptCode;
    private boolean         mInfiniteScrolling;
    private String          mCustomCSS;
    private boolean         mPayRespectToMyWork;


    public HTMLPreviewGenerator(SharedPreferences settingsPreferences){
        mTitle                  = settingsPreferences.getString(                    PreferenceIDs.TITLE,                Defaultvalues.sTitle);
        mDescription            = settingsPreferences.getString(                    PreferenceIDs.DESCRIPTION,          Defaultvalues.sDescription);
        mHeaderImage            = settingsPreferences.getString(                    PreferenceIDs.HEADER_IMG,           Defaultvalues.sHeaderImage);
        mAvatarImage            = settingsPreferences.getString(                    PreferenceIDs.AVATAR_IMG,           Defaultvalues.sAvatarImage);
        mAvatarShape            = ImageShape.fromInt(settingsPreferences.getInt(    PreferenceIDs.AVATAR_SHAPE,         Defaultvalues.sAvatarShape.toInt()));
        mTitleFont              = settingsPreferences.getString(                    PreferenceIDs.TITLEFONT,            Defaultvalues.sTitleFont);
        mTitleBold              = settingsPreferences.getBoolean(                   PreferenceIDs.TITLEBOLD,            Defaultvalues.sTitleBold);
        mBackgroundColor        = settingsPreferences.getInt(                       PreferenceIDs.BACKGROUND_COLOR,     Defaultvalues.sBackgroundColor);
        mShowHeaderImage        = settingsPreferences.getBoolean(                   PreferenceIDs.SHOW_HEADER_IMG,      Defaultvalues.sShowHeaderImage);
        mShowAvatar             = settingsPreferences.getBoolean(                   PreferenceIDs.SHOW_AVATAR_IMG,      Defaultvalues.sShowAvatar);
        mShowTitle              = settingsPreferences.getBoolean(                   PreferenceIDs.SHOW_TITLE,           Defaultvalues.sShowTitle);
        mShowDescription        = settingsPreferences.getBoolean(                   PreferenceIDs.SHOW_DESCRIPTION,     Defaultvalues.sShowDescription);
        mFirstStripeColor       = settingsPreferences.getInt(                       PreferenceIDs.FIRST_STRIPE_COLOR,   Defaultvalues.sFirstStripeColor);
        mSecondStripeColor      = settingsPreferences.getInt(                       PreferenceIDs.SECOND_STRIPE_COLOR,  Defaultvalues.sSecondStripeColor);
        mAvatarBorderColor      = settingsPreferences.getInt(                       PreferenceIDs.AVATAR_BORDER_COLOR,  Defaultvalues.sAvatarBorderColor);
        mThemeColor             = MaterialColor.fromInt(settingsPreferences.getInt( PreferenceIDs.THEMECOLOR,           Defaultvalues.sThemeColor.toInt()));
        mSlidingHeader          = settingsPreferences.getBoolean(                   PreferenceIDs.SLIDING_HEADER,       Defaultvalues.sSlidingHeader);
        mBackgroundAsStripes    = settingsPreferences.getBoolean(                   PreferenceIDs.BACKGROUND_STRIPES,   Defaultvalues.sBackgroundAsStripes);
        mShowQuotes             = settingsPreferences.getBoolean(                   PreferenceIDs.SHOW_QUOTES,          Defaultvalues.sShowQuotes);
        mQuotesJavaScriptCode   = settingsPreferences.getString(                    PreferenceIDs.QUOTESJAVASCRIPTCODE, Defaultvalues.sQuotesJavaScriptCode);
        mInfiniteScrolling      = settingsPreferences.getBoolean(                   PreferenceIDs.INFINITESCROLLING,    Defaultvalues.sInfiniteScrolling);
        mCustomCSS              = settingsPreferences.getString(                    PreferenceIDs.CUSTOMCSS,            Defaultvalues.sCustomCSS);
        mPayRespectToMyWork     = settingsPreferences.getBoolean(                   PreferenceIDs.PAYRESPECTTOMYWORK,   Defaultvalues.sPayRespectToMyWork);
    }

    public SharedPreferences.Editor save(SharedPreferences prefs){
        return prefs.edit()
                .putString(     PreferenceIDs.TITLE,                    mTitle)
                .putString(     PreferenceIDs.DESCRIPTION,              mDescription)
                .putString(     PreferenceIDs.HEADER_IMG,               mHeaderImage)
                .putString(     PreferenceIDs.AVATAR_IMG,               mAvatarImage)
                .putInt(        PreferenceIDs.AVATAR_SHAPE,             mAvatarShape.toInt())
                .putString(     PreferenceIDs.TITLEFONT,                mTitleFont)
                .putBoolean(    PreferenceIDs.TITLEBOLD,                mTitleBold)
                .putInt(        PreferenceIDs.BACKGROUND_COLOR,         mBackgroundColor)
                .putBoolean(    PreferenceIDs.SHOW_HEADER_IMG,          mShowHeaderImage)
                .putBoolean(    PreferenceIDs.SHOW_AVATAR_IMG,          mShowAvatar)
                .putBoolean(    PreferenceIDs.SHOW_TITLE,               mShowTitle)
                .putBoolean(    PreferenceIDs.SHOW_DESCRIPTION,         mShowDescription)
                .putInt(        PreferenceIDs.FIRST_STRIPE_COLOR,       mFirstStripeColor)
                .putInt(        PreferenceIDs.SECOND_STRIPE_COLOR,      mSecondStripeColor)
                .putInt(        PreferenceIDs.AVATAR_BORDER_COLOR,      mAvatarBorderColor)
                .putInt(        PreferenceIDs.THEMECOLOR,               mThemeColor.toInt())
                .putBoolean(    PreferenceIDs.SLIDING_HEADER,           mSlidingHeader)
                .putBoolean(    PreferenceIDs.BACKGROUND_STRIPES,       mBackgroundAsStripes)
                .putBoolean(    PreferenceIDs.SHOW_QUOTES,              mShowQuotes)
                .putString(     PreferenceIDs.QUOTESJAVASCRIPTCODE,     mQuotesJavaScriptCode)
                .putBoolean(    PreferenceIDs.INFINITESCROLLING,        mInfiniteScrolling)
                .putString(     PreferenceIDs.CUSTOMCSS,                mCustomCSS)
                .putBoolean(    PreferenceIDs.PAYRESPECTTOMYWORK,       mPayRespectToMyWork);
    }

    public String generate(){
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

18 - <div class="row">
        <div class="col l5 s12">
            <h5 class="white-text">Theme by Jean-Pierre Hotz</h5>
            <p class="grey-text text-lighten-4">You can use this theme if you like.<br>It'll just cost you the effort of copy & pasting it :P</p>
        </div>
        <div class="col l6 offset-l1 s12">
            <h5 class="white-text">Thanks to:</h5>
            <ul>
                <li><a class="grey-text footer-thanks-item text-lighten-3" target="_blank" href="#" onclick="return false;">Tumblr. for giving me inspiration and room to be creative</a></li>
                <li><a class="grey-text footer-thanks-item text-lighten-3" target="_blank" href="#" onclick="return false;">Myself for being so patient with the infinite scrolling feature.</a></li>
                <li><a class="grey-text footer-thanks-item text-lighten-3" target="_blank" href="#" onclick="return false;">Materialize CSS (Framework used in this Theme)</a></li>
            </ul>
        </div>
    </div>
    <div class="row">
        <a href="#" onclick="alert('Error 404 - Gaming PC not found.'); return false;"><img class="socialmedia-icon" src="http://static.tumblr.com/642aqpc/Wu7ob8uuz/steam.png"/></a>
        <a href="#" onclick="alert('I\'m not going to publish my phone number, although you may request it personally ;)'); return false"><img class="socialmedia-icon" src="http://static.tumblr.com/642aqpc/Pu5ob8uvq/whatsapp.png"/></a>
        <a href="#" onclick="alert('Sorry, but I really dislike Facebook.'); return false;"><img class="socialmedia-icon" src="http://static.tumblr.com/642aqpc/qcBob8ut4/facebook.png"/></a>
        <a href="https://plus.google.com/u/0/114813713589155713629/posts" target="_blank"><img class="socialmedia-icon" src="http://static.tumblr.com/642aqpc/Okpob90n3/go_ogle-plus_icon.png"/></a>
        <a href="https://www.twitch.tv/sirjonny1998/profile" target="_blank"><img class="socialmedia-icon" src="http://static.tumblr.com/642aqpc/Qqiob8uva/twitch.png"/></a>
        <a href="https://twitter.com/HotzJean" target="_blank"><img class="socialmedia-icon" src="http://static.tumblr.com/642aqpc/rJ3ob8uve/twitter.png"/></a>
        <a href="https://www.instagram.com/jonny9298/" target="_blank"><img class="socialmedia-icon" src="http://static.tumblr.com/642aqpc/6Fcob8uuh/instagram.png"/></a>
        <a href="http://stackoverflow.com/users/6665105/jonny9298" target="_blank"><img class="socialmedia-icon" src="http://static.tumblr.com/642aqpc/9Phob8uut/stackoverflow.png"/></a>
        <a href="https://github.com/JP1998" target="_blank"><img class="socialmedia-icon" src="http://static.tumblr.com/642aqpc/wXMob8uu5/github.png"/></a>
        <a href="http://bitchyprincefun.tumblr.com/" target="_blank"><img class="socialmedia-icon" src="http://static.tumblr.com/642aqpc/tKzob90m3/tum_blr_icon.png"/></a>
    </div>

19 - {{block:IfShowQuotes}}<script type="text/javascript">
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

        String quotes = (mShowQuotes) ? "<script type=\"text/javascript\">\nvar current_quote_index = 0;\nvar quotes = [\n\t" + mQuotesJavaScriptCode + "\n];\n\t\t</script>\n\t\t": "";
        String infinitescrolling = (mInfiniteScrolling) ? "<script type=\"text/javascript\" src=\"http://static.tumblr.com/q0etgkr/EIBmz7s0p/infinitescrolling.js\"></script>\n\t\t": "";
        String banner = (mShowHeaderImage) ? "background-image: url(" + mHeaderImage + ");\n\tbackground-repeat: no-repeat;\n\tbackground-size: cover;\n\tbackground-position: center;\n\tbackground-attachment: " + ((mSlidingHeader)? "fixed":"scroll") + ";" : "";
        String stripesbackground = (mBackgroundAsStripes) ? "background: repeating-linear-gradient(45deg, " + colorToHex(mFirstStripeColor) + ", " + colorToHex(mFirstStripeColor) + " 30px, " + colorToHex(mSecondStripeColor) + " 30px, " + colorToHex(mSecondStripeColor) + " 60px);" : "background-color: " + colorToHex(mBackgroundColor) + ";";
        String titlebold = (mTitleBold) ? "bold" : "normal";
        String avatarwrappercss = (mShowTitle) ? "margin-bottom: -65px;" : "";
        String avatar = (mShowAvatar) ? "<div class=\"row center avatar-wrapper\">\n\t\t\t\t\t<a href=\"#\"><img src=\"" + mAvatarImage + "\" class=\"" + mAvatarShape.toString() + " avatar hoverable\"></a>\n\t\t\t\t</div>\n\t\t\t\t" : "";
        String title = (mShowTitle) ? "<a href=\"#\"><h1 class=\"title header center " + mThemeColor.toString() + "-text\">" + mTitle + "</h1></a>\n\t\t\t\t" : "";
        String description = (mShowDescription) ? "<div class=\"row center\">\n\t\t\t\t\t\t\t<h5 class=\"header col s12 light\">" + mDescription + "</h5>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t\t" : "";
        String quotescontainer = (mShowQuotes) ? "<div class=\"container\">\n\t\t\t\t\t<div class=\"row center\">\n\t\t\t\t\t\t<div class=\"card " + mThemeColor.toString() + " hoverable\">\n\t\t\t\t\t\t\t<div class=\"card-content white-text\">\n\t\t\t\t\t\t\t\t<span class=\"card-title\" id=\"quote-caption\">Quote of the week</span>\n\t\t\t\t\t\t\t\t<p id=\"quote-text\"></p>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t<div class=\"card-action\">\n\t\t\t\t\t\t\t\t<a href=\"#\" onclick=\"setRandomQuote(); return false;\">Get a new quote</a>\n\t\t\t\t\t\t\t\t<a href=\"#\" onclick=\"setNextQuote(); return false;\">Get the next quote</a>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t</div>\n\t\t\t\t</div>" : "<div style=\"height: 15px; \"></div>\n\t\t\t\t";
        String pagination = (!mInfiniteScrolling) ? "<div class=\"card " + mThemeColor.toString() + " hoverable\">\n\t\t\t\t\t\t\t<div class=\"card-content\">\n\t\t\t\t\t\t\t\t<br/>\n\t\t\t\t\t\t\t\t<div class=\"row center\">\n\t\t\t\t\t\t\t\t<a href=\"#\" onclick=\"return false;\" class=\"btn waves-effect waves-light " + mThemeColor.toString() + "\">1 / 2</a>\n\t\t\t\t\t\t\t\t<a href=\"#\" onclick=\"return false;\" id=\"next-page-button\" class=\"btn waves-effect waves-light not-disabled " + mThemeColor.toString() + "\">&gt;&gt;</a>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t</div>" : "";
        String endcaption = (mInfiniteScrolling) ? "<div class=\"row center\">\n\t\t\t\t\t\t\t<h3 class=\"grey-text text-lighten-4\">This seems to be it with this blog.</h3>\n\t\t\t\t\t\t</div>" : "";
        String respectingfooter = (mPayRespectToMyWork) ? "<div class=\"row\">\n\t\t\t\t\t\t\t<div class=\"col l5 s12\">\n\t\t\t\t\t\t\t\t<h5 class=\"white-text\">Theme by Jean-Pierre Hotz</h5>\n\t\t\t\t\t\t\t\t<p class=\"grey-text text-lighten-4\">You can use this theme if you like.<br>It'll just cost you the effort of copy & pasting it :P</p>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t<div class=\"col l6 offset-l1 s12\">\n\t\t\t\t\t\t\t\t<h5 class=\"white-text\">Thanks to:</h5>\n\t\t\t\t\t\t\t\t<ul>\n\t\t\t\t\t\t\t\t\t<li><a class=\"grey-text footer-thanks-item text-lighten-3\" target=\"_blank\" href=\"#\" onclick=\"return false;\">Tumblr. for giving me inspiration and room to be creative</a></li>\n\t\t\t\t\t\t\t\t\t<li><a class=\"grey-text footer-thanks-item text-lighten-3\" target=\"_blank\" href=\"#\" onclick=\"return false;\">Myself for being so patient with the infinite scrolling feature.</a></li>\n\t\t\t\t\t\t\t\t\t<li><a class=\"grey-text footer-thanks-item text-lighten-3\" target=\"_blank\" href=\"#\" onclick=\"return false;\">Materialize CSS (Framework used in this Theme)</a></li>\n\t\t\t\t\t\t\t\t</ul>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t\t<div class=\"row\">\n\t\t\t\t\t\t<a href=\"#\" onclick=\"alert('Error 404 - Gaming PC not found.'); return false;\"><img class=\"socialmedia-icon\" src=\"http://static.tumblr.com/642aqpc/Wu7ob8uuz/steam.png\"/></a>\n\t\t\t\t\t\t<a href=\"#\" onclick=\"alert('I\\'m not going to publish my phone number, although you may request it personally ;)'); return false\"><img class=\"socialmedia-icon\" src=\"http://static.tumblr.com/642aqpc/Pu5ob8uvq/whatsapp.png\"/></a>\n\t\t\t\t\t\t<a href=\"#\" onclick=\"alert('Sorry, but I really dislike Facebook.'); return false;\"><img class=\"socialmedia-icon\" src=\"http://static.tumblr.com/642aqpc/qcBob8ut4/facebook.png\"/></a>\n\t\t\t\t\t\t<a href=\"#\" onclick=\"return false;\" target=\"_blank\"><img class=\"socialmedia-icon\" src=\"http://static.tumblr.com/642aqpc/Okpob90n3/go_ogle-plus_icon.png\"/></a>\n\t\t\t\t\t\t<a href=\"#\" onclick=\"return false;\" target=\"_blank\"><img class=\"socialmedia-icon\" src=\"http://static.tumblr.com/642aqpc/Qqiob8uva/twitch.png\"/></a>\n\t\t\t\t\t\t<a href=\"#\" onclick=\"return false;\" target=\"_blank\"><img class=\"socialmedia-icon\" src=\"http://static.tumblr.com/642aqpc/rJ3ob8uve/twitter.png\"/></a>\n\t\t\t\t\t\t<a href=\"#\" onclick=\"return false;\" target=\"_blank\"><img class=\"socialmedia-icon\" src=\"http://static.tumblr.com/642aqpc/6Fcob8uuh/instagram.png\"/></a>\n\t\t\t\t\t\t<a href=\"#\" onclick=\"return false;\" target=\"_blank\"><img class=\"socialmedia-icon\" src=\"http://static.tumblr.com/642aqpc/9Phob8uut/stackoverflow.png\"/></a>\n\t\t\t\t\t\t<a href=\"#\" onclick=\"return false;\" target=\"_blank\"><img class=\"socialmedia-icon\" src=\"http://static.tumblr.com/642aqpc/wXMob8uu5/github.png\"/></a>\n\t\t\t\t\t\t<a href=\"#\" onclick=\"return false;\" target=\"_blank\"><img class=\"socialmedia-icon\" src=\"http://static.tumblr.com/642aqpc/tKzob90m3/tum_blr_icon.png\"/></a>\n\t\t\t\t\t</div>" : "";
        String showquotescode = (mShowQuotes) ? "<script type=\"text/javascript\">\nvar setWeeklyQuote = function(){\n\tif (quotes.length != 0){\n\t\tvar now = new Date();\n\t\tvar onejan = new Date(now.getFullYear(), 0, 1);\n\t\tvar week = Math.ceil((((now - onejan) / 86400000) + onejan.getDay() + 1) / 7);\n\t\t\n\t\tcurrent_quote_index = week % quotes.length;\n\t\tdocument.getElementById(\"quote-text\").innerHTML = quotes[current_quote_index];\n\t}\n};\n\nvar setRandomQuote = function(){\n\tif (quotes.length != 0){\n\t\tdocument.getElementById(\"quote-caption\").innerHTML = \"Quote\";\n\t\tcurrent_quote_index = Math.floor(Math.random() * quotes.length);\n\t\tdocument.getElementById(\"quote-text\").innerHTML = quotes[current_quote_index];\n\t}\n};\n\nvar setNextQuote = function(){\n\tif (quotes.length != 0){\n\t\tdocument.getElementById(\"quote-caption\").innerHTML = \"Quote\";\n\t\tcurrent_quote_index = (current_quote_index + 1) % quotes.length;\n\t\tdocument.getElementById(\"quote-text\").innerHTML = quotes[current_quote_index];\n\t}\n};\n\nsetWeeklyQuote();\n\t\t</script>" : "";

        return sThemeText
                .replace("{0}", mTitle)
                .replace("{1}", mAvatarImage)
                .replace("{2}", quotes)
                .replace("{3}", infinitescrolling)
                .replace("{4}", banner)
                .replace("{5}", stripesbackground)
                .replace("{6}", mTitleFont)
                .replace("{7}", titlebold)
                .replace("{8}", colorToHex(mAvatarBorderColor))
                .replace("{9}", avatarwrappercss)
                .replace("{10}", mCustomCSS)
                .replace("{11}", mThemeColor.toString())
                .replace("{12}", avatar)
                .replace("{13}", title)
                .replace("{14}", description)
                .replace("{15}", quotescontainer)
                .replace("{16}", pagination)
                .replace("{17}", endcaption)
                .replace("{18}", respectingfooter)
                .replace("{19}", showquotescode);
    }

    private String colorToHex(int col){
        // shorten the color to max 6 digits
        String val = Integer.toHexString(col & 0xFFFFFF);

        // and stretch it to min 6 digits
        // so it results in a html color string
        // ("#xxxxxx", where x is a hexadecimal digit representing the R- G- and B- channels of a color)
        while(val.length() < 6){
            val = "0" + val;
        }

        return "#" + val;
    }

    public String getTitle(){
        return mTitle;
    }
    public void setTitle(String title){
        mTitle = title;
    }
    public String getDescription(){
        return mDescription;
    }
    public void setDescription(String description){
        mDescription = description;
    }
    public String getHeaderImage(){
        return mHeaderImage;
    }
    public void setHeaderImage(String headerImage){
        mHeaderImage = headerImage;
    }
    public String getAvatarImage(){
        return mAvatarImage;
    }
    public void setAvatarImage(String avatarImage){
        mAvatarImage = avatarImage;
    }
    public ImageShape getAvatarShape(){
        return mAvatarShape;
    }
    public void setAvatarShape(ImageShape avatarShape){
        mAvatarShape = avatarShape;
    }
    public String getTitleFont(){
        return mTitleFont;
    }
    public void setTitleFont(String titleFont){
        mTitleFont = titleFont;
    }
    public boolean isTitleBold(){
        return mTitleBold;
    }
    public void setTitleBold(boolean titleBold){
        mTitleBold = titleBold;
    }
    public int getBackgroundColor(){
        return mBackgroundColor;
    }
    public void setBackgroundColor(int backgroundColor){
        mBackgroundColor = backgroundColor;
    }
    public boolean isShowHeaderImage(){
        return mShowHeaderImage;
    }
    public void setShowHeaderImage(boolean showHeaderImage){
        mShowHeaderImage = showHeaderImage;
    }
    public boolean isShowAvatar(){
        return mShowAvatar;
    }
    public void setShowAvatar(boolean showAvatar){
        mShowAvatar = showAvatar;
    }
    public boolean isShowTitle(){
        return mShowTitle;
    }
    public void setShowTitle(boolean showTitle){
        mShowTitle = showTitle;
    }
    public boolean isShowDescription(){
        return mShowDescription;
    }
    public void setShowDescription(boolean showDescription){
        mShowDescription = showDescription;
    }
    public int getFirstStripeColor(){
        return mFirstStripeColor;
    }
    public void setFirstStripeColor(int firstStripeColor){
        mFirstStripeColor = firstStripeColor;
    }
    public int getSecondStripeColor(){
        return mSecondStripeColor;
    }
    public void setSecondStripeColor(int secondStripeColor){
        mSecondStripeColor = secondStripeColor;
    }
    public int getAvatarBorderColor(){
        return mAvatarBorderColor;
    }
    public void setAvatarBorderColor(int avatarBorderColor){
        mAvatarBorderColor = avatarBorderColor;
    }
    public MaterialColor getThemeColor(){
        return mThemeColor;
    }
    public void setThemeColor(MaterialColor themeColor){
        mThemeColor = themeColor;
    }
    public boolean isSlidingHeader(){
        return mSlidingHeader;
    }
    public void setSlidingHeader(boolean slidingHeader){
        mSlidingHeader = slidingHeader;
    }
    public boolean isBackgroundAsStripes(){
        return mBackgroundAsStripes;
    }
    public void setBackgroundAsStripes(boolean backgroundAsStripes){
        mBackgroundAsStripes = backgroundAsStripes;
    }
    public boolean isShowQuotes(){
        return mShowQuotes;
    }
    public void setShowQuotes(boolean showQuotes){
        mShowQuotes = showQuotes;
    }
    public String getQuotesJavaScriptCode(){
        return mQuotesJavaScriptCode;
    }
    public void setQuotesJavaScriptCode(String quotesJavaScriptCode){
        mQuotesJavaScriptCode = quotesJavaScriptCode;
    }
    public boolean isInfiniteScrolling(){
        return mInfiniteScrolling;
    }
    public void setInfiniteScrolling(boolean infiniteScrolling){
        mInfiniteScrolling = infiniteScrolling;
    }
    public String getCustomCSS(){
        return mCustomCSS;
    }
    public void setCustomCSS(String customCSS){
        mCustomCSS = customCSS;
    }
    public boolean isPayRespectToMyWork(){
        return mPayRespectToMyWork;
    }
    public void setPayRespectToMyWork(boolean payRespectToMyWork){
        mPayRespectToMyWork = payRespectToMyWork;
    }


    public enum ImageShape{
        Rectangular,
        Circular;

        public int toInt(){
            switch(this){
                case Circular:      return 0x123;
                case Rectangular:   return 0x321;
                default:            return -1;
            }
        }

        public static ImageShape fromInt(int i){
            switch(i){
                case 0x123: return ImageShape.Circular;
                case 0x321: return ImageShape.Rectangular;
                default:    return ImageShape.Circular;
            }
        }

        @Override
        public String toString(){
            switch(this){
                case Circular:      return "circle";
                case Rectangular:   return "square";
                default:            return null;
            }
        }
    }

    public enum MaterialColor{
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
        Brown;

        public int toInt(){
            switch(this){
                case Red:           return 12;
                case Purple:        return 23;
                case Deep_Purple:   return 34;
                case Indigo_Blue:   return 45;
                case Blue:          return 56;
                case Light_Blue:    return 67;
                case Cyan:          return 78;
                case Teal:          return 89;
                case Green:         return 910;
                case Light_Green:   return 1011;
                case Lime:          return 1112;
                case Yellow:        return 1213;
                case Amber:         return 1314;
                case Orange:        return 1415;
                case Deep_Orange:   return 1516;
                case Brown:         return 1617;
                default:            return -1;
            }
        }

        public static MaterialColor fromInt(int i){
            switch(i){
                case 12:    return MaterialColor.Red;
                case 23:    return MaterialColor.Purple;
                case 34:    return MaterialColor.Deep_Purple;
                case 45:    return MaterialColor.Indigo_Blue;
                case 56:    return MaterialColor.Blue;
                case 67:    return MaterialColor.Light_Blue;
                case 78:    return MaterialColor.Cyan;
                case 89:    return MaterialColor.Teal;
                case 910:   return MaterialColor.Green;
                case 1011:  return MaterialColor.Light_Green;
                case 1112:  return MaterialColor.Lime;
                case 1213:  return MaterialColor.Yellow;
                case 1314:  return MaterialColor.Amber;
                case 1415:  return MaterialColor.Orange;
                case 1516:  return MaterialColor.Deep_Orange;
                case 1617:  return MaterialColor.Brown;
                default:    return MaterialColor.Brown;
            }
        }

        @Override
        public String toString(){
            switch(this){
                case Red:           return "red";
                case Purple:        return "purple";
                case Deep_Purple:   return "deep-purple";
                case Indigo_Blue:   return "indigo";
                case Blue:          return "blue";
                case Light_Blue:    return "light-blue";
                case Cyan:          return "cyan";
                case Teal:          return "teal";
                case Green:         return "green";
                case Light_Green:   return "light-green";
                case Lime:          return "lime";
                case Yellow:        return "yellow";
                case Amber:         return "amber";
                case Orange:        return "orange";
                case Deep_Orange:   return "deep-orange";
                case Brown:         return "brown";
                default:            return null;
            }
        }
    }

    private static class Defaultvalues{
        public static final String          sTitle                  = "Test Material Design Theme";
        public static final String          sDescription            = "Hello World, this is a quick description of me. I don't actually write anything reasonable here, but it's also just thought as a filler, so... :)";
        public static final String          sHeaderImage            = "http://static.tumblr.com/62567c4dbf482efd0f3598d8b1a5431a/642aqpc/YVjo8bckd/tumblr_static_40bqiokp5ta8sksog8c0o8kk0_2048_v2.jpg";
        public static final String          sAvatarImage            = "http://67.media.tumblr.com/avatar_ff17e3193309_128.png";
        public static final ImageShape      sAvatarShape            = ImageShape.Circular;
        public static final String          sTitleFont              = "'Typewriter FS', serif;";
        public static final boolean         sTitleBold              = true;
        public static final int             sBackgroundColor        = Color.argb(0xFF, 0xCE, 0x0E, 0x0E);
        public static final boolean         sShowHeaderImage        = true;
        public static final boolean         sShowAvatar             = true;
        public static final boolean         sShowTitle              = true;
        public static final boolean         sShowDescription        = true;
        public static final int             sFirstStripeColor       = Color.argb(0xFF, 0xFF, 0x00, 0x11);
        public static final int             sSecondStripeColor      = Color.argb(0xFF, 0x80, 0xFF, 0x00);
        public static final int             sAvatarBorderColor      = Color.argb(0xFF, 0x64, 0x4B, 0x74);
        public static final MaterialColor   sThemeColor             = MaterialColor.Brown;
        public static final boolean         sSlidingHeader          = true;
        public static final boolean         sBackgroundAsStripes    = true;
        public static final boolean         sShowQuotes             = true;
        public static final String          sQuotesJavaScriptCode   = "Look into the footer of the theme for an explanation!";
        public static final boolean         sInfiniteScrolling      = true;
        public static final String          sCustomCSS              = "";
        public static final boolean         sPayRespectToMyWork     = true;
    }

    private static class PreferenceIDs{
        public static final String TITLE                    = "Title of your testblog ^^";
        public static final String DESCRIPTION              = "Description of your testblog ^^";
        public static final String HEADER_IMG               = "The path to the header-image of your testblog ^^";
        public static final String AVATAR_IMG               = "The path to the avatar-image of your testblog ^^";
        public static final String AVATAR_SHAPE             = "The shape of the avatar-image of your testblog ^^";
        public static final String BACKGROUND_COLOR         = "The background-color of the non-browser version of your testblog ^^";
        public static final String SHOW_HEADER_IMG          = "Whether the header-image is supposed to be shown on your testblog ^^";
        public static final String SHOW_AVATAR_IMG          = "Whether the avatar-image is supposed to be shown on your testblog ^^";
        public static final String SHOW_TITLE               = "Whether the title of your testblog is supposed to be shown ^^";
        public static final String SHOW_DESCRIPTION         = "Whether the description of your testblog is supposed to be shown ^^";
        public static final String FIRST_STRIPE_COLOR       = "The color of the first stripe in your testblog ^^";
        public static final String SECOND_STRIPE_COLOR      = "The color of the second stripe in your testblog ^^";
        public static final String AVATAR_BORDER_COLOR      = "The color of the border of your avatar in your testblog ^^";
        public static final String THEMECOLOR               = "The themecolor of your testblog ^^";
        public static final String SLIDING_HEADER           = "Whether the header-image of your testblog is supposed to be siliding ^^";
        public static final String BACKGROUND_STRIPES       = "Whether the background of your testblog is supposed to be stripes ^^";
        public static final String SHOW_QUOTES              = "Whether the quotes are supposed to be shown in your testblog ^^";
        public static final String TITLEFONT                = "The font of the title of your testblog ^^";
        public static final String TITLEBOLD                = "Whether the title of your testblog is supposed to be bold ^^";
        public static final String QUOTESJAVASCRIPTCODE     = "The quotes of your testblog in javascript code ^^";
        public static final String INFINITESCROLLING        = "Whether the posts of your testblog are supposed to be automatically loaded ^^";
        public static final String CUSTOMCSS                = "The customizing css of your testblog ^^";
        public static final String PAYRESPECTTOMYWORK       = "Whether you want to pay respect to my hard work or not ^^";
    }
}

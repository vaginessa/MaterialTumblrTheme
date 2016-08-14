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

import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.webkit.WebView;

import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.MainActivity;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.R;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.data.HTMLPreviewGenerator;

public class PreviewFragment extends Fragment{

    private HTMLPreviewGenerator mHTMLPreviewGenerator;

    private WebView mPreviewWebView;

    @Override
    public void onCreateOptionsMenu(Menu menu, MenuInflater inflater){
        inflater.inflate(R.menu.menu_fragment_preview, menu);
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item){
        switch(item.getItemId()){
            case R.id.menu_fragment_preview_generate:
                // Just casualities
                if(getActivity() instanceof MainActivity){
                    // Update the quotes code
                    mHTMLPreviewGenerator.setQuotesJavaScriptCode(((MainActivity) getActivity()).generateQuotesCode());

                    // Generate preview
                    mPreviewWebView.loadData(mHTMLPreviewGenerator.generate(), "text/html", null);
                    return true;
                }
            default:
                return false;
        }
    }

    @Nullable
    @Override
    public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState){
        mHTMLPreviewGenerator = ((MainActivity) getActivity()).getHTMLPreviewGenerator();

        View v = inflater.inflate(R.layout.layout_fragment_preview, container, false);
        mPreviewWebView = (WebView) v.findViewById(R.id.tab_preview_previewwebview);
        mPreviewWebView.getSettings().setJavaScriptEnabled(true);

        // Load a default "website" showing that you have to generate a preview by clicking "generate preview" in the context menu
        mPreviewWebView.loadData("<!DOCTYPEhtml>\n" +
                "<html>\n" +
                "\t<head>\n" +
                "\t\t<link href=\"https://fonts.googleapis.com/css?family=Josefin+Slab\" rel=\"stylesheet\">\n" +
                "\n" +
                "\t\t<style type=\"text/css\">\n" +
                "html, body{\n" +
                "\twidth: 99%;\n" +
                "\theight: 99%; \n" +
                "}\n" +
                ".emptyImageWrapper{\n" +
                "\theight: 40%;\n" +
                "\twidth: 100%;\n" +
                "\tposition: relative;\n" +
                "}\n" +
                ".emptyImage{\n" +
                "\tposition: absolute;\n" +
                "\tmargin: auto;\n" +
                "\ttop: 0;\n" +
                "\tleft: 0;\n" +
                "\tright: 0;\n" +
                "\tbottom: 0;\n" +
                "\n" +
                "\tmax-height: 100%;\n" +
                "\twidth: auto;\n" +
                "}\n" +
                ".caption{\n" +
                "\ttext-align: center;\n" +
                "\tfont-family: 'Josefin Slab', serif;\n" +
                "}\n" +
                ".upper{\n" +
                "\tfont-size: 1.8em;\n" +
                "\tfont-weight: bolder;\n" +
                "}\n" +
                ".lower{\n" +
                "\tfont-size: 1.2em;\n" +
                "\tfont-weight: bold;\n" +
                "}\n" +
                "\t\t</style>\n" +
                "\t</head>\n" +
                "\t<body>\n" +
                "\t\t<div class=\"emptyImageWrapper\">\n" +
                "\t\t\t<img src=\"http://i.imgur.com/7wYqwbA.png\" class=\"emptyImage\">\n" +
                "\t\t</div>\n" +
                "\t\t<p class=\"caption upper\">" + getString(R.string.preview_default_nopreview) + "</p>\n" +
                "\t\t<p class=\"caption lower\">" + getString(R.string.preview_default_generatedescription) +"</p>\n" +
                "\t</body>\n" +
                "</html>", "text/html", null);

        return v;
    }
}

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

package de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.views;

import android.support.design.widget.Snackbar;
import android.view.View;
import android.widget.TextView;

public class ColoredSnackbar{
    public static Snackbar make(int bg, View v, int id, int length){
        Snackbar bar = Snackbar.make(v, id, length);
        bar.getView().setBackgroundColor(bg);
        return bar;
    }

    public static Snackbar make(int bg, View v, CharSequence text, int length){
        Snackbar bar = Snackbar.make(v, text, length);
        bar.getView().setBackgroundColor(bg);
        return bar;
    }

    public static Snackbar make(View v, int id, int length, int font){
        Snackbar bar = Snackbar.make(v, id, length);
        ((TextView) bar.getView().findViewById(android.support.design.R.id.snackbar_text)).setTextColor(font);
        return bar;
    }

    public static Snackbar make(View v, CharSequence text, int length, int font){
        Snackbar bar = Snackbar.make(v, text, length);
        ((TextView) bar.getView().findViewById(android.support.design.R.id.snackbar_text)).setTextColor(font);
        return bar;
    }

    public static Snackbar make(int bg, View v, int id, int length, int font){
        Snackbar bar = Snackbar.make(v, id, length);
        bar.getView().setBackgroundColor(bg);
        ((TextView) bar.getView().findViewById(android.support.design.R.id.snackbar_text)).setTextColor(font);
        return bar;
    }

    public static Snackbar make(int bg, View v, CharSequence text, int length, int font){
        Snackbar bar = Snackbar.make(v, text, length);
        bar.getView().setBackgroundColor(bg);
        ((TextView) bar.getView().findViewById(android.support.design.R.id.snackbar_text)).setTextColor(font);
        return bar;
    }
}

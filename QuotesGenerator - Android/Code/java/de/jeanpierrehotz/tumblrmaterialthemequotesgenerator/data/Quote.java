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

import java.util.ArrayList;

public class Quote{

    private static final String PREFERENCECODE_QUOTE = "This is the quote at index ";
    private static final String PREFERENCECODE_ARTIST = "This is the artist at index ";
    private static final String PREFERENCECODE_SONG = "This is the song at index ";
    private static final String PREFERENCECODE_LENGTH = "This is the length of the list of quotes";

    private String mQuote;
    private String mArtist;
    private String mSong;

    public Quote(String q, String a, String s){
        if(q == null || q.equals("") || a == null || a.equals("") || s == null || s.equals(""))
            throw new IllegalArgumentException("You must give a value for everything");

        mQuote = q;
        mArtist = a;
        mSong = s;
    }

    public String getQuote(){
        return mQuote;
    }

    public String getArtist(){
        return mArtist;
    }

    public String getSong(){
        return mSong;
    }

    public static ArrayList<Quote> loadFromSharedPreferences(SharedPreferences prefs){
        ArrayList<Quote> quotes = new ArrayList<>();
        int length = prefs.getInt(PREFERENCECODE_LENGTH, 0);

        for(int i = 0; i < length; i++){
            quotes.add(
                    new Quote(
                            prefs.getString(PREFERENCECODE_QUOTE + i, ""),
                            prefs.getString(PREFERENCECODE_ARTIST + i, ""),
                            prefs.getString(PREFERENCECODE_SONG + i, "")
                    )
            );
        }

        return quotes;
    }

    public static void saveToSharedPreferences(ArrayList<Quote> quotes, SharedPreferences prefs){
        SharedPreferences.Editor edit = prefs.edit().clear().putInt(PREFERENCECODE_LENGTH, quotes.size());

        for(int i = 0; i < quotes.size(); i++){
            edit
                    .putString(PREFERENCECODE_QUOTE + i, quotes.get(i).mQuote)
                    .putString(PREFERENCECODE_ARTIST + i, quotes.get(i).mArtist)
                    .putString(PREFERENCECODE_SONG + i, quotes.get(i).mSong);
        }

        edit.apply();
    }
}

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

import android.support.v7.widget.RecyclerView;
import android.view.View;
import android.widget.TextView;

import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.R;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.data.Quote;

public class QuoteViewHolder extends RecyclerView.ViewHolder{

    private TextView mArtistTextView;
    private TextView mSongTextView;
    private TextView mQuoteTextView;

    private int mItemPosition;

    public void informOfItemPosition(int pos){
        this.mItemPosition = pos;
    }

    public int getItemPosition(){
        return mItemPosition;
    }

    public QuoteViewHolder(View itemView){
        super(itemView);

        mArtistTextView = (TextView) itemView.findViewById(R.id.quoteitem_artist_textview);
        mSongTextView = (TextView) itemView.findViewById(R.id.quoteitem_song_textview);
        mQuoteTextView = (TextView) itemView.findViewById(R.id.quoteitem_quote_textview);
    }

    public void setQuote(Quote q){
        mArtistTextView.setText(q.getArtist());
        mSongTextView.setText(q.getSong());
        mQuoteTextView.setText(q.getQuote());
    }
}

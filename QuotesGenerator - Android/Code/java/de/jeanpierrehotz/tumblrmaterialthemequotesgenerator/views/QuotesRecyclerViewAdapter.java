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
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import java.util.ArrayList;

import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.R;
import de.jeanpierrehotz.tumblrmaterialthemequotesgenerator.data.Quote;

public class QuotesRecyclerViewAdapter extends RecyclerView.Adapter<QuoteViewHolder>{

    private OnItemClickListener mOnItemClickListener;
    private OnItemLongClickListener mOnItemLongClickListener;

    private ArrayList<Quote> mDataSet;

    public QuotesRecyclerViewAdapter(ArrayList<Quote> dataset){
        mDataSet = dataset;
    }

    @Override
    public QuoteViewHolder onCreateViewHolder(ViewGroup parent, int viewType){
        final View v = LayoutInflater.from(parent.getContext()).inflate(R.layout.layout_item_quoteslist, parent, false);

        final QuoteViewHolder vh = new QuoteViewHolder(v);

        v.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view){
                if(mOnItemClickListener != null){
                    mOnItemClickListener.onItemClick(v, vh.getItemPosition(), vh.getItemId());
                }
            }
        });

        v.setOnLongClickListener(new View.OnLongClickListener(){
            @Override
            public boolean onLongClick(View view){
                if(mOnItemLongClickListener != null){
                    if(mOnItemLongClickListener.onItemLongClick(v, vh.getItemPosition(), vh.getItemId())){
                        return true;
                    }else if(mOnItemClickListener != null){
                        mOnItemClickListener.onItemClick(v, vh.getItemPosition(), vh.getItemId());
                    }
                }
                return false;
            }
        });

        return vh;
    }

    @Override
    public void onBindViewHolder(QuoteViewHolder holder, int position){
        holder.setQuote(mDataSet.get(position));
        holder.informOfItemPosition(position);
    }

    @Override
    public int getItemCount(){
        return mDataSet.size();
    }

    public void setOnItemClickListener(OnItemClickListener list){
        mOnItemClickListener = list;
    }

    public void setOnItemLongClickListener(OnItemLongClickListener list){
        mOnItemLongClickListener = list;
    }

    public interface OnItemClickListener{
        void onItemClick(View v, int pos, long id);
    }

    public interface OnItemLongClickListener{
        boolean onItemLongClick(View v, int pos, long id);
    }
}

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

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;

public class QuotesXMLParser {

    private static final boolean DEBUG = false;

    public static ArrayList<Quote> readQuotes(String filepath) throws IOException{
        if(DEBUG) System.out.println(filepath);
        String path = findPath(filepath);
        if(DEBUG) System.out.println(path);
        String filename = findName(filepath);
        if(DEBUG) System.out.println(filename);

        File xmlFile = new File(filepath);


        if(xmlFile.exists()) {
            String contents = "";
            BufferedReader reader = null;

            try {
                reader = new BufferedReader(new FileReader(xmlFile));
                String temp;

                while((temp = reader.readLine()) != null) {
                    contents += temp + "\n";
                }
            } catch (FileNotFoundException ex) {
                System.out.println(ex.getMessage());
            } catch (IOException ex) {
                System.out.println(ex.getMessage());
            } finally {
                if(reader != null){
                    try {
                        reader.close();
                    } catch (IOException ex) {
                        System.out.println(ex.getMessage());
                    }
                }
            }

            Token prefToken = Token.getTokensInside(contents)[0];//              we get the global parent
            String mName = prefToken.getAttribute("name");//                           whose name-attribute should equal the filename

            if(!filename.equals(mName)){
                throw new IOException("The file name may not be modified!");
            }

            Token[] valueranges = prefToken.getTokensInside();//                load the single datatype-trees in the root-tag

            Token[][] values = new Token[valueranges.length][];
            for(int i = 0; i < valueranges.length; i++){
                values[i] = valueranges[i].getTokensInside();//                 load all the values as Token-objects
            }

            HashMap<String, String> strings = new HashMap<>();
            HashMap<String, Integer> integers = new HashMap<>();

            for(Token t : values[2]) {
                strings.put(t.getAttribute("key"), t.getInterior());
            }

            for(Token t : values[5]) {
                integers.put(t.getAttribute("key"), Integer.parseInt(t.getInterior()));
            }

            ArrayList<Quote> quotes = new ArrayList<>();

            int length = integers.get(IDs.LENGTH);

            for(int i = 0; i < length; i++) {
                quotes.add(
                        new Quote(
                                strings.get(IDs.QUOTE_AT + i),
                                strings.get(IDs.ARTIST_AT + i),
                                strings.get(IDs.SONG_AT + i)
                        )
                );
            }

            return quotes;

        }else {
            throw new FileNotFoundException("Can't read from non-existent file.");
        }
    }

    public static void writeQuotes(ArrayList<Quote> quotes, String filepath) throws IOException {
        String content = "<!--\r\n" +
                "    DO NOT MODIFY THIS FILE OR ITS FILENAME!\r\n" +
                "    IT WILL NOT BE GUARANTEED TO BE USABLE WITH THE FOR THIS FILE AWAITED ALGORITHM ANYMORE!\r\n" +
                " \r\n" +
                "    Copyright 2016 Jean-Pierre Hotz\r\n" +
                "-->\r\n" +
                "<preference name=\"" + findName(filepath) + "\">\n\n";

        content += "\t<boolean_vals>\n\n";
        content += "\n\t</boolean_vals>\n\n";

        content += "\t<char_vals>\n\n";
        content += "\n\t</char_vals>\n\n";

        content += "\t<string_vals>\n\n";
        for (int i = 0; i < quotes.size(); i++) {
            content += "\t\t<value key=\"" + IDs.QUOTE_AT + i + "\">" + quotes.get(i).getQuote() + "</value>\n";
            content += "\t\t<value key=\"" + IDs.ARTIST_AT + i + "\">" + quotes.get(i).getArtist() + "</value>\n";
            content += "\t\t<value key=\"" + IDs.SONG_AT + i + "\">" + quotes.get(i).getSong() + "</value>\n";
        }
        content += "\n\t</string_vals>\n\n";

        content += "\t<byte_vals>\n\n";
        content += "\n\t</byte_vals>\n\n";

        content += "\t<short_vals>\n\n";
        content += "\n\t</short_vals>\n\n";

        content += "\t<int_vals>\n\n";
        content += "\t\t<value key=\"" + IDs.LENGTH + "\">" + quotes.size() + "</value>\n";
        content += "\n\t</int_vals>\n\n";

        content += "\t<long_vals>\n\n";
        content += "\n\t</long_vals>\n\n";

        content += "\t<float_vals>\n\n";
        content += "\n\t</float_vals>\n\n";

        content += "\t<double_vals>\n\n";
        content += "\n\t</double_vals>\n\n";

        content += "</preference>";

        File xmlFile = new File(filepath);

        if(!xmlFile.exists()) {
            xmlFile.getParentFile().mkdirs();
            xmlFile.createNewFile();
        }

        BufferedWriter writer = new BufferedWriter(new FileWriter(xmlFile));

        writer.write(content);

        writer.close();
    }

    private static String findPath(String path) {
        int ind = path.length();

        while(path.charAt(--ind) != File.separatorChar);

        ind++;

        return path.substring(0, ind);
    }

    private static String findName(String path) {
        int beg = path.length();
        int end = path.length();

        while(path.charAt(--beg) != File.separatorChar);

        beg++;

        while(path.charAt(--end) != '.');

        return path.substring(beg, end);
    }

    private static class IDs{
        public static final String LENGTH = "This is the amount of things saved in this preference.";
        public static final String QUOTE_AT = "This is the quote at the index ";
        public static final String ARTIST_AT = "This is the artist at the index ";
        public static final String SONG_AT = "This is the song at the index ";
    }

    private static class Token {
        private final HashMap<String, String> mAttributes;
        private final String mInterior;

        /**
         * This constructor constructs a Token with given attributes and the given text
         * inbetween its tags
         * @param attr a HashMap containing the attributes
         * @param inter the text between the tags
         */
        private Token(HashMap<String, String> attr, String inter){
            mAttributes = new HashMap<>(attr);
            mInterior = inter;
        }

        /**
         * This method gives you the tokens inside the token you called this method on
         * @return the tokens inside the token you called this method on
         */
        public Token[] getTokensInside(){
            return Token.getTokensInside(mInterior);
        }

        /**
         * This method gives you only (but all) tokens on top-level of the given text.<br>
         * Though you must assert that there is no token with the same name inside of a token.
         * @param tokenize the text you want the tokens from
         * @return all tokens on the top-level of the given text
         */
        public static Token[] getTokensInside(String tokenize){

            // remove all the comments inside the xml-files
            int com_beg = 0;
            int com_end = 0;

            for(int i = 0; i < tokenize.length(); i++) {
                if(tokenize.substring(i).startsWith("<!--")) {
                    com_beg = i;
                    com_end = i;

                    while(!tokenize.substring(0, com_end).endsWith("-->")) com_end++;

                    tokenize = tokenize.substring(0, com_beg) + tokenize.substring(com_end);
                }
            }


            ArrayList<Token> tokens = new ArrayList<>();

            int beg = 0;
            int name_end;
            int end = 0;

            while(beg < tokenize.length()){// we repeat until the beginning is at the end of the text
                while(beg < tokenize.length() && tokenize.charAt(beg) != '<'){// we look for the beginning-tag
                    beg++;
                }

                name_end = beg;
                while(name_end < tokenize.length() && tokenize.charAt(name_end) != ' ' && tokenize.charAt(name_end) != '>'){
                    name_end++;
                }

                // if there is no more token before the end of the text we end the searching
                if(beg >= tokenize.length() || name_end >= tokenize.length())
                    break;

                // we obtain the name of the beginning-tag
                String name = tokenize.substring(beg + 1, name_end);

                //with the name of the beginning-tag we search for the end-tag
                while(end < tokenize.length() && !tokenize.substring(end).startsWith("</" + name)){
                    end++;
                }

                while(end < tokenize.length() && tokenize.charAt(end) != '>'){
                    end++;
                }

                // if we found the end of the token before the end of the text
                if(end > beg && end < tokenize.length()){
                    // we try to obtain the actual token in this text section
                    Token tempToken = getTokenIn(tokenize.substring(beg, end + 1));

                    // if it was successfully obtained we add it to the list
                    if(tempToken != null)
                        tokens.add(tempToken);
                }

                beg = end;
            }

            // then we convert the ArrayList into an Array
            Token[] toRet = new Token[tokens.size()];
            for(int i = 0; i < toRet.length; i++){
                toRet[i] = tokens.get(i);
            }

            return toRet;
        }

        /**
         * This method gives you the top-level token in given string assuming that there only is one.
         * @param tokenize the string with the token
         * @return the token in the string
         */
        private static Token getTokenIn(String tokenize){
            int beg_beg = 0;
            int name_end = 0;
            int beg_end = 0;
            int end_beg = tokenize.length() - 1;
            int end_end = tokenize.length() - 1;

            // we search for the beginning-tag
            while (tokenize.charAt(beg_beg) != '<' && beg_beg < tokenize.length()) {
                beg_beg++;
            }

            while (tokenize.charAt(beg_end) != '>' && beg_end < tokenize.length()) {
                beg_end++;
            }

            // we search for the end-tag
            while (tokenize.charAt(end_beg) != '<' && end_beg >= 0) {
                end_beg--;
            }

            while (tokenize.charAt(end_end) != '>' && end_end >= 0) {
                end_end--;
            }

            // and we search for the name of the beginning-tag
            while(tokenize.charAt(name_end) != ' ' && tokenize.charAt(name_end) != '>' && name_end < tokenize.length()){
                name_end++;
            }

            // we obtain the names of the tags
            String beginningTag = tokenize.substring(beg_beg + 1, name_end);
            String endingTag = tokenize.substring(end_beg + 2, end_end);

            HashMap<String, String> attributes = new HashMap<>();

            if (name_end < beg_end) {// if there are attributes
                String attributeString = tokenize.substring(name_end + 1, beg_end);

                int key_beg = 0;
                int key_end = 0;
                int val_beg = 0;
                int val_end = attributeString.length() - 1;

                while(key_end < attributeString.length() && attributeString.charAt(key_end) != '=') key_end++;

                while(val_beg < attributeString.length() && attributeString.charAt(val_beg) != '\"') val_beg++;

                while(val_end >= 0 && attributeString.charAt(val_end) != '\"') val_end--;

                String key = attributeString.substring(key_beg, key_end);
                String val = attributeString.substring(val_beg + 1, val_end);

                if(DEBUG) System.out.println(key);
                if(DEBUG) System.out.println(val);

                attributes.put(key, val);
            }

            // then we obtain the interior
            String interior = tokenize.substring(beg_end + 1, end_beg);

            // if there's something weird going on we throw a RuntimeException
            if (tokenize.charAt(end_beg + 1) != '/' || !beginningTag.equals(endingTag)) {
                throw new RuntimeException("The file which contains the data was illegally changed!");
            }

            // otherwise we return a token with the determined attributes and interior
            return new Token(attributes, interior);
        }

        /**
         * This method gives you the attribute of the token with given key
         * @param key the key whose value you want
         * @return the attribute with given key
         */
        public String getAttribute(String key) {
            return mAttributes.get(key);
        }

        /**
         * This method gives you what was written inside the tag
         * @return the interior
         */
        public String getInterior(){
            return mInterior;
        }

        public String toString(){
            String attr = "";

            for(String key : mAttributes.keySet()){
                attr += key + " - " + mAttributes.get(key) + "\n";
            }

            return attr;
        }
    }
}

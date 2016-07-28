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
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace TumblrMaterialThemeQuotesGenerator
{
    public class Preference
    {
        #region Attributes
        private readonly string mXMLFile;
        private string mName;

        private readonly Dictionary<string, bool> mBooleanValues;
        private readonly Dictionary<string, char> mCharValues;
        private readonly Dictionary<string, string> mStringValues;
        private readonly Dictionary<string, byte> mByteValues;
        private readonly Dictionary<string, short> mShortValues;
        private readonly Dictionary<string, int> mIntValues;
        private readonly Dictionary<string, long> mLongValues;
        private readonly Dictionary<string, float> mFloatValues;
        private readonly Dictionary<string, double> mDoubleValues;
        #endregion

        #region Constructors
        public Preference(string name)
        {
            mBooleanValues = new Dictionary<string, bool>();
            mCharValues = new Dictionary<string, char>();
            mStringValues = new Dictionary<string, string>();
            mByteValues = new Dictionary<string, byte>();
            mShortValues = new Dictionary<string, short>();
            mIntValues = new Dictionary<string, int>();
            mLongValues = new Dictionary<string, long>();
            mFloatValues = new Dictionary<string, float>();
            mDoubleValues = new Dictionary<string, double>();

            mXMLFile = "C:\\preferences\\" + name + ".xml";

            initializeValues(name);
        }

        public Preference(string path, string name)
        {
            mBooleanValues = new Dictionary<string, bool>();
            mCharValues = new Dictionary<string, char>();
            mStringValues = new Dictionary<string, string>();
            mByteValues = new Dictionary<string, byte>();
            mShortValues = new Dictionary<string, short>();
            mIntValues = new Dictionary<string, int>();
            mLongValues = new Dictionary<string, long>();
            mFloatValues = new Dictionary<string, float>();
            mDoubleValues = new Dictionary<string, double>();

            mXMLFile = path + (path.EndsWith("\\") ? "" : "\\") + name + ".xml";

            initializeValues(name);
        }
        #endregion

        #region Private Miscellanous
        private void initializeValues(string name)
        {
            if (File.Exists(mXMLFile))
            {
                string fileContent = File.ReadAllText(mXMLFile);

                if (!updateContent(fileContent) || !name.Equals(mName))
                    throw new ArgumentException("The file which contains the data was illegally changed!");
            }
            else
            {
                mName = name;
                edit().commit();
            }
        }

        private bool updateContent(string content)
        {
            try
            {
                Token prefToken = Token.getTokensInside(content)[0];
                mName = prefToken.getAttribute("name");

                Token[] valuerange = prefToken.getTokensInside();

                Token[][] values = new Token[valuerange.Length][];
                for (int i = 0; i < valuerange.Length; i++)
                {
                    values[i] = valuerange[i].getTokensInside();
                }

                mBooleanValues.Clear();
                mCharValues.Clear();
                mStringValues.Clear();
                mByteValues.Clear();
                mShortValues.Clear();
                mIntValues.Clear();
                mLongValues.Clear();
                mFloatValues.Clear();
                mDoubleValues.Clear();

                for (int range = 0; range < values.Length; range++)
                {
                    foreach (Token t in values[range])
                    {
                        switch (range)
                        {
                            case 0:
                                mBooleanValues[t.getAttribute("key")] = Convert.ToBoolean(t.getInterior());
                                break;
                            case 1:
                                mCharValues[t.getAttribute("key")] = Convert.ToChar(t.getInterior());
                                break;
                            case 2:
                                mStringValues[t.getAttribute("key")] = t.getInterior();
                                break;
                            case 3:
                                mByteValues[t.getAttribute("key")] = Convert.ToByte(t.getInterior());
                                break;
                            case 4:
                                mShortValues[t.getAttribute("key")] = Convert.ToInt16(t.getInterior());
                                break;
                            case 5:
                                mIntValues[t.getAttribute("key")] = Convert.ToInt32(t.getInterior());
                                break;
                            case 6:
                                mLongValues[t.getAttribute("key")] = Convert.ToInt64(t.getInterior());
                                break;
                            case 7:
                                mFloatValues[t.getAttribute("key")] = Convert.ToSingle(t.getInterior());
                                break;
                            case 8:
                                mDoubleValues[t.getAttribute("key")] = Convert.ToDouble(t.getInterior());
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                return false;
            }
            return true;
        }
        #endregion

        #region Public Preferences Methods
        public bool getBoolean(string key, bool def)
        {
            if (mBooleanValues.ContainsKey(key))
                return mBooleanValues[key];
            return def;
        }

        public char getChar(string key, char def)
        {
            if (mCharValues.ContainsKey(key))
                return mCharValues[key];
            return def;
        }

        public string getString(string key, string def)
        {
            if (mStringValues.ContainsKey(key))
                return mStringValues[key];
            return def;
        }

        public byte getByte(string key, byte def)
        {
            if (mByteValues.ContainsKey(key))
                return mByteValues[key];
            return def;
        }

        public short getShort(string key, short def)
        {
            if (mShortValues.ContainsKey(key))
                return mShortValues[key];
            return def;
        }

        public int getInt(string key, int def)
        {
            if (mIntValues.ContainsKey(key))
                return mIntValues[key];
            return def;
        }

        public long getLong(string key, long def)
        {
            if (mLongValues.ContainsKey(key))
                return mLongValues[key];
            return def;
        }

        public float getFloat(string key, float def)
        {
            if (mFloatValues.ContainsKey(key))
                return mFloatValues[key];
            return def;
        }

        public double getDouble(string key, double def)
        {
            if (mDoubleValues.ContainsKey(key))
                return mDoubleValues[key];
            return def;
        }

        public bool contains(string key)
        {
            return mBooleanValues.ContainsKey(key) || mCharValues.ContainsKey(key)
                || mStringValues.ContainsKey(key) || mByteValues.ContainsKey(key)
                || mShortValues.ContainsKey(key) || mIntValues.ContainsKey(key)
                || mLongValues.ContainsKey(key) || mFloatValues.ContainsKey(key)
                || mDoubleValues.ContainsKey(key);
        }

        public Editor edit()
        {
            return new Editor(this);
        }
        #endregion

        #region Inner classes
        public class Editor
        {
            private Preference parent;

            private readonly Dictionary<string, bool> mTempBooleanValues;
            private readonly Dictionary<string, char> mTempCharValues;
            private readonly Dictionary<string, string> mTempStringValues;
            private readonly Dictionary<string, byte> mTempByteValues;
            private readonly Dictionary<string, short> mTempShortValues;
            private readonly Dictionary<string, int> mTempIntValues;
            private readonly Dictionary<string, long> mTempLongValues;
            private readonly Dictionary<string, float> mTempFloatValues;
            private readonly Dictionary<string, double> mTempDoubleValues;

            internal Editor(Preference p)
            {
                parent = p;

                mTempBooleanValues = new Dictionary<string, bool>(p.mBooleanValues);
                mTempCharValues = new Dictionary<string, char>(p.mCharValues);
                mTempStringValues = new Dictionary<string, string>(p.mStringValues);
                mTempByteValues = new Dictionary<string, byte>(p.mByteValues);
                mTempShortValues = new Dictionary<string, short>(p.mShortValues);
                mTempIntValues = new Dictionary<string, int>(p.mIntValues);
                mTempLongValues = new Dictionary<string, long>(p.mLongValues);
                mTempFloatValues = new Dictionary<string, float>(p.mFloatValues);
                mTempDoubleValues = new Dictionary<string, double>(p.mDoubleValues);
            }

            public Editor clear()
            {
                mTempBooleanValues.Clear();
                mTempCharValues.Clear();
                mTempStringValues.Clear();
                mTempByteValues.Clear();
                mTempShortValues.Clear();
                mTempIntValues.Clear();
                mTempLongValues.Clear();
                mTempFloatValues.Clear();
                mTempDoubleValues.Clear();

                return this;
            }

            public Editor remove(string key)
            {
                mTempBooleanValues.Remove(key);
                mTempCharValues.Remove(key);
                mTempStringValues.Remove(key);
                mTempByteValues.Remove(key);
                mTempShortValues.Remove(key);
                mTempIntValues.Remove(key);
                mTempLongValues.Remove(key);
                mTempFloatValues.Remove(key);
                mTempDoubleValues.Remove(key);

                return this;
            }

            public Editor putBoolean(string key, bool val)
            {
                mTempBooleanValues[key] = val;

                return this;
            }

            public Editor putChar(string key, char val)
            {
                mTempCharValues[key] = val;

                return this;
            }

            public Editor putString(string key, string val)
            {
                mTempStringValues[key] = val;

                return this;
            }

            public Editor putByte(string key, byte val)
            {
                mTempByteValues[key] = val;

                return this;
            }

            public Editor putShort(string key, short val)
            {
                mTempShortValues[key] = val;

                return this;
            }

            public Editor putInt(string key, int val)
            {
                mTempIntValues[key] = val;

                return this;
            }

            public Editor putLong(string key, long val)
            {
                mTempLongValues[key] = val;

                return this;
            }

            public Editor putFloat(string key, float val)
            {
                mTempFloatValues[key] = val;

                return this;
            }

            public Editor putDouble(string key, double val)
            {
                mTempDoubleValues[key] = val;

                return this;
            }

            public void apply()
            {
                new Thread(executeApply).Start();
            }
            private void executeApply()
            {
                try
                {
                    writeToFile();
                    parent.initializeValues(parent.mName);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }

            public bool commit()
            {
                try
                {
                    writeToFile();
                    parent.initializeValues(parent.mName);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    return false;
                }

                return true;
            }

            private void writeToFile()
            {
                string content = "<preference name=\"" + parent.mName + "\">\n\n";

                content += "\t<boolean_vals>\n\n";
                foreach (string key in mTempBooleanValues.Keys)
                {
                    content += "\t\t<value key=\"" + key + "\">" + mTempBooleanValues[key] + "</value>\n";
                }
                content += "\n\t</boolean_vals>\n\n";

                content += "\t<char_vals>\n\n";
                foreach (string key in mTempCharValues.Keys)
                {
                    content += "\t\t<value key=\"" + key + "\">" + mTempCharValues[key] + "</value>\n";
                }
                content += "\n\t</char_vals>\n\n";

                content += "\t<string_vals>\n\n";
                foreach (string key in mTempStringValues.Keys)
                {
                    content += "\t\t<value key=\"" + key + "\">" + mTempStringValues[key] + "</value>\n";
                }
                content += "\n\t</string_vals>\n\n";

                content += "\t<byte_vals>\n\n";
                foreach (string key in mTempByteValues.Keys)
                {
                    content += "\t\t<value key=\"" + key + "\">" + mTempByteValues[key] + "</value>\n";
                }
                content += "\n\t</byte_vals>\n\n";

                content += "\t<short_vals>\n\n";
                foreach (string key in mTempShortValues.Keys)
                {
                    content += "\t\t<value key=\"" + key + "\">" + mTempShortValues[key] + "</value>\n";
                }
                content += "\n\t</short_vals>\n\n";

                content += "\t<int_vals>\n\n";
                foreach (string key in mTempIntValues.Keys)
                {
                    content += "\t\t<value key=\"" + key + "\">" + mTempIntValues[key] + "</value>\n";
                }
                content += "\n\t</int_vals>\n\n";

                content += "\t<long_vals>\n\n";
                foreach (string key in mTempLongValues.Keys)
                {
                    content += "\t\t<value key=\"" + key + "\">" + mTempLongValues[key] + "</value>\n";
                }
                content += "\n\t</long_vals>\n\n";

                content += "\t<float_vals>\n\n";
                foreach (string key in mTempFloatValues.Keys)
                {
                    content += "\t\t<value key=\"" + key + "\">" + mTempFloatValues[key] + "</value>\n";
                }
                content += "\n\t</float_vals>\n\n";

                content += "\t<double_vals>\n\n";
                foreach (string key in mTempDoubleValues.Keys)
                {
                    content += "\t\t<value key=\"" + key + "\">" + mTempDoubleValues[key] + "</value>\n";
                }
                content += "\n\t</double_vals>\n\n";

                content += "</preference>";

                File.WriteAllText(parent.mXMLFile, content);
            }
        }

        private class Token
        {
            private readonly Dictionary<string, string> mAttributes;
            private readonly string mInterior;

            private Token(Dictionary<string, string> attr, string inter)
            {
                mAttributes = new Dictionary<string, string>(attr);
                mInterior = inter;
            }

            public Token[] getTokensInside()
            {
                return Token.getTokensInside(mInterior);
            }

            public static Token[] getTokensInside(string tokenize)
            {
                List<Token> tokens = new List<Token>();

                int beg = 0;
                int name_end;
                int end = 0;

                char[] tokenize_charAt = tokenize.ToCharArray();

                while (beg < tokenize.Length)
                {
                    while (beg < tokenize.Length && tokenize_charAt[beg] != '<') beg++;

                    name_end = beg;

                    while (name_end < tokenize.Length && tokenize_charAt[name_end] != ' ' && tokenize_charAt[name_end] != '>') name_end++;

                    if (beg >= tokenize.Length || name_end >= tokenize.Length) break;

                    string name = tokenize.Substring(beg + 1, name_end - beg - 1);

                    while (end < tokenize.Length && !tokenize.Substring(end).StartsWith("</" + name)) end++;

                    while (end < tokenize.Length && tokenize_charAt[end] != '>') end++;

                    if (end > beg && end < tokenize.Length)
                    {
                        Token temp = getTokenIn(tokenize.Substring(beg, end + 1 - beg));

                        if (temp != null)
                            tokens.Add(temp);
                    }

                    beg = end;
                }

                Token[] result = new Token[tokens.Count];
                for (int i = 0; i < tokens.Count; i++)
                {
                    result[i] = tokens[i];
                }

                return result;
            }

            private static Token getTokenIn(string tokenize)
            {
                int beg_beg = 0;
                int name_end = 0;
                int beg_end = 0;
                int end_beg = tokenize.Length - 1;
                int end_end = tokenize.Length - 1;

                char[] tokenize_charAt = tokenize.ToCharArray();

                while (beg_beg < tokenize.Length && tokenize_charAt[beg_beg] != '<') beg_beg++;

                while (beg_end < tokenize.Length && tokenize_charAt[beg_end] != '>') beg_end++;

                while (end_beg >= 0 && tokenize_charAt[end_beg] != '<') end_beg--;

                while (end_end >= 0 && tokenize_charAt[end_end] != '>') end_end--;

                while (name_end < tokenize.Length && tokenize_charAt[name_end] != ' ' && tokenize_charAt[name_end] != '>') name_end++;

                string beginningTag = tokenize.Substring(beg_beg + 1, name_end - beg_beg - 1);
                string endingTag = tokenize.Substring(end_beg + 2, end_end - end_beg - 2);

                Dictionary<string, string> attributes = new Dictionary<string, string>();

                if (name_end < beg_end)
                {
                    string attributeString = tokenize.Substring(name_end + 1, beg_end - name_end - 1);

                    char[] attributeString_charAt = attributeString.ToCharArray();

                    int key_beg = 0;
                    int key_end = 0;
                    int val_beg = 0;
                    int val_end = attributeString.Length - 1;

                    while (key_end < attributeString.Length && attributeString_charAt[key_end] != '=') key_end++;
                    while (val_beg < attributeString.Length && attributeString_charAt[val_beg] != '\"') val_beg++;
                    while (val_end >= 0 && attributeString_charAt[val_end] != '\"') val_end--;

                    string key = attributeString.Substring(key_beg, key_end - key_beg);
                    string val = attributeString.Substring(val_beg + 1, val_end - val_beg - 1);

                    attributes[key] = val;
                }

                String interior = tokenize.Substring(beg_end + 1, end_beg - beg_end - 1);

                if (tokenize_charAt[end_beg + 1] != '/' || !beginningTag.Equals(endingTag))
                    throw new ArgumentException("The file which contains the data was illegally changed!");

                return new Token(attributes, interior);
            }

            public string getAttribute(string key)
            {
                if (mAttributes.ContainsKey(key))
                    return mAttributes[key];
                else
                    return null;
            }

            public string getInterior()
            {
                return mInterior;
            }
        }
        #endregion
    }
}

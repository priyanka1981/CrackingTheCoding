using System;
using System.Text;
namespace test.Properties
{
    public class CrackingTheCoding
    {
        public CrackingTheCoding()
        {
        }

        public bool isUniqueChar(string str)
        {
            str = str.ToLower();
            Boolean[] array = new Boolean[26];
            foreach(char ch in str)
            {
                if (array[ch-'a'])
                    return false;
                else
                array[ch-'a'] = true;
            }
            return true;
        }

        public string reverseString(string str){
            int start = 0;
            char temp;
            StringBuilder builder = new StringBuilder();
            builder.Length = str.Length;
            int end = str.Length - 1;
            while(start <= end){
                temp = str[start];
                builder[start] = str[end];
                builder[end] = temp;
                start++;
                end--;
            }

            return builder.ToString();
        }
    }
}

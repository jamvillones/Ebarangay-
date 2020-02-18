using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Barangay.Class
{
    public class NameSeparatingHelper
    {
        public NameSeparatingHelper(string fullName)
        {
            List<string> nameList = new List<string>();
            string word = "";
            string name = fullName;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ')
                {                  
                    nameList.Add(word);
                    word = string.Empty;
                }
                else
                {
                    word += name[i];
                    if (i == name.Length - 1)
                    {
                        nameList.Add(word);
                        word = string.Empty;
                    }
                }
            }
            for (int i = 0; i < nameList.Count; i++)
            {
                names[i] = nameList[i];
            }
            First = names[0];
            Middle = names[1];
            Last = names[2];
            Extension = names[3];


        }
        public string this[int i]
        {
            get { return names[i]; }
        }
        string[] names = new string[4];
        public string First { get; private set; }
        public string Middle { get; private set; }
        public string Last { get; private set; }
        public string Extension { get; private set; }
    }
}

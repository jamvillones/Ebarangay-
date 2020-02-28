using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Barangay.Class
{
    public class NameHelper
    {
        public NameHelper(string fullName)
        {
            char[] chars = { ',' };
            var nameList = fullName.Split(chars);
            for (int i = 0; i < nameList.Length; i++)
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
        public string MiddleInitial
        {
            get
            {
                if (string.IsNullOrEmpty(Middle))
                    return string.Empty;

                return Middle.Substring(0, 1);
            }
        }
        public string Last { get; private set; }
        public string Extension { get; private set; }

    }
}

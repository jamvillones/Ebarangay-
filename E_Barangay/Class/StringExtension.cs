using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Barangay.Class
{
    public static class StringExtension
    {
        public static string NonBlankValueOf(this string source, string replacement)
        {
            return (string.IsNullOrEmpty(source)) ? replacement : source;
        }
    }
}

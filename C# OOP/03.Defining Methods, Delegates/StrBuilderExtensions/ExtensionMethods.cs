using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrBuilderExtensions
{
    public static class ExtensionMethods
    {
        public static string Substring(this StringBuilder sb, int index, int length)
        {
            string result = sb.ToString(index, length);
            return result;
        }

    }
}

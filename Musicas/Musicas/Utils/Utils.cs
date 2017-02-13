using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicas.Utils
{
    public class Utils
    {
        public static bool NoWhiteNoEmpty(string text)
        {
            if(string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

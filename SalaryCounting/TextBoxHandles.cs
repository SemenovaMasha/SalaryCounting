using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCounting
{
    static class TextBoxHandles
    {
        public static void onlyRusSymbolsNoNumKeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!(c == (char)8) && !(c >= 'А' && c <= 'я'))
            {
                e.Handled = true;
            }
        }
        public static void onlyIntNumbersKeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!(c == (char)8) && !(c <= '9' && c >= '0'))
            {
                e.Handled = true;
            }
        }
        public static void onlyPositiveDoubleNumbersKeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!(c == 'ё') && !(c == 'Ё') && !(c == (char)8) && !(c <= '9' && c >= '0') 
                && !((c == '.'|| c == ',') && !(((TextBox)sender).Text.Contains(",")|| ((TextBox)sender).Text.Contains("."))))
            {
                e.Handled = true;
            }
        }
    }
}

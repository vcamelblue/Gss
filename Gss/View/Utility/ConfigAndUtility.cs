using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Gss.View.Utility
{
    public static class ConfigAndUtility
    {
        public static readonly Color normalButtonColor = Color.FromKnownColor(KnownColor.LightGray);
        public static readonly Color selectedButtonColor = Color.FromArgb(54, 78, 102); //Color.FromKnownColor(KnownColor.MenuHighlight);
        public static readonly Color normalFontColor = Color.FromKnownColor(KnownColor.Black);
        public static readonly Color selectFontColor = Color.FromArgb(251, 251, 251);


        
        
        //Utility Methods

        public static bool checkFields(params String[] fields)
        {
            bool all_Ok = true;

            foreach (String s in fields)
            {
                all_Ok &= (s != "");
            }
            return all_Ok;
        }

        public static String noNullString(String source)
        {
            return source != null ? source : "";
        }
    }
}

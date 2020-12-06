using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAPPCS.Helper
{
    class DesignColorReset
    {
        //Button
        public static Color ButtonAdd = System.Drawing.Color.Teal;
        public static Color ButtonEdit = System.Drawing.Color.DarkOrange;
        public static Color ButtonSave = System.Drawing.Color.LightSeaGreen;
        public static Color ButtonDelete = System.Drawing.Color.DodgerBlue;
        public static Color ButtonRefresh = System.Drawing.Color.Crimson;
        public static Color ButtonText = System.Drawing.Color.White;


        //Main Form
        public static Color PanelHeader = ColorLibrary.PrimaryColor;
        public static Color PanelTitle = ColorLibrary.DarkPrimaryColor;
        public static Color PanelProfile = ColorLibrary.DarkPrimaryColor;
        public static Color PanelFooter = ColorLibrary.DarkPrimaryColor;
        public static Color PanelSparatorFormChild = System.Drawing.Color.DarkOrange;
        public static Color ButtonMinimizeFormChild = System.Drawing.Color.Salmon;
        public static Color ButtonCloseFormChild = System.Drawing.Color.Salmon;

        //DataGridView
        public static Color dgv_AlternatingRowsDefaultCellStyle = Color.FromArgb(247, 255, 253);

        //MenuStrip
        public static Color ItemHover = ColorLibrary.PrimaryColor;
        public static Color ItemOdd = Color.FromArgb(51, 133, 166);
        public static Color ItemEven = Color.SteelBlue;
        public static Color ItemForeColor = Color.White;
        public static Color PanelMenuBackground = Color.FromArgb(0, 192, 192);


        //Text Color
        public static Color TextForeColor = Color.White;
    }
}

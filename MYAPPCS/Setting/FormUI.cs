using MYAPPCS.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYAPPCS
{
    public partial class FormUI : Form
    {
        public FormUI()
        {
            InitializeComponent();
        }

        private void FormUI_Load(object sender, EventArgs e)
        {
            GetVariableDesignList();
            GetListColor();
        }
        void GetListColor()
        {
            ComboBoxColor.DrawMode = DrawMode.OwnerDrawFixed;
            ComboBoxColor.ItemHeight = 21;
            Type colType = typeof(Color);
            foreach (PropertyInfo prop in colType.GetProperties())
            {
                if (prop.PropertyType == typeof(Color))
                    ComboBoxColor.Items.Add(prop.Name);
            }
        }
        Type varType;
        void GetVariableDesignList()
        {
            varType = typeof(DesignColor);
            foreach (System.Reflection.FieldInfo fi in varType.GetFields())
            {
                ComboBoxVarDesignName.Items.Add(fi.Name);
            }
        }

        private void ComboBoxColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;
            Brush colBrush = new SolidBrush(Color.FromName((String)ComboBoxColor.Items[e.Index]));
            e.Graphics.DrawRectangle(new Pen(Brushes.Black), e.Bounds.Left + 2, e.Bounds.Top + 2, 30, e.Bounds.Height - 5);
            e.Graphics.FillRectangle(colBrush, e.Bounds.Left + 3, e.Bounds.Top + 3, 29, e.Bounds.Height - 6);
            e.Graphics.DrawString((String)ComboBoxColor.Items[e.Index], ComboBoxColor.Font, Brushes.Black, 35, e.Bounds.Top + 2);
        }

        private void ButtonSetUp_Click(object sender, EventArgs e)
        {
            if (ComboBoxColor.SelectedIndex >= 0 && ComboBoxVarDesignName.SelectedIndex >= 0)
            {
                var ColorSelected = Color.FromName((String)ComboBoxColor.Items[ComboBoxColor.SelectedIndex]);
                var variable = varType.GetFields()[ComboBoxVarDesignName.SelectedIndex];
                variable.SetValue(Color.Transparent, ColorSelected);
                MYAPPCS.Properties.Settings.Default[variable.Name] = ColorSelected;
                MYAPPCS.Properties.Settings.Default.Save();
                var formMain = (FormMain)GetOpenForm.GetForm("FormMain");
                formMain.SetDesignUI();
            }
            else
                MessageBox.Show("Please Select Design and Color");
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reset UI Color", "Are You Sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ResetDesignColor();
            }
        }
        void ResetDesignColor()
        {
            Type varType = typeof(DesignColorReset);
            foreach (System.Reflection.FieldInfo fi in varType.GetFields())
            {
                MYAPPCS.Properties.Settings.Default[fi.Name] = fi.GetValue(Color.Transparent);
            }
            MYAPPCS.Properties.Settings.Default.Save();
            SetDesignColor();
            var formMain = (FormMain)GetOpenForm.GetForm("FormMain");
            formMain.SetDesignUI();
        }
        void SetDesignColor()
        {
            Type varType = typeof(DesignColor);
            foreach (System.Reflection.FieldInfo fi in varType.GetFields())
            {
                fi.SetValue(Color.Transparent, MYAPPCS.Properties.Settings.Default[fi.Name]);
            }
        }
    }
}

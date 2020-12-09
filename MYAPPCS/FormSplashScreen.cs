using MYAPPCS.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYAPPCS
{
    public partial class FormSplashScreen : Form
    {
        private bool init = true;
        private string pathapp = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public FormSplashScreen()
        {
            InitializeComponent();
        }
        private void timerProses_Tick(object sender, EventArgs e)
        {
            if (init)
            {
                SqlService.SetConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + pathapp + "\\DatabaseLocal.mdf\";Integrated Security=True";
                //SqlService.SetConnection = "Data Source=ANNAJIYAH\\SQLEXPRESS;Initial Catalog=MYAPP;User ID=sa;Password=123";
                GetDesignColor();
                SetDesignColor();
                Close();
            }
            init = false;
        }

        void GetDesignColor()
        {
            Type varType = typeof(DesignColor);
            foreach (System.Reflection.FieldInfo fi in varType.GetFields())
            {
                if (!CheckPropIsExist(fi.Name))
                {
                    AddProperty(fi.Name, (Color)fi.GetValue(Color.Transparent), typeof(Color));
                    MYAPPCS.Properties.Settings.Default.Reload();
                }
            }
        }
        void SetDesignColor()
        {
            Type varType = typeof(DesignColor);
            foreach (System.Reflection.FieldInfo fi in varType.GetFields())
            {
                fi.SetValue(Color.Transparent, MYAPPCS.Properties.Settings.Default[fi.Name]);
            }
        }

        bool CheckPropIsExist(String propertyName)
        {
            try
            {
                var val = MYAPPCS.Properties.Settings.Default[propertyName];
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        void AddProperty(String propertyName, Color defaultValue, Type propertyType)
        {
            String providerName = "LocalFileSettingsProvider";
            var attributes = new System.Configuration.SettingsAttributeDictionary();
            var attr = new System.Configuration.UserScopedSettingAttribute();
            attributes.Add(attr.TypeId, attr);
            SettingsProvider settingProvider = Properties.Settings.Default.Providers[providerName];
            var prop = new System.Configuration.SettingsProperty(
      new System.Configuration.SettingsProperty(propertyName, propertyType,
    settingProvider, false, defaultValue,
     System.Configuration.SettingsSerializeAs.String, attributes, false, false));
            MYAPPCS.Properties.Settings.Default.Properties.Add(prop);
        }
    }
}

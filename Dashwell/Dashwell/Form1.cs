using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashwell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var iniFile = new IniFile("dashwell.ini");
            Globals.sUnivLogin = iniFile.GetValue("Login", "universe", "auth.activeworlds.com");
            //Console.WriteLine(Globals.sUnivLogin);
        }

        public static class Globals
        {
            public static string sUnivLogin;
            public static int iPort = 6670;
            public static string sBotName = "Dashwell";
            public static int iCitNum = 318855;
            public static string sPassword = "password";
            public static string sWorld = "Simulator";
            public static string sCoords = "0n 0w 0a 0";
            public static int iXPos = 0;
            public static int iYPos = 0;
            public static int iZPos = 0;
            public static int iYaw = 0;
            public static int iAV = 1;

            public static bool iInUniv = false;
            public static bool iInWorld = false;
        }




    }
}

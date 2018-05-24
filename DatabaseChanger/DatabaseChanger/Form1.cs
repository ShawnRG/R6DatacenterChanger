﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseChanger
{
    public partial class Form1 : Form
    {
        private readonly string PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\My Games\\Rainbow Six - Siege";
        private readonly string BASE_URI = "https://r6db.com/api/v2/players/";

        private readonly string[] hints = new[]
            {"default", "eus", "cus", "scus", "wus", "sbr", "neu", "weu", "eas", "seas", "eau", "wja"};
        
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            foreach (string s in hints)
            {
                cboDatacenter.Items.Add(s);
            }
            
            btnApply.Click += new EventHandler(this.Button_Pressed);
            cboUUID.SelectedIndexChanged += new EventHandler(this.onIndexChanged);
            var directories = Directory.GetDirectories(PATH);
            
            
            
            foreach (string directory in directories)
            {
                
                cboUUID.Items.Add(directory.Remove(0,PATH.Length+1));
            }
            cboUUID.SelectedIndex = 0;
            cboDatacenter.SelectedIndex = 0;
            lblStatus.Text = "";
            
            cboDatacenter.SelectedItem = getCurrentDatacenter();
            
            


        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            var currDatacenter =
                File
                    .ReadLines(PATH + "\\" + cboUUID.SelectedItem + "\\GameSettings.ini")
                    .First(s => s.Contains("DataCenterHint="));
            
            var newDatacenter =
                File.ReadAllText(
                    PATH + "\\" + cboUUID.SelectedItem + "\\GameSettings.ini");

            newDatacenter = newDatacenter.Replace(currDatacenter, "DataCenterHint=" + cboDatacenter.SelectedItem);
            
            File.WriteAllText( PATH + "\\" + cboUUID.SelectedItem + "\\GameSettings.ini", newDatacenter);
            
            lblStatus.Text = "Succesfully applied";
            
        }

        private string getCurrentDatacenter()
        {
            var currDatacenter =
                File
                    .ReadLines(PATH + "\\" + cboUUID.SelectedItem + "\\GameSettings.ini")
                    .First(s => s.Contains("DataCenterHint=")).Replace("DataCenterHint=", "");

            return currDatacenter;
        }

        private void onIndexChanged(object sender, EventArgs e)
        {
            cboDatacenter.SelectedItem = getCurrentDatacenter();
        }
        
       
        
     
        
    }
}

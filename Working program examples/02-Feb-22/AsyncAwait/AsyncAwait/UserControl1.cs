﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace AsyncAwait
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Windows");
        }

        private int countChar()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("Mydatafile.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }

        private async void ClickButton_Click(object sender, EventArgs e)
        {
            //normal thread based 

            //int z = countChar();
            //label1.Text = "Processing file ..please wait...";
            //label1.Text = z.ToString() + " " + "Characters in the file";
            //task based using async and await
            Task<int> task = new Task<int>(countChar);
            task.Start();
            label1.Text = "Processing file.. please wait..";
            int z = await task;
            label1.Text = z.ToString() + " " + "Characters in the File";
        }
    }
}

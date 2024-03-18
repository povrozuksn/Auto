﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class AuthForm : Form
    {
        public static string name = "";
        public static string family = "";
        public static bool isAdmin;
        System.Media.SoundPlayer player_error = new System.Media.SoundPlayer(@"../../Sound/error.wav");
        System.Media.SoundPlayer player_auth = new System.Media.SoundPlayer(@"../../Sound/auth.wav");

        public AuthForm()
        {
            InitializeComponent();

            Text = "Авторизация";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strs = File.ReadAllLines("users.txt");

            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] {", "}, StringSplitOptions.None);

                if (LoginTextBox.Text == parts[2] && PassTextBox.Text == parts[3])
                {
                    name = parts[0];
                    family = parts[1];
                    MainForm.Login = parts[2];
                    isAdmin = Convert.ToBoolean(Convert.ToInt32(parts[4]));
                    player_auth.Play();
                    Close();
                    return;
                }
            }

            player_error.Play();
            MessageBox.Show("Неправильный логин/пароль");            
        }
    }
}

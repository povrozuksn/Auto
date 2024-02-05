using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class AuthForm : Form
    {
        public static string Login = "";

        public AuthForm()
        {
            InitializeComponent();

            Text = "Авторизация";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "Serg" && PassTextBox.Text == "12345")
            {
                Login = LoginTextBox.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин/пароль");
            }
        }
    }
}

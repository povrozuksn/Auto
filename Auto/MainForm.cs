using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Auto
{
    #region Структура объекта справочника 
    public struct Car
    {
        public string name;
        public string kuzov;
        public string kpp;
        public int power;
        public int price;
        public string web;
        public Button btn;
        public PictureBox pic;

        public Car(string _name, string _kuzov, string _kpp, int _power, int _price, string _web)
        {
            name = _name;
            kuzov = _kuzov;
            kpp = _kpp;
            power = _power;
            price = _price;
            web = _web;
            btn = new Button();
            pic = new PictureBox();

            btn.Font = new Font("Microsoft Sans Serif", 12F);
            btn.Text = name;

            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Load("../../Pictures/" + name + ".jpg");
        }
    }
    #endregion

    public partial class MainForm : Form
    {
        public static List <Car> car_list = new List <Car> ();
        public static string Login = "";

        public MainForm()
        {
            InitializeComponent();

            string[] strs = System.IO.File.ReadAllLines("Cars.txt");
            
            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] {", "}, StringSplitOptions.None);
                car_list.Add(new Car(parts[0], parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), parts[5]));
            }
           
            Text = "Справочник по автомобилям";
            HelloLabel.Visible = false;
            SelectFormBTN.Visible = false;

            #region Отображение объектов на форме
            int x = 30;
            int y = 30;
            for (int i = 0; i < car_list.Count; i++)
            {
                car_list[i].btn.Location = new Point(x, y + 160);
                car_list[i].btn.Size = new Size(230, 30);
                car_list[i].btn.UseVisualStyleBackColor = true;
                car_list[i].btn.Click += new EventHandler(carClick);
                ViewPanel.Controls.Add(car_list[i].btn);

                car_list[i].pic.Location = new Point(x, y);
                car_list[i].pic.Size = new Size(232, 145);
                car_list[i].pic.SizeMode = PictureBoxSizeMode.Zoom;
                ViewPanel.Controls.Add(car_list[i].pic);

                x += 240;
                if (x > this.Size.Width - 150)
                {
                    y += 200;
                    x = 30;
                }
            }
            #endregion
        }

        public static void carClick(object sender, EventArgs e)
        {
            for (int i = 0; i < car_list.Count; i++)
            {
                if(((Button)sender).Text == car_list[i].btn.Text)
                {
                    InfoForm info = new InfoForm(car_list[i]);
                    info.ShowDialog();
                }
            }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            

        }

        private void ViewPanel_Resize(object sender, EventArgs e)
        {
            FindButton_Click(null, null);
        }

        #region Авторизация пользователя
        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (Login == "")
            {
                AuthForm authForm = new AuthForm();
                authForm.ShowDialog();
            }
            else
            {
                Login = "";
            }

            if (Login == "")
            {
                AuthButton.Text = "Войти";
                HelloLabel.Visible = false;
                RegButton.Visible = true;
                SelectFormBTN.Visible = false;
            }
            else
            {
                AuthButton.Text = "Выйти";
                HelloLabel.Visible = true;
                RegButton.Visible = false;
                SelectFormBTN.Visible = true;
                HelloLabel.Text = "Вы авторизовались как " + AuthForm.name + " " + AuthForm.family;
            }            
        }
        #endregion

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm reg = new RegForm();
            reg.ShowDialog();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }

        private void FiltrButton_Click(object sender, EventArgs e)
        {
            if(FiltrPanel.Height > 33)
            {
                FiltrPanel.Height = 33;                
            }
            else
            {
                FiltrPanel.Height = 120;
            }
        }

        #region Фильтр
        private void FindButton_Click(object sender, EventArgs e)
        {
            int x = 30;
            int y = 30;
            for (int i=0; i<car_list.Count; i++)
            {
                car_list[i].btn.Visible = true;
                car_list[i].pic.Visible = true;

                if (kuzovCheckedListBox.CheckedItems.Count>0 &&
                    !kuzovCheckedListBox.CheckedItems.Contains(car_list[i].kuzov))
                {
                    car_list[i].btn.Visible = false;
                    car_list[i].pic.Visible = false;
                }

                if (nameTextBox.Text != "" && !car_list[i].name.Contains(nameTextBox.Text))
                {
                    car_list[i].btn.Visible = false;
                    car_list[i].pic.Visible = false;
                }

                if(kppComboBox.Text != "" && kppComboBox.Text != car_list[i].kpp)
                {
                    car_list[i].btn.Visible = false;
                    car_list[i].pic.Visible = false;
                }

                if (powerComboBox.Text != "" && 
                    Convert.ToInt32(powerComboBox.Text) < car_list[i].power)
                {
                    car_list[i].btn.Visible = false;
                    car_list[i].pic.Visible = false;
                }

                if (priceTextBox.Text != "" &&
                    Convert.ToInt32(priceTextBox.Text) < car_list[i].price)
                {
                    car_list[i].btn.Visible = false;
                    car_list[i].pic.Visible = false;
                }

                if (car_list[i].btn.Visible)
                {
                    car_list[i].btn.Location = new Point(x, y + 160);
                    car_list[i].pic.Location = new Point(x, y);

                    x += 240;
                    if (x > this.Size.Width - 150)
                    {
                        y += 200;
                        x = 30;
                    }
                }               

            }
        }
        #endregion

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                FindButton_Click(null, null);
            }
        }

        private void priceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindButton_Click(null, null);
            }
        }

        private void SelectFormBTN_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.ShowDialog();
        }
    }
}

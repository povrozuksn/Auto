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
    public struct Car
    {
        public string name;
        public string kuzov;
        public string kpp;
        public int power;
        public int price;
        public Button btn;
        public PictureBox pic;

        public Car(string _name, string _kuzov, string _kpp, int _power, int _price)
        {
            name = _name;
            kuzov = _kuzov;
            kpp = _kpp;
            power = _power;
            price = _price;
            btn = new Button();
            pic = new PictureBox();

            btn.Font = new Font("Microsoft Sans Serif", 12F);
            btn.Text = name;

            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Load("../../Pictures/" + name + ".jpg");
        }
    }

    public partial class MainForm : Form
    {
        Car[] car_list = new Car[8];

        public MainForm()
        {
            InitializeComponent();            

            car_list[0] = new Car("Lada Priora", "Хэчбэк", "МКПП", 87, 100000);
            car_list[1] = new Car("Lada Granta", "Седан", "МКПП", 120, 200000);
            car_list[2] = new Car("Lada Vesta", "Седан", "МКПП", 140, 300000);
            car_list[3] = new Car("Lada Xray", "Универсал", "АКПП", 150, 400000);
            car_list[4] = new Car("Kia Rio", "Седан", "АКПП", 180, 500000);
            car_list[5] = new Car("Kia Stinger", "Седан", "АКПП", 180, 500000);
            car_list[6] = new Car("Kia Sportage", "Хэчбэк", "АКПП", 180, 500000);
            car_list[7] = new Car("Kia Karnival", "Универсал", "МКПП", 180, 500000);


            Text = "Справочник по автомобилям";
            HelloLabel.Visible = false;

            int x = 30;
            int y = 30;
            for (int i = 0; i < 8; i++)
            {
                car_list[i].btn.Location = new Point(x, y + 160);
                car_list[i].btn.Size = new Size(230, 30);
                car_list[i].btn.UseVisualStyleBackColor = true;
                car_list[i].btn.Click += new EventHandler(button1_Click);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            InfoForm info = new InfoForm(btn.Text);
            info.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            

        }

        private void ViewPanel_Resize(object sender, EventArgs e)
        {
            MainForm_Load(null, null);
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (AuthForm.Login == "")
            {
                AuthForm authForm = new AuthForm();
                authForm.ShowDialog();
            }
            else
            {
                AuthForm.Login = "";
            }

            if (AuthForm.Login == "")
            {
                AuthButton.Text = "Войти";
                HelloLabel.Visible = false;
            }
            else
            {
                AuthButton.Text = "Выйти";
                HelloLabel.Visible = true;
                HelloLabel.Text = "Вы авторизовались как " + AuthForm.Login;
            }

            
        }

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

        private void FindButton_Click(object sender, EventArgs e)
        {
            int x = 30;
            int y = 30;
            for (int i=0; i<8; i++)
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

                if (kuzovComboBox.Text != "" && kuzovComboBox.Text != car_list[i].kuzov)
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
    }
}

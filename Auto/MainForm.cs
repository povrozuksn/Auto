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
        public MainForm()
        {
            InitializeComponent();

            Car[] car_list = new Car[5];

            car_list[0] = new Car("Lada Priora", "Седан", "МКПП", 87, 100000);
            car_list[1] = new Car("Lada Granta", "Седан", "МКПП", 120, 200000);
            car_list[2] = new Car("Lada Vesta", "Седан", "МКПП", 140, 300000);
            car_list[3] = new Car("Lada Xray", "Универсал", "МКПП", 150, 400000);
            car_list[4] = new Car("Kia Rio", "Седан", "АКПП", 180, 500000);
            

            Text = "Справочник по автомобилям";

            int x = 30;
            int y = 30;
            for(int i=0; i<5; i++)
            {
                car_list[i].btn.Location = new Point(x, y+160);
                car_list[i].btn.Size = new Size(230, 30);
                car_list[i].btn.UseVisualStyleBackColor = true;
                car_list[i].btn.Click += new EventHandler(button1_Click);
                ViewPanel.Controls.Add(car_list[i].btn);

                car_list[i].pic.Location = new Point(x, y);
                car_list[i].pic.Size = new Size(232, 145);
                car_list[i].pic.SizeMode = PictureBoxSizeMode.Zoom;
                ViewPanel.Controls.Add(car_list[i].pic);

                x += 240;
                if(x>900)
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
    }
}

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
    public partial class InfoForm : Form
    {
        public InfoForm(Car car)
        {
            InitializeComponent();

            Text = car.name;
            label1.Text = car.name;

            pictureBox1.Load("../../Pictures/" + car.name + ".jpg");

            KuzovLabel.Text = car.kuzov;
            kppLabel.Text = car.kpp;
            powerLabel.Text = car.power.ToString();
            priceLabel.Text = car.price.ToString();

        }
    }
}

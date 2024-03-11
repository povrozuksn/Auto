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
        Car car;
        public InfoForm(Car _car)
        {
            InitializeComponent();

            car = _car;

            Text = car.name;
            label1.Text = car.name;

            pictureBox1.Load("../../Pictures/" + car.name + ".jpg");

            try
            {
                InfoTextBox.Text = System.IO.File.ReadAllText("../../Pictures/" + car.name + ".txt");
            }
            catch (Exception) { }

            KuzovLabel.Text = car.kuzov;
            kppLabel.Text = car.kpp;
            powerLabel.Text = car.power.ToString();
            priceLabel.Text = car.price.ToString();

        }

        private void AddSelectBTN_Click(object sender, EventArgs e)
        {
            if(SelectForm.my_cars_list.ContainsKey(car))
            {
                SelectForm.my_cars_list[car]++;
            }
            else
            {
                SelectForm.my_cars_list.Add(car, 1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(car.web);
        }
    }
}

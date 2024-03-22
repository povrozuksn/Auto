using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Auto
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            int a;

            if(NameTextBox.Text == "" || KuzovComboBox.Text == "" || KPPComboBox.Text == "" || PowerTextBox.Text == "" || PriceTextBox.Text == "")
            {
                MessageBox.Show("Поля с * обязательны для заполнения");
                return;
            }

            if (!Int32.TryParse(PowerTextBox.Text, out a))
            {
                MessageBox.Show("Мощность НЕ число");
                return;
            }

            if (!Int32.TryParse(PriceTextBox.Text, out a))
            {
                MessageBox.Show("Цена НЕ число");
                return;
            }

            System.IO.File.AppendAllText("Cars.txt",
                                         Environment.NewLine +
                                         NameTextBox.Text + ", " +
                                         KuzovComboBox.Text + ", " +
                                         KPPComboBox.Text + ", " +
                                         PowerTextBox.Text + ", " +
                                         PriceTextBox.Text + ", " +
                                         WebTextBox.Text);

            System.IO.File.AppendAllText("../../Pictures/" + NameTextBox.Text + ".txt", InfoTextBox.Text);

            MessageBox.Show("Объект успешно сохранен");
            Close();
        }
        string FileName = "";
        private void PicButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                CarPictureBox.Load(FileName);
            }
        }
    }
}

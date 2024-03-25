using System;
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
    public partial class DelCarForm : Form
    {
        public DelCarForm()
        {
            InitializeComponent();
            for(int i=0; i<MainForm.car_list.Count; i++)
            {
                comboBox1.Items.Add(MainForm.car_list[i].name);
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            File.Delete("Cars.txt");
            for (int i = 0; i < MainForm.car_list.Count; i++)
            {
                if (comboBox1.Text == MainForm.car_list[i].name)
                {

                }
                else 
                {
                    File.AppendAllText("Cars.txt",
                                        MainForm.car_list[i].name + ", " +
                                        MainForm.car_list[i].kuzov + ", " +
                                        MainForm.car_list[i].kpp + ", " +
                                        MainForm.car_list[i].power + ", " +
                                        MainForm.car_list[i].price + ", " +
                                        MainForm.car_list[i].web + 
                                        Environment.NewLine);
                }
            }
        }
    }
}

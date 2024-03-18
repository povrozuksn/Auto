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
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            System.IO.File.AppendAllText("Cars.txt",
                                         Environment.NewLine +
                                         NameTextBox.Text + ", " +
                                         KuzovTextBox.Text + ", " +
                                         KPPComboBox.Text + ", " +
                                         PowerTextBox.Text + ", " +
                                         PriceTextBox.Text + ", " +
                                         WebTextBox.Text);
        }
    }
}

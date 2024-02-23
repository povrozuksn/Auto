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
    public partial class SelectForm : Form
    {
        public static List<Car> my_cars_list = new List<Car>();

        public SelectForm()
        {
            InitializeComponent();

            int y = 50;
            for(int i=0; i<my_cars_list.Count; i++)
            {
                Car car = my_cars_list[i];

                #region Изображение объекта
                PictureBox pb = new PictureBox();
                pb.Image = car.pic.Image;
                pb.Location = new Point(50, y);
                pb.Size = new Size(232, 145);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(pb);
                #endregion

                #region Название объекта
                Label lbl1 = new Label();
                lbl1.Text = car.name;
                lbl1.Location = new Point(300, y);
                lbl1.Size = new Size(100, 30);
                Controls.Add(lbl1);
                #endregion

                y += 150;
            }
        }
    }
}

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
        public static Dictionary<Car, int> my_cars_list = new Dictionary<Car, int>();

        public SelectForm()
        {
            InitializeComponent();

            int y = 50;
            foreach(KeyValuePair<Car, int> my_car in my_cars_list)
            {
                Car car = my_car.Key;

                #region Изображение объекта
                PictureBox pb = new PictureBox();
                pb.Image = car.pic.Image;
                pb.Location = new Point(50, y);
                pb.Size = new Size(230, 145);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(pb);
                #endregion

                #region Название объекта
                Label lbl1 = new Label();
                lbl1.Text = "Модель - " + car.name;
                lbl1.Location = new Point(300, y);
                lbl1.Size = new Size(300, 30);
                Controls.Add(lbl1);
                #endregion

                #region Тип кузова объекта
                Label lbl2 = new Label();
                lbl2.Text = "Тип кузова - " + car.kuzov;
                lbl2.Location = new Point(600, y);
                lbl2.Size = new Size(300, 30);
                Controls.Add(lbl2);
                #endregion

                #region Тип трансмисии объекта
                Label lbl3 = new Label();
                lbl3.Text = "Тип трансмисии - " + car.kpp;
                lbl3.Location = new Point(600, y+50);
                lbl3.Size = new Size(300, 30);
                Controls.Add(lbl3);
                #endregion

                #region Мощность двигателя объекта
                Label lbl4 = new Label();
                lbl4.Text = "Мощность двигателя - " + car.power + " л.с.";
                lbl4.Location = new Point(600, y + 100);
                lbl4.Size = new Size(300, 30);
                Controls.Add(lbl4);
                #endregion

                #region Цена объекта
                Label lbl5 = new Label();
                lbl5.Text = "Цена: " + car.price;
                lbl5.Location = new Point(900, y);
                lbl5.Size = new Size(300, 30);
                Controls.Add(lbl5);
                #endregion

                #region Количество
                Label lbl6 = new Label();
                lbl6.Text = "Кол: " + my_car.Value + " шт.";
                lbl6.Location = new Point(900, y + 100);
                lbl6.Size = new Size(300, 30);
                Controls.Add(lbl6);
                #endregion

                y += 180;
            }
        }
    }
}

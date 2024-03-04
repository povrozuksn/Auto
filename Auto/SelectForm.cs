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
                lbl5.Size = new Size(200, 30);
                Controls.Add(lbl5);
                #endregion

                #region Количество
                Label lbl6 = new Label();
                lbl6.Text = "Кол, шт.:";
                lbl6.Location = new Point(900, y + 65);
                lbl6.Size = new Size(300, 30);
                Controls.Add(lbl6);

                NumericUpDown numericUpDown1 = new NumericUpDown();
                numericUpDown1.Location = new Point(900, y + 100);
                numericUpDown1.Size = new Size(100, 30);
                numericUpDown1.Value = new decimal(my_car.Value);
                Controls.Add(numericUpDown1);
                #endregion

                #region Кнопка удаления из Избранного
                Button btn1 = new Button();
                btn1.Location = new Point(1100, y);
                btn1.Size = new Size(130, 40);
                btn1.Text = "Удалить";
                btn1.Click += new EventHandler(DeleteClick);
                Controls.Add(btn1);
                #endregion

                y += 180;
            }
        }

        void DeleteClick(object sender, EventArgs e)
        {
            int i = 0;
            Button btn = (Button)sender;
            Dictionary<Car, int> my_cars = new Dictionary<Car, int>();
            foreach(KeyValuePair<Car, int> my_car in my_cars_list)
            {
                Car car = my_car.Key;
                if(btn.Location == new Point(1100, 50+180*i))
                {

                }
                else
                {
                    my_cars[my_car.Key] = my_car.Value;
                }
                i++;
            }
            my_cars_list = my_cars;

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class SendForm : Form
    {
        public SendForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("spravochnik.avtomobilnyy@mail.ru");

            if (AdressTextBox.Text == "")
            {
                MessageBox.Show("Введите адрес эдектронной почты");
            }
            else
            {
                MailAddress to = new MailAddress(AdressTextBox.Text);

                using (MailMessage message = new MailMessage(from, to))

                using (SmtpClient client = new SmtpClient())
                {
                    message.Subject = "Ваш список Избранного";
                    message.Body = "Здравтсвуйте." + Environment.NewLine +
                                    "Мы прислали Вам список выбранных автомоюилей в нашем приложении";
                    message.IsBodyHtml = true;

                    File.AppendAllText("Избранное.csv", "Наименование;Количество;Цена");

                    foreach (KeyValuePair<Car, int> my_car in SelectForm.my_cars_list)
                    {
                        Car car = my_car.Key;
                        File.AppendAllText("Избранное.csv", Environment.NewLine +
                            car.name + ";" + my_car.Value + ";" + car.price);
                    }

                    message.Attachments.Add(new Attachment("Избранное.csv"));

                    client.Host = "smtp.mail.ru";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(from.Address, "9cJZEsHSedCNRgxXan4d");
                    client.Send(message);
                }

                MessageBox.Show("Письмо отправлено");
                Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class FeedBackForm : Form
    {
        public FeedBackForm()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("spravochnik.avtomobilnyy@mail.ru");

            if (subjectСomboBox.Text == "")
            {
                MessageBox.Show("Выберите тему сообщения");
            }
            else
            { 
                MailAddress to = new MailAddress("spravochnik.avtomobilnyy@mail.ru");

                using (MailMessage message = new MailMessage(from, to))

                using (SmtpClient client = new SmtpClient())
                {
                    message.Subject = subjectСomboBox.Text;
                    message.Body = BodyTextBox.Text;
                    message.IsBodyHtml = true;

                    client.Host = "smtp.mail.ru";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(from.Address, "9cJZEsHSedCNRgxXan4d");
                    client.Send(message);
                }

                MessageBox.Show("Сообщение отправлено");
                Close();
            }

        }
    }
}

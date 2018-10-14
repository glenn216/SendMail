#region Apache License
//  Copyright 2018 Glenn Alon
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
#endregion

using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Net;
using System.Net.Mail;

namespace SendMail
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var fromAddress = new MailAddress(textBox2.Text, textBox1.Text);
                var toAddress = new MailAddress(textBox5.Text, textBox4.Text);
                string fromPassword = textBox3.Text;
                string subject = textBox6.Text;
                string body = richTextBox1.Text;

                var smtp = new SmtpClient
                {

                    Host = textBox7.Text,
                    Port = Convert.ToInt32(textBox8.Text),
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Message Sent");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                var fromAddress = new MailAddress(textBox2.Text, textBox1.Text);
                var toAddress = new MailAddress(textBox5.Text, textBox4.Text);
                string fromPassword = textBox3.Text;
                string subject = textBox6.Text;
                string body = richTextBox1.Text;

                var smtp = new SmtpClient
                {

                    Host = textBox7.Text,
                    Port = Convert.ToInt32(textBox8.Text),
                    EnableSsl = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Message Sent");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}

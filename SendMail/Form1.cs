#region Apache License

//  Copyright 2018-2020 Glenn Alon
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

#endregion Apache License

using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

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

        private void sendMail_Click(object sender, EventArgs e)
        {
            if (yesRadio.Checked)
            {
                var fromAddress = new MailAddress(senderEmail.Text, senderName.Text);
                var toAddress = new MailAddress(reciEmail.Text, reciName.Text);
                string fromPassword = senderPass.Text;
                string subject = this.subjectText.Text;
                string body = bodyRichTB.Text;

                var smtp = new SmtpClient
                {
                    Host = smtpHost.Text,
                    Port = Convert.ToInt32(smtpPort.Text),
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
                        if (htmlCheck.Checked == true)
                        {
                            message.IsBodyHtml = true;
                            if (attach.Text == null)
                            {
                            }
                            else
                            {
                                Attachment attachment;
                                attachment = new Attachment(attach.Text);
                                message.Attachments.Add(attachment);
                            }
                            smtp.Send(message);
                            MessageBox.Show("Message Sent", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            message.IsBodyHtml = false;
                            if (attach.Text == null)
                            {
                            }
                            else
                            {
                                Attachment attachment;
                                attachment = new Attachment(attach.Text);
                                message.Attachments.Add(attachment);
                            }
                            smtp.Send(message);
                            MessageBox.Show("Message Sent", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else
            {
                var fromAddress = new MailAddress(senderEmail.Text, senderName.Text);
                var toAddress = new MailAddress(reciEmail.Text, reciName.Text);
                string fromPassword = senderPass.Text;
                string subject = this.subjectText.Text;
                string body = bodyRichTB.Text;

                var smtp = new SmtpClient
                {
                    Host = smtpHost.Text,
                    Port = Convert.ToInt32(smtpPort.Text),
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
                        if (htmlCheck.Checked == true)
                        {
                            message.IsBodyHtml = true;
                            if (attach.Text == null)
                            {
                            }
                            else
                            {
                                Attachment attachment;
                                attachment = new Attachment(attach.Text);
                                message.Attachments.Add(attachment);
                            }
                            smtp.Send(message);
                            MessageBox.Show("Message Sent", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            message.IsBodyHtml = false;
                            if (attach.Text == null)
                            {
                            }
                            else
                            {
                                Attachment attachment;
                                attachment = new Attachment(attach.Text);
                                message.Attachments.Add(attachment);
                            }
                            smtp.Send(message);
                            MessageBox.Show("Message Sent", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                attach.Text = file;
            }
        }
    }
}
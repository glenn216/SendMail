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
    public partial class SendMail : MaterialForm
    {
        string attachmentFile1 { get; set; }
        string attachmentFile2 { get; set; }
        string attachmentFile3 { get; set; }

        public bool Attachment1 = false;
        public bool Attachment2 = false;
        public bool Attachment3 = false;

        public SendMail()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            button2.Enabled = false;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            var fromAddress = new MailAddress(senderEmail.Text, senderName.Text);
            var toAddress = new MailAddress(reciEmail.Text, reciName.Text);
            string fromPassword = senderPass.Text;
            string subject = this.subjectText.Text;
            string body = bodyRichTB.Text;
            Attachment attachment1;
            Attachment attachment2;
            Attachment attachment3;

            var smtp = new SmtpClient
            {
                Host = smtpHost.Text,
                Port = Convert.ToInt32(smtpPort.Text),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
                Priority = MailPriority.High
            })


                if (enableSSL.Checked && htmlCheck.Checked == true)
                {
                    {
                        try
                        {
                            smtp.EnableSsl = true;
                            {
                                message.IsBodyHtml = true;

                                if (attachCheck1.Checked == true)
                                {
                                    attachment1 = new Attachment(attachmentFile1);
                                    message.Attachments.Add(attachment1);
                                }

                                if (attachCheck2.Checked == true)
                                {
                                    attachment2 = new Attachment(attachmentFile2);
                                    message.Attachments.Add(attachment2);
                                }

                                if (attachCheck3.Checked == true)
                                {
                                    attachment3 = new Attachment(attachmentFile3);
                                    message.Attachments.Add(attachment3);
                                }

                                progressBar1.Minimum = 1;
                                progressBar1.Maximum = 100000;
                                progressBar1.Value = 1;
                                progressBar1.Step = 1;
                                progressBar1.Visible = true;
                                for (int x = 1; x <= 100000; x++)
                                {
                                    progressBar1.PerformStep();
                                }

                                smtp.Send(message);
                                MessageBox.Show("Message Sent", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                progressBar1.Visible = false;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            progressBar1.Visible = false;
                        }
                    }
                }

                else if (enableSSL.Checked && htmlCheck.Checked == false)
                {
                    {
                        try
                        {
                            smtp.EnableSsl = true;
                            {
                                message.IsBodyHtml = false;

                                if (attachCheck1.Checked == true)
                                {
                                    attachment1 = new Attachment(attachmentFile1);
                                    message.Attachments.Add(attachment1);
                                }

                                if (attachCheck2.Checked == true)
                                {
                                    attachment2 = new Attachment(attachmentFile2);
                                    message.Attachments.Add(attachment2);
                                }

                                if (attachCheck3.Checked == true)
                                {
                                    attachment3 = new Attachment(attachmentFile3);
                                    message.Attachments.Add(attachment3);
                                }

                                progressBar1.Minimum = 1;
                                progressBar1.Maximum = 100000;
                                progressBar1.Value = 1;
                                progressBar1.Step = 1;
                                progressBar1.Visible = true;
                                for (int x = 1; x <= 100000; x++)
                                {
                                    progressBar1.PerformStep();
                                }

                                smtp.Send(message);
                                MessageBox.Show("Message Sent", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                progressBar1.Visible = false;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            progressBar1.Visible = false;

                        }
                    }
                }

                else if (disableSSL.Checked && htmlCheck.Checked == true)
                {
                    {
                        try
                        {
                            smtp.EnableSsl = false;
                            {
                                message.IsBodyHtml = true;

                                if (attachCheck1.Checked == true)
                                {
                                    attachment1 = new Attachment(attachmentFile1);
                                    message.Attachments.Add(attachment1);
                                }

                                if (attachCheck2.Checked == true)
                                {
                                    attachment2 = new Attachment(attachmentFile2);
                                    message.Attachments.Add(attachment2);
                                }

                                if (attachCheck3.Checked == true)
                                {
                                    attachment3 = new Attachment(attachmentFile3);
                                    message.Attachments.Add(attachment3);
                                }

                                progressBar1.Minimum = 1;
                                progressBar1.Maximum = 100000;
                                progressBar1.Value = 1;
                                progressBar1.Step = 1;
                                progressBar1.Visible = true;
                                for (int x = 1; x <= 100000; x++)
                                {
                                    progressBar1.PerformStep();
                                }

                                smtp.Send(message);
                                MessageBox.Show("Message Sent", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                progressBar1.Visible = false;
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            progressBar1.Visible = false;
                        }
                    }
                }

                else if (disableSSL.Checked && htmlCheck.Checked == false)
                {
                    {
                        try
                        {
                            smtp.EnableSsl = false;
                            {
                                message.IsBodyHtml = false;

                                if (attachCheck1.Checked == true)
                                {
                                    attachment1 = new Attachment(attachmentFile1);
                                    message.Attachments.Add(attachment1);
                                }

                                if (attachCheck2.Checked == true)
                                {
                                    attachment2 = new Attachment(attachmentFile2);
                                    message.Attachments.Add(attachment2);
                                }

                                if (attachCheck3.Checked == true)
                                {
                                    attachment3 = new Attachment(attachmentFile3);
                                    message.Attachments.Add(attachment3);
                                }

                                progressBar1.Minimum = 1;
                                progressBar1.Maximum = 100000;
                                progressBar1.Value = 1;
                                progressBar1.Step = 1;
                                progressBar1.Visible = true;
                                for (int x = 1; x <= 100000; x++)
                                {
                                    progressBar1.PerformStep();
                                }

                                smtp.Send(message);
                                MessageBox.Show("Message Sent", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                progressBar1.Visible = false;
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            progressBar1.Visible = false;
                        }
                    }
                }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                attach.Text = openFileDialog1.FileName;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            senderPass.PasswordChar = '\0';
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            senderPass.PasswordChar = '•';
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {     
            if (Attachment1 == false && Attachment2 == false && Attachment3 == false)
            {
                attachmentFile1 = attach.Text;
                Attachment1 = true;
                attachCheck1.Checked = true;
                attachCheck1.Enabled = true;
                attach.Text = "";
            }

            else if (Attachment1 == true && Attachment2 == false && Attachment3 == false)
            {
                attachmentFile2 = attach.Text;
                Attachment2 = true;
                attachCheck2.Checked = true;
                attachCheck2.Enabled = true;
                attach.Text = "";
            }

            else if (Attachment1 == true && Attachment2 == true && Attachment3 == false)
            {
                attachmentFile3 = attach.Text;
                Attachment3 = true;
                attachCheck3.Checked = true;
                attachCheck3.Enabled = true;
                attach.Text = "";
            }

            else if (Attachment1 == true && Attachment2 == true && Attachment3 == true)
            {
                MessageBox.Show("Attachment is full. Click 'Clear All' button to reset attachments.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                attach.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            attachmentFile1 = null;
            attachmentFile2 = null;
            attachmentFile3 = null;
            attachCheck1.Checked = false;
            attachCheck1.Enabled = false;
            attachCheck2.Checked = false;
            attachCheck2.Enabled = false;
            attachCheck3.Checked = false;
            attachCheck3.Enabled = false;
            Attachment1 = false;
            Attachment2 = false;
            Attachment3 = false;
        }
    }
}
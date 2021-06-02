#region Apache License

//  Copyright 2018-2021 Glenn Alon
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
        string AttachmentFile1 { get; set; }
        string AttachmentFile2 { get; set; }
        string AttachmentFile3 { get; set; }

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

            hideBtn.Enabled = false;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            var fromAddress = new MailAddress(senderEmailTxt.Text, senderNameTxt.Text);
            var toAddress = new MailAddress(recEmailTxt.Text, recNameTxt.Text);
            string fromPassword = senderPasswordTxt.Text;
            string subject = this.subjectTxt.Text;
            string body = bodyRichTB.Text;

            Attachment attachment1;
            Attachment attachment2;
            Attachment attachment3;

            var smtp = new SmtpClient
            {
                Host = smtpHostTxt.Text,
                Port = Convert.ToInt32(smtpPortTxt.Text),
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
            {
                if (enableSSLBtn.Checked && htmlCheckBox.Checked)
                {
                    {
                        try
                        {
                            smtp.EnableSsl = true;
                            {
                                message.IsBodyHtml = true;

                                if (attFileCheckBox1.Checked)
                                {
                                    attachment1 = new Attachment(AttachmentFile1);
                                    message.Attachments.Add(attachment1);
                                }

                                if (attFileCheckBox2.Checked)
                                {
                                    attachment2 = new Attachment(AttachmentFile2);
                                    message.Attachments.Add(attachment2);
                                }

                                if (attFileCheckBox3.Checked)
                                {
                                    attachment3 = new Attachment(AttachmentFile3);
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

                else if (enableSSLBtn.Checked && !htmlCheckBox.Checked)
                {
                    {
                        try
                        {
                            smtp.EnableSsl = true;
                            {
                                message.IsBodyHtml = false;

                                if (attFileCheckBox1.Checked)
                                {
                                    attachment1 = new Attachment(AttachmentFile1);
                                    message.Attachments.Add(attachment1);
                                }

                                if (attFileCheckBox2.Checked)
                                {
                                    attachment2 = new Attachment(AttachmentFile2);
                                    message.Attachments.Add(attachment2);
                                }

                                if (attFileCheckBox3.Checked)
                                {
                                    attachment3 = new Attachment(AttachmentFile3);
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

                else if (disableSSLBtn.Checked && htmlCheckBox.Checked)
                {
                    {
                        try
                        {
                            smtp.EnableSsl = false;
                            {
                                message.IsBodyHtml = true;

                                if (attFileCheckBox1.Checked)
                                {
                                    attachment1 = new Attachment(AttachmentFile1);
                                    message.Attachments.Add(attachment1);
                                }

                                if (attFileCheckBox2.Checked)
                                {
                                    attachment2 = new Attachment(AttachmentFile2);
                                    message.Attachments.Add(attachment2);
                                }

                                if (attFileCheckBox3.Checked)
                                {
                                    attachment3 = new Attachment(AttachmentFile3);
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

                else if (disableSSLBtn.Checked && !htmlCheckBox.Checked)
                {
                    {
                        try
                        {
                            smtp.EnableSsl = false;
                            {
                                message.IsBodyHtml = false;

                                if (attFileCheckBox1.Checked)
                                {
                                    attachment1 = new Attachment(AttachmentFile1);
                                    message.Attachments.Add(attachment1);
                                }

                                if (attFileCheckBox2.Checked)
                                {
                                    attachment2 = new Attachment(AttachmentFile2);
                                    message.Attachments.Add(attachment2);
                                }

                                if (attFileCheckBox3.Checked)
                                {
                                    attachment3 = new Attachment(AttachmentFile3);
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
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                attach.Text = openFileDialog1.FileName;
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            senderPasswordTxt.PasswordChar = '\0';
            hideBtn.Enabled = true;
            showBtn.Enabled = false;
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            senderPasswordTxt.PasswordChar = '•';
            hideBtn.Enabled = false;
            showBtn.Enabled = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            switch (Attachment1)
            {
                case false when Attachment2 == false && Attachment3 == false:
                    AttachmentFile1 = attach.Text;
                    Attachment1 = true;
                    attFileCheckBox1.Checked = true;
                    attFileCheckBox1.Enabled = true;
                    attach.Text = "";
                    break;

                case true when Attachment2 == false && Attachment3 == false:
                    AttachmentFile2 = attach.Text;
                    Attachment2 = true;
                    attFileCheckBox2.Checked = true;
                    attFileCheckBox2.Enabled = true;
                    attach.Text = "";
                    break;

                case true when Attachment2 == true && Attachment3 == false:
                    AttachmentFile3 = attach.Text;
                    Attachment3 = true;
                    attFileCheckBox3.Checked = true;
                    attFileCheckBox3.Enabled = true;
                    attach.Text = "";
                    break;

                case true when Attachment2 == true && Attachment3 == true:
                    MessageBox.Show("Attachment is full. Click 'Clear All' button to reset attachments.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    attach.Text = "";
                    break;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            AttachmentFile1 = null;
            AttachmentFile2 = null;
            AttachmentFile3 = null;
            attFileCheckBox1.Checked = false;
            attFileCheckBox1.Enabled = false;
            attFileCheckBox2.Checked = false;
            attFileCheckBox2.Enabled = false;
            attFileCheckBox3.Checked = false;
            attFileCheckBox3.Enabled = false;
            Attachment1 = false;
            Attachment2 = false;
            Attachment3 = false;
        }
    }
}
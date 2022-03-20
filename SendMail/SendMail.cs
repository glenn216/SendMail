#region Apache License

//  Copyright 2018-2022 Glenn Alon
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
using System.Threading.Tasks;
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
            _ = sendMail();
        }

        protected async Task sendMail()
        {
            var fromAddress = new MailAddress(senderEmailTxt.Text, senderNameTxt.Text);
            var toAddress = new MailAddress(recEmailTxt.Text, recNameTxt.Text);
            string fromPassword = senderPasswordTxt.Text;
            string subject = this.subjectTxt.Text;
            string body = bodyRichTB.Text;
            Attachment attachment1;
            Attachment attachment2;
            Attachment attachment3;
            await Task.Run(() =>
            {
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
                    Body = body
                })
                    try
                    {
                        smtp.EnableSsl = SSL(enableSSLBtn);
                        {
                            message.IsBodyHtml = HTML(htmlCheckBox);

                            switch (attFileCheckBox1.Checked)
                            {
                                case true:
                                    {
                                        attachment1 = new Attachment(AttachmentFile1);
                                        message.Attachments.Add(attachment1);
                                        break;
                                    }
                                case false:
                                    break;
                                default:
                                    break;
                            }

                            switch (attFileCheckBox2.Checked)
                            {
                                case true:
                                    {
                                        attachment2 = new Attachment(AttachmentFile2);
                                        message.Attachments.Add(attachment2);
                                        break;
                                    }
                                case false:
                                    break;
                                default:
                                    break;
                            }

                            switch (attFileCheckBox3.Checked)
                            {
                                case true:
                                    {
                                        attachment3 = new Attachment(AttachmentFile3);
                                        message.Attachments.Add(attachment3);
                                        break;
                                    }
                                case false:
                                    break;
                                default:
                                    break;
                            }

                            smtp.Send(message);
                            _ = MessageBox.Show("Message Sent", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            message.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        _ = MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        message.Dispose();
                    }
            });
        }

        protected bool SSL(RadioButton radioButton1)
        {
            switch (radioButton1.Checked)
            {
                case true:
                    return true;
                default:
                    return false;
            }
        }

        protected bool HTML(CheckBox checkBox)
        {
            switch (checkBox.Checked)
            {
                case true:
                    return true;
                default:
                    return false;
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
                default:
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
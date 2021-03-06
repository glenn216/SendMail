﻿#region Apache License

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

#endregion


namespace SendMail
{
    partial class SendMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.senderPass = new System.Windows.Forms.TextBox();
            this.senderEmail = new System.Windows.Forms.TextBox();
            this.senderName = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reciEmail = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.reciName = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.htmlCheck = new System.Windows.Forms.CheckBox();
            this.subjectText = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.disableSSL = new System.Windows.Forms.RadioButton();
            this.enableSSL = new System.Windows.Forms.RadioButton();
            this.smtpPort = new System.Windows.Forms.TextBox();
            this.smtpHost = new System.Windows.Forms.TextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bodyRichTB = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.attachCheck3 = new System.Windows.Forms.CheckBox();
            this.attachCheck2 = new System.Windows.Forms.CheckBox();
            this.attachCheck1 = new System.Windows.Forms.CheckBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.attach = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.senderPass);
            this.groupBox1.Controls.Add(this.senderEmail);
            this.groupBox1.Controls.Add(this.senderName);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sender Details";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Hide";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // senderPass
            // 
            this.senderPass.Location = new System.Drawing.Point(133, 86);
            this.senderPass.Name = "senderPass";
            this.senderPass.PasswordChar = '•';
            this.senderPass.Size = new System.Drawing.Size(179, 20);
            this.senderPass.TabIndex = 5;
            // 
            // senderEmail
            // 
            this.senderEmail.Location = new System.Drawing.Point(133, 60);
            this.senderEmail.Name = "senderEmail";
            this.senderEmail.Size = new System.Drawing.Size(179, 20);
            this.senderEmail.TabIndex = 4;
            // 
            // senderName
            // 
            this.senderName.Location = new System.Drawing.Point(133, 32);
            this.senderName.Name = "senderName";
            this.senderName.Size = new System.Drawing.Size(179, 20);
            this.senderName.TabIndex = 3;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(0, 87);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(129, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Sender Password:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(22, 61);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(105, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Sender E-mail:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(24, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(103, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Sender Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reciEmail);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(this.reciName);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 89);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recipient Details";
            // 
            // reciEmail
            // 
            this.reciEmail.Location = new System.Drawing.Point(131, 57);
            this.reciEmail.Name = "reciEmail";
            this.reciEmail.Size = new System.Drawing.Size(179, 20);
            this.reciEmail.TabIndex = 8;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(4, 56);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(121, 19);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Recipient E-mail:";
            // 
            // reciName
            // 
            this.reciName.Location = new System.Drawing.Point(131, 26);
            this.reciName.Name = "reciName";
            this.reciName.Size = new System.Drawing.Size(179, 20);
            this.reciName.TabIndex = 6;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 26);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(119, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Recipient Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.htmlCheck);
            this.groupBox3.Controls.Add(this.subjectText);
            this.groupBox3.Controls.Add(this.materialLabel6);
            this.groupBox3.Location = new System.Drawing.Point(12, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 69);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "E-mail Details";
            // 
            // htmlCheck
            // 
            this.htmlCheck.AutoSize = true;
            this.htmlCheck.Location = new System.Drawing.Point(66, 42);
            this.htmlCheck.Name = "htmlCheck";
            this.htmlCheck.Size = new System.Drawing.Size(91, 17);
            this.htmlCheck.TabIndex = 10;
            this.htmlCheck.Text = "HTML Format";
            this.htmlCheck.UseVisualStyleBackColor = true;
            // 
            // subjectText
            // 
            this.subjectText.Location = new System.Drawing.Point(131, 19);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(179, 20);
            this.subjectText.TabIndex = 9;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(62, 20);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(63, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Subject:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.disableSSL);
            this.groupBox4.Controls.Add(this.enableSSL);
            this.groupBox4.Controls.Add(this.smtpPort);
            this.groupBox4.Controls.Add(this.smtpHost);
            this.groupBox4.Controls.Add(this.materialLabel9);
            this.groupBox4.Controls.Add(this.materialLabel8);
            this.groupBox4.Controls.Add(this.materialLabel7);
            this.groupBox4.Location = new System.Drawing.Point(12, 390);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 125);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SMTP Details";
            // 
            // disableSSL
            // 
            this.disableSSL.AutoSize = true;
            this.disableSSL.Location = new System.Drawing.Point(179, 88);
            this.disableSSL.Name = "disableSSL";
            this.disableSSL.Size = new System.Drawing.Size(39, 17);
            this.disableSSL.TabIndex = 13;
            this.disableSSL.Text = "No";
            this.disableSSL.UseVisualStyleBackColor = true;
            // 
            // enableSSL
            // 
            this.enableSSL.AutoSize = true;
            this.enableSSL.Checked = true;
            this.enableSSL.Location = new System.Drawing.Point(130, 88);
            this.enableSSL.Name = "enableSSL";
            this.enableSSL.Size = new System.Drawing.Size(43, 17);
            this.enableSSL.TabIndex = 12;
            this.enableSSL.TabStop = true;
            this.enableSSL.Text = "Yes";
            this.enableSSL.UseVisualStyleBackColor = true;
            // 
            // smtpPort
            // 
            this.smtpPort.Location = new System.Drawing.Point(130, 58);
            this.smtpPort.Name = "smtpPort";
            this.smtpPort.Size = new System.Drawing.Size(179, 20);
            this.smtpPort.TabIndex = 11;
            this.smtpPort.Text = "587";
            // 
            // smtpHost
            // 
            this.smtpHost.Location = new System.Drawing.Point(130, 30);
            this.smtpHost.Name = "smtpHost";
            this.smtpHost.Size = new System.Drawing.Size(179, 20);
            this.smtpHost.TabIndex = 10;
            this.smtpHost.Text = "smtp.gmail.com";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(11, 88);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(91, 19);
            this.materialLabel9.TabIndex = 2;
            this.materialLabel9.Text = "Enable SSL?";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(61, 59);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(41, 19);
            this.materialLabel8.TabIndex = 1;
            this.materialLabel8.Text = "Port:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(56, 31);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(46, 19);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Host:";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.bodyRichTB);
            this.groupBox5.Location = new System.Drawing.Point(336, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(676, 517);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "E-mail Body";
            // 
            // bodyRichTB
            // 
            this.bodyRichTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyRichTB.Location = new System.Drawing.Point(7, 20);
            this.bodyRichTB.Name = "bodyRichTB";
            this.bodyRichTB.Size = new System.Drawing.Size(663, 491);
            this.bodyRichTB.TabIndex = 0;
            this.bodyRichTB.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(937, 597);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 10;
            this.sendButton.Text = "SendMail";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.Send_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.attachCheck3);
            this.groupBox6.Controls.Add(this.attachCheck2);
            this.groupBox6.Controls.Add(this.attachCheck1);
            this.groupBox6.Controls.Add(this.browseButton);
            this.groupBox6.Controls.Add(this.attach);
            this.groupBox6.Location = new System.Drawing.Point(12, 521);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(318, 99);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Attachment";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(6, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Clear All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(235, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // attachCheck3
            // 
            this.attachCheck3.AutoSize = true;
            this.attachCheck3.Enabled = false;
            this.attachCheck3.Location = new System.Drawing.Point(210, 19);
            this.attachCheck3.Name = "attachCheck3";
            this.attachCheck3.Size = new System.Drawing.Size(89, 17);
            this.attachCheck3.TabIndex = 13;
            this.attachCheck3.Text = "Attachment 3";
            this.attachCheck3.UseVisualStyleBackColor = true;
            // 
            // attachCheck2
            // 
            this.attachCheck2.AutoSize = true;
            this.attachCheck2.Enabled = false;
            this.attachCheck2.Location = new System.Drawing.Point(115, 19);
            this.attachCheck2.Name = "attachCheck2";
            this.attachCheck2.Size = new System.Drawing.Size(89, 17);
            this.attachCheck2.TabIndex = 12;
            this.attachCheck2.Text = "Attachment 2";
            this.attachCheck2.UseVisualStyleBackColor = true;
            // 
            // attachCheck1
            // 
            this.attachCheck1.AutoSize = true;
            this.attachCheck1.Enabled = false;
            this.attachCheck1.Location = new System.Drawing.Point(20, 19);
            this.attachCheck1.Name = "attachCheck1";
            this.attachCheck1.Size = new System.Drawing.Size(89, 17);
            this.attachCheck1.TabIndex = 11;
            this.attachCheck1.Text = "Attachment 1";
            this.attachCheck1.UseVisualStyleBackColor = true;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(235, 40);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // attach
            // 
            this.attach.Location = new System.Drawing.Point(8, 43);
            this.attach.Name = "attach";
            this.attach.Size = new System.Drawing.Size(223, 20);
            this.attach.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(786, 597);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(145, 23);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Visible = false;
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 632);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "SendMail";
            this.Sizable = false;
            this.Text = "SendMail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox senderPass;
        private System.Windows.Forms.TextBox senderEmail;
        private System.Windows.Forms.TextBox senderName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox reciEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TextBox reciName;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox subjectText;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton disableSSL;
        private System.Windows.Forms.RadioButton enableSSL;
        private System.Windows.Forms.TextBox smtpPort;
        private System.Windows.Forms.TextBox smtpHost;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox bodyRichTB;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.CheckBox htmlCheck;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox attach;
        private System.Windows.Forms.CheckBox attachCheck1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox attachCheck3;
        private System.Windows.Forms.CheckBox attachCheck2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}


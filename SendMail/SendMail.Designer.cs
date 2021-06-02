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
            this.hideBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.senderPasswordTxt = new System.Windows.Forms.TextBox();
            this.senderEmailTxt = new System.Windows.Forms.TextBox();
            this.senderNameTxt = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.recEmailTxt = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.recNameTxt = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.htmlCheckBox = new System.Windows.Forms.CheckBox();
            this.subjectTxt = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.disableSSLBtn = new System.Windows.Forms.RadioButton();
            this.enableSSLBtn = new System.Windows.Forms.RadioButton();
            this.smtpPortTxt = new System.Windows.Forms.TextBox();
            this.smtpHostTxt = new System.Windows.Forms.TextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bodyRichTB = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.attFileCheckBox3 = new System.Windows.Forms.CheckBox();
            this.attFileCheckBox2 = new System.Windows.Forms.CheckBox();
            this.attFileCheckBox1 = new System.Windows.Forms.CheckBox();
            this.browseBtn = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.hideBtn);
            this.groupBox1.Controls.Add(this.showBtn);
            this.groupBox1.Controls.Add(this.senderPasswordTxt);
            this.groupBox1.Controls.Add(this.senderEmailTxt);
            this.groupBox1.Controls.Add(this.senderNameTxt);
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
            // hideBtn
            // 
            this.hideBtn.Location = new System.Drawing.Point(234, 113);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(75, 23);
            this.hideBtn.TabIndex = 7;
            this.hideBtn.Text = "Hide";
            this.hideBtn.UseVisualStyleBackColor = true;
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(153, 113);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(75, 23);
            this.showBtn.TabIndex = 6;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // senderPasswordTxt
            // 
            this.senderPasswordTxt.Location = new System.Drawing.Point(133, 86);
            this.senderPasswordTxt.Name = "senderPasswordTxt";
            this.senderPasswordTxt.PasswordChar = '•';
            this.senderPasswordTxt.Size = new System.Drawing.Size(179, 20);
            this.senderPasswordTxt.TabIndex = 5;
            // 
            // senderEmailTxt
            // 
            this.senderEmailTxt.Location = new System.Drawing.Point(133, 60);
            this.senderEmailTxt.Name = "senderEmailTxt";
            this.senderEmailTxt.Size = new System.Drawing.Size(179, 20);
            this.senderEmailTxt.TabIndex = 4;
            // 
            // senderNameTxt
            // 
            this.senderNameTxt.Location = new System.Drawing.Point(133, 32);
            this.senderNameTxt.Name = "senderNameTxt";
            this.senderNameTxt.Size = new System.Drawing.Size(179, 20);
            this.senderNameTxt.TabIndex = 3;
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
            this.groupBox2.Controls.Add(this.recEmailTxt);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(this.recNameTxt);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 89);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recipient Details";
            // 
            // recEmailTxt
            // 
            this.recEmailTxt.Location = new System.Drawing.Point(131, 57);
            this.recEmailTxt.Name = "recEmailTxt";
            this.recEmailTxt.Size = new System.Drawing.Size(179, 20);
            this.recEmailTxt.TabIndex = 8;
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
            // recNameTxt
            // 
            this.recNameTxt.Location = new System.Drawing.Point(131, 26);
            this.recNameTxt.Name = "recNameTxt";
            this.recNameTxt.Size = new System.Drawing.Size(179, 20);
            this.recNameTxt.TabIndex = 6;
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
            this.groupBox3.Controls.Add(this.htmlCheckBox);
            this.groupBox3.Controls.Add(this.subjectTxt);
            this.groupBox3.Controls.Add(this.materialLabel6);
            this.groupBox3.Location = new System.Drawing.Point(12, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 69);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "E-mail Details";
            // 
            // htmlCheckBox
            // 
            this.htmlCheckBox.AutoSize = true;
            this.htmlCheckBox.Location = new System.Drawing.Point(66, 42);
            this.htmlCheckBox.Name = "htmlCheckBox";
            this.htmlCheckBox.Size = new System.Drawing.Size(91, 17);
            this.htmlCheckBox.TabIndex = 10;
            this.htmlCheckBox.Text = "HTML Format";
            this.htmlCheckBox.UseVisualStyleBackColor = true;
            // 
            // subjectTxt
            // 
            this.subjectTxt.Location = new System.Drawing.Point(131, 19);
            this.subjectTxt.Name = "subjectTxt";
            this.subjectTxt.Size = new System.Drawing.Size(179, 20);
            this.subjectTxt.TabIndex = 9;
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
            this.groupBox4.Controls.Add(this.disableSSLBtn);
            this.groupBox4.Controls.Add(this.enableSSLBtn);
            this.groupBox4.Controls.Add(this.smtpPortTxt);
            this.groupBox4.Controls.Add(this.smtpHostTxt);
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
            // disableSSLBtn
            // 
            this.disableSSLBtn.AutoSize = true;
            this.disableSSLBtn.Location = new System.Drawing.Point(179, 88);
            this.disableSSLBtn.Name = "disableSSLBtn";
            this.disableSSLBtn.Size = new System.Drawing.Size(39, 17);
            this.disableSSLBtn.TabIndex = 13;
            this.disableSSLBtn.Text = "No";
            this.disableSSLBtn.UseVisualStyleBackColor = true;
            // 
            // enableSSLBtn
            // 
            this.enableSSLBtn.AutoSize = true;
            this.enableSSLBtn.Checked = true;
            this.enableSSLBtn.Location = new System.Drawing.Point(130, 88);
            this.enableSSLBtn.Name = "enableSSLBtn";
            this.enableSSLBtn.Size = new System.Drawing.Size(43, 17);
            this.enableSSLBtn.TabIndex = 12;
            this.enableSSLBtn.TabStop = true;
            this.enableSSLBtn.Text = "Yes";
            this.enableSSLBtn.UseVisualStyleBackColor = true;
            // 
            // smtpPortTxt
            // 
            this.smtpPortTxt.Location = new System.Drawing.Point(130, 58);
            this.smtpPortTxt.Name = "smtpPortTxt";
            this.smtpPortTxt.Size = new System.Drawing.Size(179, 20);
            this.smtpPortTxt.TabIndex = 11;
            this.smtpPortTxt.Text = "465";
            // 
            // smtpHostTxt
            // 
            this.smtpHostTxt.Location = new System.Drawing.Point(130, 30);
            this.smtpHostTxt.Name = "smtpHostTxt";
            this.smtpHostTxt.Size = new System.Drawing.Size(179, 20);
            this.smtpHostTxt.TabIndex = 10;
            this.smtpHostTxt.Text = "smtp.server.com";
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
            // sendBtn
            // 
            this.sendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn.Location = new System.Drawing.Point(937, 597);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 10;
            this.sendBtn.Text = "SendMail";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.clearBtn);
            this.groupBox6.Controls.Add(this.addBtn);
            this.groupBox6.Controls.Add(this.attFileCheckBox3);
            this.groupBox6.Controls.Add(this.attFileCheckBox2);
            this.groupBox6.Controls.Add(this.attFileCheckBox1);
            this.groupBox6.Controls.Add(this.browseBtn);
            this.groupBox6.Controls.Add(this.attach);
            this.groupBox6.Location = new System.Drawing.Point(12, 521);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(318, 99);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Attachment";
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearBtn.Location = new System.Drawing.Point(6, 69);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "Clear All";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addBtn.Location = new System.Drawing.Point(235, 70);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // attFileCheckBox3
            // 
            this.attFileCheckBox3.AutoSize = true;
            this.attFileCheckBox3.Enabled = false;
            this.attFileCheckBox3.Location = new System.Drawing.Point(210, 19);
            this.attFileCheckBox3.Name = "attFileCheckBox3";
            this.attFileCheckBox3.Size = new System.Drawing.Size(89, 17);
            this.attFileCheckBox3.TabIndex = 13;
            this.attFileCheckBox3.Text = "Attachment 3";
            this.attFileCheckBox3.UseVisualStyleBackColor = true;
            // 
            // attFileCheckBox2
            // 
            this.attFileCheckBox2.AutoSize = true;
            this.attFileCheckBox2.Enabled = false;
            this.attFileCheckBox2.Location = new System.Drawing.Point(115, 19);
            this.attFileCheckBox2.Name = "attFileCheckBox2";
            this.attFileCheckBox2.Size = new System.Drawing.Size(89, 17);
            this.attFileCheckBox2.TabIndex = 12;
            this.attFileCheckBox2.Text = "Attachment 2";
            this.attFileCheckBox2.UseVisualStyleBackColor = true;
            // 
            // attFileCheckBox1
            // 
            this.attFileCheckBox1.AutoSize = true;
            this.attFileCheckBox1.Enabled = false;
            this.attFileCheckBox1.Location = new System.Drawing.Point(20, 19);
            this.attFileCheckBox1.Name = "attFileCheckBox1";
            this.attFileCheckBox1.Size = new System.Drawing.Size(89, 17);
            this.attFileCheckBox1.TabIndex = 11;
            this.attFileCheckBox1.Text = "Attachment 1";
            this.attFileCheckBox1.UseVisualStyleBackColor = true;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(235, 40);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 1;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
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
            this.Controls.Add(this.sendBtn);
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
        private System.Windows.Forms.TextBox senderPasswordTxt;
        private System.Windows.Forms.TextBox senderEmailTxt;
        private System.Windows.Forms.TextBox senderNameTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox recEmailTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TextBox recNameTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox subjectTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton disableSSLBtn;
        private System.Windows.Forms.RadioButton enableSSLBtn;
        private System.Windows.Forms.TextBox smtpPortTxt;
        private System.Windows.Forms.TextBox smtpHostTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox bodyRichTB;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.CheckBox htmlCheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox attach;
        private System.Windows.Forms.CheckBox attFileCheckBox1;
        private System.Windows.Forms.Button hideBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox attFileCheckBox3;
        private System.Windows.Forms.CheckBox attFileCheckBox2;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
    }
}


namespace DicomServerTray
{
    partial class config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(config));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IPADRESS = new System.Windows.Forms.TextBox();
            this.DBPWD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DBNAME = new System.Windows.Forms.TextBox();
            this.USERID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.QRHOST = new System.Windows.Forms.TextBox();
            this.AET = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SERVERAET = new System.Windows.Forms.TextBox();
            this.QRPORT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.jpgPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dcmPathBtn = new System.Windows.Forms.Button();
            this.dcmPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.jpgPathBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TESTHOST = new System.Windows.Forms.TextBox();
            this.TESTAET = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TESTSERVERAET = new System.Windows.Forms.TextBox();
            this.TESTPORT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.PHONE = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IPADRESS);
            this.groupBox1.Controls.Add(this.DBPWD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DBNAME);
            this.groupBox1.Controls.Add(this.USERID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MySQL";
            // 
            // IPADRESS
            // 
            this.IPADRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPADRESS.Location = new System.Drawing.Point(14, 51);
            this.IPADRESS.Name = "IPADRESS";
            this.IPADRESS.Size = new System.Drawing.Size(91, 20);
            this.IPADRESS.TabIndex = 10;
            this.IPADRESS.Text = "127.0.0.1";
            this.IPADRESS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DBPWD
            // 
            this.DBPWD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBPWD.Location = new System.Drawing.Point(334, 50);
            this.DBPWD.Name = "DBPWD";
            this.DBPWD.Size = new System.Drawing.Size(91, 20);
            this.DBPWD.TabIndex = 4;
            this.DBPWD.Text = "Fast2020!";
            this.DBPWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "DB PWD";
            // 
            // DBNAME
            // 
            this.DBNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBNAME.Location = new System.Drawing.Point(218, 48);
            this.DBNAME.Name = "DBNAME";
            this.DBNAME.Size = new System.Drawing.Size(101, 20);
            this.DBNAME.TabIndex = 3;
            this.DBNAME.Text = "premier_db";
            this.DBNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // USERID
            // 
            this.USERID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERID.Location = new System.Drawing.Point(119, 51);
            this.USERID.Name = "USERID";
            this.USERID.Size = new System.Drawing.Size(82, 20);
            this.USERID.TabIndex = 2;
            this.USERID.Text = "root";
            this.USERID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DB NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "USER ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP ADRESS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.QRHOST);
            this.groupBox3.Controls.Add(this.AET);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.SERVERAET);
            this.groupBox3.Controls.Add(this.QRPORT);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 90);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "QR SERVER";
            // 
            // QRHOST
            // 
            this.QRHOST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRHOST.Location = new System.Drawing.Point(13, 51);
            this.QRHOST.Name = "QRHOST";
            this.QRHOST.Size = new System.Drawing.Size(91, 20);
            this.QRHOST.TabIndex = 1;
            this.QRHOST.Text = "10.200.6.116";
            this.QRHOST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AET
            // 
            this.AET.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AET.Location = new System.Drawing.Point(334, 50);
            this.AET.Name = "AET";
            this.AET.Size = new System.Drawing.Size(91, 20);
            this.AET.TabIndex = 4;
            this.AET.Text = "MOBILEAPP";
            this.AET.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "AET";
            // 
            // SERVERAET
            // 
            this.SERVERAET.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SERVERAET.Location = new System.Drawing.Point(218, 51);
            this.SERVERAET.Name = "SERVERAET";
            this.SERVERAET.Size = new System.Drawing.Size(101, 20);
            this.SERVERAET.TabIndex = 3;
            this.SERVERAET.Text = "RADIUSPACS160";
            this.SERVERAET.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QRPORT
            // 
            this.QRPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRPORT.Location = new System.Drawing.Point(119, 51);
            this.QRPORT.Name = "QRPORT";
            this.QRPORT.Size = new System.Drawing.Size(82, 20);
            this.QRPORT.TabIndex = 2;
            this.QRPORT.Text = "104";
            this.QRPORT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(226, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "SERVER AET";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(127, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "PORT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "HOST";
            // 
            // jpgPath
            // 
            this.jpgPath.Location = new System.Drawing.Point(25, 34);
            this.jpgPath.Name = "jpgPath";
            this.jpgPath.Size = new System.Drawing.Size(334, 20);
            this.jpgPath.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "JPEG PATH";
            // 
            // dcmPathBtn
            // 
            this.dcmPathBtn.Location = new System.Drawing.Point(372, 82);
            this.dcmPathBtn.Name = "dcmPathBtn";
            this.dcmPathBtn.Size = new System.Drawing.Size(65, 23);
            this.dcmPathBtn.TabIndex = 4;
            this.dcmPathBtn.Text = "open";
            this.dcmPathBtn.UseVisualStyleBackColor = true;
            this.dcmPathBtn.Click += new System.EventHandler(this.dcmPathBtn_Click);
            // 
            // dcmPath
            // 
            this.dcmPath.Location = new System.Drawing.Point(25, 82);
            this.dcmPath.Name = "dcmPath";
            this.dcmPath.Size = new System.Drawing.Size(334, 20);
            this.dcmPath.TabIndex = 3;
            // 
            // jpgPathBtn
            // 
            this.jpgPathBtn.Location = new System.Drawing.Point(372, 34);
            this.jpgPathBtn.Name = "jpgPathBtn";
            this.jpgPathBtn.Size = new System.Drawing.Size(65, 23);
            this.jpgPathBtn.TabIndex = 2;
            this.jpgPathBtn.Text = "open";
            this.jpgPathBtn.UseVisualStyleBackColor = true;
            this.jpgPathBtn.Click += new System.EventHandler(this.jpgPathBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "DCM PATH";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(280, 481);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(65, 23);
            this.okBtn.TabIndex = 18;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(372, 481);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(65, 23);
            this.cancelBtn.TabIndex = 19;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TESTHOST);
            this.groupBox2.Controls.Add(this.TESTAET);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TESTSERVERAET);
            this.groupBox2.Controls.Add(this.TESTPORT);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 90);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "QR TEST SERVER";
            // 
            // TESTHOST
            // 
            this.TESTHOST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TESTHOST.Location = new System.Drawing.Point(13, 51);
            this.TESTHOST.Name = "TESTHOST";
            this.TESTHOST.Size = new System.Drawing.Size(91, 20);
            this.TESTHOST.TabIndex = 1;
            this.TESTHOST.Text = "127.0.0.1";
            this.TESTHOST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TESTAET
            // 
            this.TESTAET.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TESTAET.Location = new System.Drawing.Point(334, 50);
            this.TESTAET.Name = "TESTAET";
            this.TESTAET.Size = new System.Drawing.Size(91, 20);
            this.TESTAET.TabIndex = 4;
            this.TESTAET.Text = "TESTAPP";
            this.TESTAET.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(340, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "AET";
            // 
            // TESTSERVERAET
            // 
            this.TESTSERVERAET.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TESTSERVERAET.Location = new System.Drawing.Point(218, 51);
            this.TESTSERVERAET.Name = "TESTSERVERAET";
            this.TESTSERVERAET.Size = new System.Drawing.Size(101, 20);
            this.TESTSERVERAET.TabIndex = 3;
            this.TESTSERVERAET.Text = "RADIUSPACS160";
            this.TESTSERVERAET.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TESTPORT
            // 
            this.TESTPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TESTPORT.Location = new System.Drawing.Point(119, 51);
            this.TESTPORT.Name = "TESTPORT";
            this.TESTPORT.Size = new System.Drawing.Size(82, 20);
            this.TESTPORT.TabIndex = 2;
            this.TESTPORT.Text = "4006";
            this.TESTPORT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(226, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "SERVER AET";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(127, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "PORT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "HOST";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 457);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 13);
            this.label22.TabIndex = 20;
            this.label22.Text = "Phone Number";
            // 
            // PHONE
            // 
            this.PHONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PHONE.Location = new System.Drawing.Point(107, 454);
            this.PHONE.Name = "PHONE";
            this.PHONE.Size = new System.Drawing.Size(122, 20);
            this.PHONE.TabIndex = 10;
            this.PHONE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 512);
            this.Controls.Add(this.PHONE);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dcmPathBtn);
            this.Controls.Add(this.dcmPath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.jpgPathBtn);
            this.Controls.Add(this.jpgPath);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 536);
            this.Name = "config";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.config_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DBPWD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DBNAME;
        private System.Windows.Forms.TextBox USERID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox AET;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SERVERAET;
        private System.Windows.Forms.TextBox QRPORT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox jpgPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button dcmPathBtn;
        private System.Windows.Forms.TextBox dcmPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button jpgPathBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox IPADRESS;
        private System.Windows.Forms.TextBox QRHOST;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TESTHOST;
        private System.Windows.Forms.TextBox TESTAET;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TESTSERVERAET;
        private System.Windows.Forms.TextBox TESTPORT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox PHONE;
    }
}
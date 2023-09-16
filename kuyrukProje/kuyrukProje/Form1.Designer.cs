namespace kuyrukProje
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txb_p1 = new System.Windows.Forms.TextBox();
            this.txb_p2 = new System.Windows.Forms.TextBox();
            this.txb_p3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.p3_kntrol = new System.Windows.Forms.TrackBar();
            this.islemci_kntrl = new System.Windows.Forms.TrackBar();
            this.p1_kntrol = new System.Windows.Forms.TrackBar();
            this.p2_kntrol = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Timer(this.components);
            this.p2 = new System.Windows.Forms.Timer(this.components);
            this.p3 = new System.Windows.Forms.Timer(this.components);
            this.islemci = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p3_kntrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemci_kntrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1_kntrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2_kntrol)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 35);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "İşlemci Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "İşlemci Durdur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txb_p1
            // 
            this.txb_p1.Location = new System.Drawing.Point(32, 155);
            this.txb_p1.Multiline = true;
            this.txb_p1.Name = "txb_p1";
            this.txb_p1.Size = new System.Drawing.Size(70, 103);
            this.txb_p1.TabIndex = 3;
            // 
            // txb_p2
            // 
            this.txb_p2.Location = new System.Drawing.Point(116, 155);
            this.txb_p2.Multiline = true;
            this.txb_p2.Name = "txb_p2";
            this.txb_p2.Size = new System.Drawing.Size(70, 103);
            this.txb_p2.TabIndex = 4;
            // 
            // txb_p3
            // 
            this.txb_p3.Location = new System.Drawing.Point(204, 155);
            this.txb_p3.Multiline = true;
            this.txb_p3.Name = "txb_p3";
            this.txb_p3.Size = new System.Drawing.Size(70, 103);
            this.txb_p3.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.p3_kntrol);
            this.groupBox1.Controls.Add(this.islemci_kntrl);
            this.groupBox1.Controls.Add(this.p1_kntrol);
            this.groupBox1.Controls.Add(this.p2_kntrol);
            this.groupBox1.Location = new System.Drawing.Point(32, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 118);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hız Ayarları(1 saniyede yapılan işlem sayısı)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Proses3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Proses2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Proses1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "İşlemci";
            // 
            // p3_kntrol
            // 
            this.p3_kntrol.Location = new System.Drawing.Point(564, 56);
            this.p3_kntrol.Name = "p3_kntrol";
            this.p3_kntrol.Size = new System.Drawing.Size(104, 56);
            this.p3_kntrol.TabIndex = 10;
            this.p3_kntrol.Scroll += new System.EventHandler(this.p3_kntrol_Scroll);
            // 
            // islemci_kntrl
            // 
            this.islemci_kntrl.Location = new System.Drawing.Point(28, 56);
            this.islemci_kntrl.Name = "islemci_kntrl";
            this.islemci_kntrl.Size = new System.Drawing.Size(104, 56);
            this.islemci_kntrl.TabIndex = 7;
            this.islemci_kntrl.Scroll += new System.EventHandler(this.islemci_kntrl_Scroll);
            // 
            // p1_kntrol
            // 
            this.p1_kntrol.Location = new System.Drawing.Point(212, 62);
            this.p1_kntrol.Name = "p1_kntrol";
            this.p1_kntrol.Size = new System.Drawing.Size(104, 56);
            this.p1_kntrol.TabIndex = 8;
            this.p1_kntrol.Scroll += new System.EventHandler(this.p1_kntrol_Scroll);
            // 
            // p2_kntrol
            // 
            this.p2_kntrol.Location = new System.Drawing.Point(389, 62);
            this.p2_kntrol.Name = "p2_kntrol";
            this.p2_kntrol.Size = new System.Drawing.Size(104, 56);
            this.p2_kntrol.TabIndex = 9;
            this.p2_kntrol.Scroll += new System.EventHandler(this.p2_kntrol_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Location = new System.Drawing.Point(525, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 270);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 71);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(257, 193);
            this.textBox5.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(263, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Bitirilen Prosesleri Göster";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(5, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Proses1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(93, 15);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 21);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Proses2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(181, 15);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(82, 21);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Proses3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Proses Kuyruğu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Proses1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Proses2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Proses3";
            // 
            // p1
            // 
            this.p1.Enabled = true;
            this.p1.Interval = 3000;
            this.p1.Tick += new System.EventHandler(this.p1_Tick);
            // 
            // p2
            // 
            this.p2.Enabled = true;
            this.p2.Interval = 4000;
            this.p2.Tick += new System.EventHandler(this.p2_Tick);
            // 
            // p3
            // 
            this.p3.Enabled = true;
            this.p3.Interval = 5000;
            this.p3.Tick += new System.EventHandler(this.p3_Tick);
            // 
            // islemci
            // 
            this.islemci.Enabled = true;
            this.islemci.Interval = 5000;
            this.islemci.Tick += new System.EventHandler(this.islemci_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txb_p3);
            this.Controls.Add(this.txb_p2);
            this.Controls.Add(this.txb_p1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p3_kntrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemci_kntrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1_kntrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2_kntrol)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txb_p1;
        private System.Windows.Forms.TextBox txb_p2;
        private System.Windows.Forms.TextBox txb_p3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar p3_kntrol;
        private System.Windows.Forms.TrackBar islemci_kntrl;
        private System.Windows.Forms.TrackBar p1_kntrol;
        private System.Windows.Forms.TrackBar p2_kntrol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer p1;
        private System.Windows.Forms.Timer p2;
        private System.Windows.Forms.Timer p3;
        private System.Windows.Forms.Timer islemci;
    }
}


namespace BMIкалькулятор
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.man = new System.Windows.Forms.PictureBox();
            this.woman = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Result = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Length = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.TextBox();
            this.diagnozlabel1 = new System.Windows.Forms.Label();
            this.diagnozlabel2 = new System.Windows.Forms.Label();
            this.diagnozlabel3 = new System.Windows.Forms.Label();
            this.diagnozlabel4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // man
            // 
            this.man.BackColor = System.Drawing.SystemColors.ControlLight;
            this.man.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.man.Image = global::BMIкалькулятор.Properties.Resources.male_icon;
            this.man.Location = new System.Drawing.Point(47, 216);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(153, 137);
            this.man.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.man.TabIndex = 0;
            this.man.TabStop = false;
            this.man.Click += new System.EventHandler(this.man_Click_1);
            // 
            // woman
            // 
            this.woman.BackColor = System.Drawing.SystemColors.ControlLight;
            this.woman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.woman.Image = ((System.Drawing.Image)(resources.GetObject("woman.Image")));
            this.woman.Location = new System.Drawing.Point(222, 216);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(150, 137);
            this.woman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.woman.TabIndex = 1;
            this.woman.TabStop = false;
            this.woman.Click += new System.EventHandler(this.woman_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(757, 162);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(224, 272);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Result.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result.ForeColor = System.Drawing.Color.Black;
            this.Result.Location = new System.Drawing.Point(34, 512);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(153, 41);
            this.Result.TabIndex = 5;
            this.Result.Text = "Рассчитать ";
            this.Result.UseVisualStyleBackColor = false;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancel.ForeColor = System.Drawing.Color.Black;
            this.Cancel.Location = new System.Drawing.Point(222, 512);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(123, 41);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.LargeChange = 0;
            this.trackBar1.Location = new System.Drawing.Point(558, 524);
            this.trackBar1.Maximum = 35;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(570, 56);
            this.trackBar1.SmallChange = 0;
            this.trackBar1.TabIndex = 17;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Length.Location = new System.Drawing.Point(122, 383);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(65, 31);
            this.Length.TabIndex = 9;
            this.Length.Text = "Рост:";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Weight.Location = new System.Drawing.Point(132, 443);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(55, 31);
            this.Weight.TabIndex = 10;
            this.Weight.Text = "Вес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(269, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "см";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(269, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "кг";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(468, 73);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(197, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "BMI калькулятор";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLength
            // 
            this.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLength.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLength.Location = new System.Drawing.Point(193, 383);
            this.txtLength.Multiline = true;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(70, 34);
            this.txtLength.TabIndex = 14;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWeight.Location = new System.Drawing.Point(193, 440);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(70, 34);
            this.txtWeight.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 55);
            this.panel1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(388, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(363, 34);
            this.label7.TabIndex = 18;
            this.label7.Text = "MARATHON SKILLS 2016";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(-1, 626);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1189, 56);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 56);
            this.label1.TabIndex = 19;
            this.label1.Text = "Информация о  том, что такое BMI и\r\nкак калькулятор работает";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(832, 473);
            this.label10.Multiline = true;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 34);
            this.label10.TabIndex = 20;
            // 
            // diagnozlabel1
            // 
            this.diagnozlabel1.AutoSize = true;
            this.diagnozlabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diagnozlabel1.ForeColor = System.Drawing.Color.DimGray;
            this.diagnozlabel1.Location = new System.Drawing.Point(579, 587);
            this.diagnozlabel1.Name = "diagnozlabel1";
            this.diagnozlabel1.Size = new System.Drawing.Size(133, 23);
            this.diagnozlabel1.TabIndex = 21;
            this.diagnozlabel1.Text = "Недостаточный";
            // 
            // diagnozlabel2
            // 
            this.diagnozlabel2.AutoSize = true;
            this.diagnozlabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diagnozlabel2.Location = new System.Drawing.Point(737, 587);
            this.diagnozlabel2.Name = "diagnozlabel2";
            this.diagnozlabel2.Size = new System.Drawing.Size(94, 23);
            this.diagnozlabel2.TabIndex = 22;
            this.diagnozlabel2.Text = "Здоровый ";
            // 
            // diagnozlabel3
            // 
            this.diagnozlabel3.AutoSize = true;
            this.diagnozlabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diagnozlabel3.Location = new System.Drawing.Point(869, 587);
            this.diagnozlabel3.Name = "diagnozlabel3";
            this.diagnozlabel3.Size = new System.Drawing.Size(112, 23);
            this.diagnozlabel3.TabIndex = 23;
            this.diagnozlabel3.Text = "Избыточный";
            this.diagnozlabel3.Click += new System.EventHandler(this.diagnozlabel3_Click);
            // 
            // diagnozlabel4
            // 
            this.diagnozlabel4.AutoSize = true;
            this.diagnozlabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diagnozlabel4.Location = new System.Drawing.Point(1016, 587);
            this.diagnozlabel4.Name = "diagnozlabel4";
            this.diagnozlabel4.Size = new System.Drawing.Size(94, 23);
            this.diagnozlabel4.TabIndex = 24;
            this.diagnozlabel4.Text = "Ожирение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(91, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Мужской";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(259, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Женский ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(558, 557);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 27);
            this.textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LimeGreen;
            this.textBox2.Location = new System.Drawing.Point(710, 557);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 27);
            this.textBox2.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Orange;
            this.textBox3.Location = new System.Drawing.Point(855, 557);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 27);
            this.textBox3.TabIndex = 30;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Red;
            this.textBox4.Location = new System.Drawing.Point(998, 557);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 27);
            this.textBox4.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 675);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.diagnozlabel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diagnozlabel4);
            this.Controls.Add(this.diagnozlabel3);
            this.Controls.Add(this.diagnozlabel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.woman);
            this.Controls.Add(this.man);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox man;
        private PictureBox woman;
        private PictureBox pictureBox3;
        private Button Result;
        private Button Cancel;
        private TrackBar trackBar1;
        private Label Length;
        private Label Weight;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtLength;
        private TextBox txtWeight;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Label label1;
        private TextBox label10;
        private Label diagnozlabel1;
        private Label diagnozlabel2;
        private Label diagnozlabel3;
        private Label diagnozlabel4;
        private Label label2;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox4;
        private EventHandler man_Click;
    }
}
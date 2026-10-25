namespace SpaceSeva_Innovators_Yagi_Antenna
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
            label1 = new Label();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            comboBox2 = new ComboBox();
            label15 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(602, 9);
            label1.Name = "label1";
            label1.Size = new Size(805, 56);
            label1.TabIndex = 0;
            label1.Text = "Yagi Antenna Design Computation";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(387, 128);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 46);
            textBox1.TabIndex = 1;
            textBox1.Text = "145.800";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(12, 546);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1828, 492);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "KHz", "Hz", "MHz", "GHz", "THz" });
            comboBox1.Location = new Point(625, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 54);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(129, 128);
            label2.Name = "label2";
            label2.Size = new Size(232, 46);
            label2.TabIndex = 4;
            label2.Text = "Frequency:";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(129, 472);
            button1.Name = "button1";
            button1.Size = new Size(227, 52);
            button1.TabIndex = 5;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(129, 224);
            label3.Name = "label3";
            label3.Size = new Size(419, 46);
            label3.TabIndex = 6;
            label3.Text = "Number of Elements:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(129, 305);
            label4.Name = "label4";
            label4.Size = new Size(526, 46);
            label4.TabIndex = 7;
            label4.Text = "Reflector - Dipole Spacing:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(129, 388);
            label5.Name = "label5";
            label5.Size = new Size(526, 46);
            label5.TabIndex = 8;
            label5.Text = "Adjacent Director Spacing:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1112, 218);
            label6.Name = "label6";
            label6.Size = new Size(346, 46);
            label6.TabIndex = 9;
            label6.Text = "Reflector Length:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(1131, 305);
            label7.Name = "label7";
            label7.Size = new Size(295, 46);
            label7.TabIndex = 10;
            label7.Text = "Dipole Length:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1131, 385);
            label8.Name = "label8";
            label8.Size = new Size(327, 46);
            label8.TabIndex = 11;
            label8.Text = "Director Length:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(554, 224);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 46);
            textBox3.TabIndex = 13;
            textBox3.Text = "5";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(671, 302);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(179, 46);
            textBox4.TabIndex = 14;
            textBox4.Text = "0.25";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(671, 388);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(179, 46);
            textBox5.TabIndex = 15;
            textBox5.Text = "0.34";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1131, 469);
            label9.Name = "label9";
            label9.Size = new Size(330, 46);
            label9.TabIndex = 16;
            label9.Text = "Element Radius:";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(1492, 218);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(179, 46);
            textBox6.TabIndex = 17;
            textBox6.Text = "0.5";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(1492, 302);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(179, 46);
            textBox7.TabIndex = 18;
            textBox7.Text = "0.47";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(1492, 385);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(179, 46);
            textBox8.TabIndex = 19;
            textBox8.Text = "0.406";
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(1492, 472);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(179, 46);
            textBox9.TabIndex = 20;
            textBox9.Text = "0.003";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(874, 305);
            label10.Name = "label10";
            label10.Size = new Size(42, 46);
            label10.TabIndex = 22;
            label10.Text = "λ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(874, 391);
            label11.Name = "label11";
            label11.Size = new Size(42, 46);
            label11.TabIndex = 23;
            label11.Text = "λ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(1697, 215);
            label12.Name = "label12";
            label12.Size = new Size(42, 46);
            label12.TabIndex = 24;
            label12.Text = "λ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(1697, 299);
            label13.Name = "label13";
            label13.Size = new Size(42, 46);
            label13.TabIndex = 25;
            label13.Text = "λ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(1697, 393);
            label14.Name = "label14";
            label14.Size = new Size(42, 46);
            label14.TabIndex = 26;
            label14.Text = "λ";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Yagi Uda Antenna - EFY 88", "Yagi Uda Antenna - NBS 688", "Yagi Uda Antenna - DL6WU" });
            comboBox2.Location = new Point(1131, 128);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(494, 45);
            comboBox2.TabIndex = 27;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(1697, 472);
            label15.Name = "label15";
            label15.Size = new Size(42, 46);
            label15.TabIndex = 28;
            label15.Text = "λ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Vertical_Line_Green;
            pictureBox1.Location = new Point(1002, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(12, 412);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1924, 1050);
            Controls.Add(pictureBox1);
            Controls.Add(label15);
            Controls.Add(comboBox2);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Yagi Antenna Calculator ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox comboBox2;
        private Label label15;
        private PictureBox pictureBox1;
    }
}

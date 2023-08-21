namespace login
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox4 = new TextBox();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            button7 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button8 = new Button();
            textBox7 = new TextBox();
            button9 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("DM Sans 14pt", 19.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 20);
            label1.Name = "label1";
            label1.Size = new Size(218, 52);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1269, 95);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("DM Sans 14pt", 9.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 116);
            label2.Name = "label2";
            label2.Size = new Size(70, 26);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("DM Sans 14pt", 9.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 167);
            label3.Name = "label3";
            label3.Size = new Size(62, 26);
            label3.TabIndex = 3;
            label3.Text = "From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("DM Sans 14pt", 9.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(46, 284);
            label4.Name = "label4";
            label4.Size = new Size(125, 26);
            label4.TabIndex = 4;
            label4.Text = "Description";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("DM Sans 14pt", 9.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(46, 228);
            label5.Name = "label5";
            label5.Size = new Size(60, 26);
            label5.TabIndex = 5;
            label5.Text = "Type";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(190, 113);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name of your husbu";
            textBox1.Size = new Size(378, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(190, 167);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Origin of your husbu";
            textBox2.Size = new Size(378, 31);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Cursor = Cursors.Hand;
            radioButton1.Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(190, 228);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 28);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Anime";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Cursor = Cursors.Hand;
            radioButton2.Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(292, 228);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(85, 28);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Game";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Cursor = Cursors.Hand;
            radioButton3.Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(395, 226);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(89, 28);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.Text = "Comic";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(190, 284);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Describe your husbu ...";
            textBox3.Size = new Size(378, 117);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(615, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1068, 113);
            button1.Name = "button1";
            button1.Size = new Size(155, 44);
            button1.TabIndex = 13;
            button1.Text = "Create +";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkMagenta;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(615, 372);
            button2.Name = "button2";
            button2.Size = new Size(236, 44);
            button2.TabIndex = 14;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1068, 248);
            button3.Name = "button3";
            button3.Size = new Size(155, 44);
            button3.TabIndex = 15;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.OliveDrab;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(888, 113);
            button4.Name = "button4";
            button4.Size = new Size(155, 44);
            button4.TabIndex = 16;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkOrange;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(1068, 180);
            button5.Name = "button5";
            button5.Size = new Size(155, 44);
            button5.TabIndex = 17;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("DM Sans 14pt", 9.999999F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(46, 492);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Search here . . .";
            textBox4.Size = new Size(964, 34);
            textBox4.TabIndex = 18;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.ImageAlign = ContentAlignment.MiddleRight;
            button6.Location = new Point(1030, 492);
            button6.Name = "button6";
            button6.Size = new Size(193, 35);
            button6.TabIndex = 19;
            button6.Text = "Search 🔎";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 540);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(964, 242);
            dataGridView1.TabIndex = 20;
            // 
            // button7
            // 
            button7.BackColor = Color.SteelBlue;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(888, 383);
            button7.Name = "button7";
            button7.Size = new Size(335, 44);
            button7.TabIndex = 21;
            button7.Text = "Show Data";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("DM Sans 14pt", 14.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(888, 180);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = " id";
            textBox5.Size = new Size(155, 47);
            textBox5.TabIndex = 22;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("DM Sans 14pt", 14.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(888, 248);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = " id";
            textBox6.Size = new Size(155, 47);
            textBox6.TabIndex = 23;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkOrange;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(190, 425);
            button8.Name = "button8";
            button8.Size = new Size(236, 44);
            button8.TabIndex = 24;
            button8.Text = "Save and Updated";
            button8.UseVisualStyleBackColor = false;
            button8.Visible = false;
            button8.Click += button8_Click;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("DM Sans 14pt", 14.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(888, 311);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = " id";
            textBox7.Size = new Size(155, 47);
            textBox7.TabIndex = 26;
            // 
            // button9
            // 
            button9.BackColor = Color.DimGray;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(1068, 311);
            button9.Name = "button9";
            button9.Size = new Size(155, 44);
            button9.TabIndex = 25;
            button9.Text = "Show";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 813);
            Controls.Add(textBox7);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(button7);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(textBox4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Home";
            Text = "HusbuSaya";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox4;
        private Button button6;
        private DataGridView dataGridView1;
        private Button button7;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button8;
        private PictureBox pictureBox2;
        private TextBox textBox7;
        private Button button9;
    }
}
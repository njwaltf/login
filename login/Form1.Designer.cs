namespace login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            Masuk = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(651, 660);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("DM Sans 14pt SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(741, 153);
            label1.Name = "label1";
            label1.Size = new Size(180, 64);
            label1.TabIndex = 1;
            label1.Text = "Sign In";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("DM Sans 14pt", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(924, 317);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 36);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("DM Sans 14pt Medium", 12.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(756, 312);
            label2.Name = "label2";
            label2.Size = new Size(138, 34);
            label2.TabIndex = 3;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(924, 403);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '●';
            textBox2.Size = new Size(335, 31);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("DM Sans 14pt Medium", 12.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(756, 397);
            label3.Name = "label3";
            label3.Size = new Size(132, 34);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // Masuk
            // 
            Masuk.BackColor = Color.DarkOrange;
            Masuk.Cursor = Cursors.Hand;
            Masuk.FlatAppearance.BorderSize = 0;
            Masuk.FlatStyle = FlatStyle.Flat;
            Masuk.Font = new Font("DM Sans 14pt", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Masuk.ForeColor = Color.White;
            Masuk.Location = new Point(756, 473);
            Masuk.Name = "Masuk";
            Masuk.Size = new Size(503, 60);
            Masuk.TabIndex = 7;
            Masuk.Text = "Sign In";
            Masuk.UseVisualStyleBackColor = false;
            Masuk.Click += Masuk_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("DM Sans 14pt", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(751, 222);
            label4.Name = "label4";
            label4.Size = new Size(331, 31);
            label4.TabIndex = 8;
            label4.Text = "Sign in to your account here.";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1328, 714);
            Controls.Add(label4);
            Controls.Add(Masuk);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("DM Sans 14pt", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In to your Account";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button Masuk;
        private Label label4;
    }
}
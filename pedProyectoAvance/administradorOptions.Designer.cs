namespace pedProyectoAvance
{
    partial class administradorOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(administradorOptions));
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            groupBox3 = new GroupBox();
            pictureBox3 = new PictureBox();
            groupBox4 = new GroupBox();
            pictureBox4 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 46);
            label1.Name = "label1";
            label1.Size = new Size(363, 31);
            label1.TabIndex = 0;
            label1.Text = "Administración de la Clinica";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AntiqueWhite;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Simple Outline Pat", 9F);
            groupBox1.Location = new Point(158, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 157);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administrar Doctores";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.AntiqueWhite;
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Font = new Font("Simple Outline Pat", 9F);
            groupBox2.Location = new Point(659, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(257, 157);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Administrar Pacientes";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(58, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 119);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.AntiqueWhite;
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Font = new Font("Simple Outline Pat", 9F);
            groupBox3.Location = new Point(158, 367);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(257, 157);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Administrar Citas";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(57, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(131, 111);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.AntiqueWhite;
            groupBox4.Controls.Add(pictureBox4);
            groupBox4.Font = new Font("Simple Outline Pat", 9F);
            groupBox4.Location = new Point(659, 367);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(257, 157);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Agendar Citas";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(61, 32);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(134, 111);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // administradorOptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1107, 695);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "administradorOptions";
            Text = "Administrador";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
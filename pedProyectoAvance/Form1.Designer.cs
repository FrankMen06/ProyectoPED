namespace pedProyectoAvance;

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
        pictureBox1 = new PictureBox();
        groupBox1 = new GroupBox();
        txtPassword = new TextBox();
        txtUsuario = new TextBox();
        btnSalir = new Button();
        btnIngresar = new Button();
        label3 = new Label();
        label2 = new Label();
        label4 = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(348, 85);
        label1.Name = "label1";
        label1.Size = new Size(461, 44);
        label1.TabIndex = 0;
        label1.Text = "¡BIENVENIDO AL SISTEMA!";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(55, 217);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(308, 295);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(txtPassword);
        groupBox1.Controls.Add(txtUsuario);
        groupBox1.Controls.Add(btnSalir);
        groupBox1.Controls.Add(btnIngresar);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        groupBox1.Location = new Point(416, 178);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(698, 368);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "Ingrese sus credenciales";
        // 
        // txtPassword
        // 
        txtPassword.BorderStyle = BorderStyle.FixedSingle;
        txtPassword.Location = new Point(39, 185);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(596, 32);
        txtPassword.TabIndex = 5;
        // 
        // txtUsuario
        // 
        txtUsuario.BorderStyle = BorderStyle.FixedSingle;
        txtUsuario.Location = new Point(39, 91);
        txtUsuario.Name = "txtUsuario";
        txtUsuario.Size = new Size(596, 32);
        txtUsuario.TabIndex = 4;
        // 
        // btnSalir
        // 
        btnSalir.BackColor = Color.LightCoral;
        btnSalir.FlatStyle = FlatStyle.Flat;
        btnSalir.ForeColor = Color.White;
        btnSalir.Location = new Point(343, 260);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new Size(191, 47);
        btnSalir.TabIndex = 3;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = false;
        btnSalir.Click += btnSalir_Click;
        // 
        // btnIngresar
        // 
        btnIngresar.BackColor = Color.CornflowerBlue;
        btnIngresar.FlatStyle = FlatStyle.Flat;
        btnIngresar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnIngresar.ForeColor = Color.White;
        btnIngresar.Location = new Point(146, 260);
        btnIngresar.Name = "btnIngresar";
        btnIngresar.Size = new Size(191, 47);
        btnIngresar.TabIndex = 2;
        btnIngresar.Text = "Iniciar Sesión";
        btnIngresar.UseVisualStyleBackColor = false;
        btnIngresar.Click += btnIngresar_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Century Gothic", 12F);
        label3.Location = new Point(39, 154);
        label3.Name = "label3";
        label3.Size = new Size(125, 23);
        label3.TabIndex = 1;
        label3.Text = "Contraseña";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Century Gothic", 12F);
        label2.Location = new Point(39, 60);
        label2.Name = "label2";
        label2.Size = new Size(79, 23);
        label2.TabIndex = 0;
        label2.Text = "Usuario";
        // 
        // label4
        // 
        label4.BackColor = Color.RoyalBlue;
        label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label4.ForeColor = Color.White;
        label4.Location = new Point(-2, 0);
        label4.Name = "label4";
        label4.Size = new Size(1172, 51);
        label4.TabIndex = 3;
        label4.Text = "Hospital Don Bosco";
        label4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1170, 619);
        Controls.Add(label4);
        Controls.Add(groupBox1);
        Controls.Add(pictureBox1);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private PictureBox pictureBox1;
    private GroupBox groupBox1;
    private TextBox txtPassword;
    private TextBox txtUsuario;
    private Button btnSalir;
    private Button btnIngresar;
    private Label label3;
    private Label label2;
    private Label label4;
}
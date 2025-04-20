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
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Stencil", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(519, 49);
        label1.Name = "label1";
        label1.Size = new Size(451, 44);
        label1.TabIndex = 0;
        label1.Text = "Bienvenido al Sistema";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(601, 110);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(271, 250);
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
        groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        groupBox1.Location = new Point(412, 382);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(698, 437);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "Ingrese sus credenciales";
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(39, 244);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(596, 34);
        txtPassword.TabIndex = 5;
        // 
        // txtUsuario
        // 
        txtUsuario.Location = new Point(39, 111);
        txtUsuario.Name = "txtUsuario";
        txtUsuario.Size = new Size(596, 34);
        txtUsuario.TabIndex = 4;
        // 
        // btnSalir
        // 
        btnSalir.Location = new Point(445, 318);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new Size(113, 79);
        btnSalir.TabIndex = 3;
        btnSalir.Text = "Cerrar Sistema";
        btnSalir.UseVisualStyleBackColor = true;
        btnSalir.Click += btnSalir_Click;
        // 
        // btnIngresar
        // 
        btnIngresar.Location = new Point(107, 318);
        btnIngresar.Name = "btnIngresar";
        btnIngresar.Size = new Size(133, 78);
        btnIngresar.TabIndex = 2;
        btnIngresar.Text = "Ingresar";
        btnIngresar.UseVisualStyleBackColor = true;
        btnIngresar.Click += btnIngresar_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(39, 199);
        label3.Name = "label3";
        label3.Size = new Size(110, 28);
        label3.TabIndex = 1;
        label3.Text = "Contraseña";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(39, 71);
        label2.Name = "label2";
        label2.Size = new Size(79, 28);
        label2.TabIndex = 0;
        label2.Text = "Usuario";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(1477, 889);
        Controls.Add(groupBox1);
        Controls.Add(pictureBox1);
        Controls.Add(label1);
        Name = "Form1";
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
}
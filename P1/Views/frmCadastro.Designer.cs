namespace EstudoTaskool
{
    partial class frmCadastro
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nacimentoTextBox = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.csenhaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.administardorButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            nomeLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.ForeColor = System.Drawing.Color.White;
            nomeLabel.Location = new System.Drawing.Point(4, 43);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 24;
            nomeLabel.Text = "Nome:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.ForeColor = System.Drawing.Color.White;
            usuarioLabel.Location = new System.Drawing.Point(-1, 146);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 30;
            usuarioLabel.Text = "Usuario:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.ForeColor = System.Drawing.Color.White;
            fotoLabel.Location = new System.Drawing.Point(360, 93);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(31, 13);
            fotoLabel.TabIndex = 34;
            fotoLabel.Text = "Foto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(4, 69);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 13);
            label4.TabIndex = 45;
            label4.Text = "Endereco:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(4, 186);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(41, 13);
            label5.TabIndex = 46;
            label5.Text = "Senha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(4, 220);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(54, 13);
            label6.TabIndex = 47;
            label6.Text = "Confirmar ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(4, 233);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(41, 13);
            label7.TabIndex = 50;
            label7.Text = "Senha:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(99, 93);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(120, 20);
            this.dtpNascimento.TabIndex = 28;
            this.dtpNascimento.ValueChanged += new System.EventHandler(this.dtpNascimento_ValueChanged);
            this.dtpNascimento.Enter += new System.EventHandler(this.Inputs_Enter);
            this.dtpNascimento.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(435, 233);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(48, 23);
            this.btnSelecionar.TabIndex = 29;
            this.btnSelecionar.Text = "Deletar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Cadastre-se";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nacimentoTextBox
            // 
            this.nacimentoTextBox.AutoSize = true;
            this.nacimentoTextBox.ForeColor = System.Drawing.Color.White;
            this.nacimentoTextBox.Location = new System.Drawing.Point(4, 93);
            this.nacimentoTextBox.Name = "nacimentoTextBox";
            this.nacimentoTextBox.Size = new System.Drawing.Size(92, 13);
            this.nacimentoTextBox.TabIndex = 36;
            this.nacimentoTextBox.Text = "Data Nascimento:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(48, 40);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 21;
            this.nomeTextBox.TextChanged += new System.EventHandler(this.nomeTextBox_TextChanged);
            this.nomeTextBox.Enter += new System.EventHandler(this.Inputs_Enter);
            this.nomeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPressioada);
            this.nomeTextBox.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(51, 139);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.usuarioTextBox.TabIndex = 25;
            this.usuarioTextBox.Enter += new System.EventHandler(this.Inputs_Enter);
            this.usuarioTextBox.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 43;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(66, 66);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(200, 20);
            this.enderecoTextBox.TabIndex = 44;
            this.enderecoTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(51, 183);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(200, 20);
            this.senhaTextBox.TabIndex = 48;
            // 
            // csenhaTextBox
            // 
            this.csenhaTextBox.Location = new System.Drawing.Point(51, 230);
            this.csenhaTextBox.Name = "csenhaTextBox";
            this.csenhaTextBox.Size = new System.Drawing.Size(200, 20);
            this.csenhaTextBox.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 28);
            this.button2.TabIndex = 52;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(272, 66);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(75, 20);
            this.textBox5.TabIndex = 53;
            // 
            // administardorButton
            // 
            this.administardorButton.AutoSize = true;
            this.administardorButton.Location = new System.Drawing.Point(363, 299);
            this.administardorButton.Name = "administardorButton";
            this.administardorButton.Size = new System.Drawing.Size(85, 17);
            this.administardorButton.TabIndex = 54;
            this.administardorButton.TabStop = true;
            this.administardorButton.Text = "radioButton1";
            this.administardorButton.UseVisualStyleBackColor = true;
            this.administardorButton.CheckedChanged += new System.EventHandler(this.administardorButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(376, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Sou Administrador";
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(346, 112);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(137, 115);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 35;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.fotoPictureBox_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(495, 424);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.administardorButton);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(label7);
            this.Controls.Add(this.csenhaTextBox);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nacimentoTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.PictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCadastro";
            this.Text = "Cadastro de usuário";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nacimentoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox csenhaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton administardorButton;
        private System.Windows.Forms.Label label3;
    }
}
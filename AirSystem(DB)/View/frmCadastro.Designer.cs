namespace AirSystem.View
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textSobrenome = new System.Windows.Forms.TextBox();
            this.textNum = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textUsuarioC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSenhaC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textConfirmaSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.lblErro1 = new System.Windows.Forms.Label();
            this.pictureUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textNome
            // 
            this.textNome.BackColor = System.Drawing.Color.White;
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.ForeColor = System.Drawing.Color.Silver;
            this.textNome.Location = new System.Drawing.Point(141, 27);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(171, 23);
            this.textNome.TabIndex = 1;
            this.textNome.Tag = "";
            this.textNome.Text = "Digite seu nome...";
            this.textNome.Enter += new System.EventHandler(this.textNome_Enter);
            this.textNome.Leave += new System.EventHandler(this.textNome_Leave);
            // 
            // textSobrenome
            // 
            this.textSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSobrenome.ForeColor = System.Drawing.Color.Silver;
            this.textSobrenome.Location = new System.Drawing.Point(318, 27);
            this.textSobrenome.Name = "textSobrenome";
            this.textSobrenome.Size = new System.Drawing.Size(171, 23);
            this.textSobrenome.TabIndex = 2;
            this.textSobrenome.Tag = "";
            this.textSobrenome.Text = "Digite seu sobrenome...";
            this.textSobrenome.Enter += new System.EventHandler(this.textSobrenome_Enter);
            this.textSobrenome.Leave += new System.EventHandler(this.textSobrenome_Leave);
            // 
            // textNum
            // 
            this.textNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNum.ForeColor = System.Drawing.Color.Silver;
            this.textNum.Location = new System.Drawing.Point(407, 74);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(82, 23);
            this.textNum.TabIndex = 4;
            this.textNum.Tag = "";
            this.textNum.Text = "Nº";
            this.textNum.Enter += new System.EventHandler(this.textNum_Enter);
            this.textNum.Leave += new System.EventHandler(this.textNum_Leave);
            // 
            // textEndereco
            // 
            this.textEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEndereco.ForeColor = System.Drawing.Color.Silver;
            this.textEndereco.Location = new System.Drawing.Point(141, 74);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(225, 23);
            this.textEndereco.TabIndex = 3;
            this.textEndereco.Tag = "";
            this.textEndereco.Text = "Digite seu Endereço...";
            this.textEndereco.Enter += new System.EventHandler(this.textEndereco_Enter);
            this.textEndereco.Leave += new System.EventHandler(this.textEndereco_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nascimento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Silver;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.CustomFormat = "dd/mm/yy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // textUsuarioC
            // 
            this.textUsuarioC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuarioC.ForeColor = System.Drawing.Color.Silver;
            this.textUsuarioC.Location = new System.Drawing.Point(141, 168);
            this.textUsuarioC.Name = "textUsuarioC";
            this.textUsuarioC.Size = new System.Drawing.Size(171, 23);
            this.textUsuarioC.TabIndex = 6;
            this.textUsuarioC.Tag = "";
            this.textUsuarioC.Text = "Insira seu usuário...";
            this.textUsuarioC.Enter += new System.EventHandler(this.textUsuarioC_Enter);
            this.textUsuarioC.Leave += new System.EventHandler(this.textUsuarioC_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Usuário";
            // 
            // textSenhaC
            // 
            this.textSenhaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenhaC.ForeColor = System.Drawing.Color.Silver;
            this.textSenhaC.Location = new System.Drawing.Point(141, 209);
            this.textSenhaC.Name = "textSenhaC";
            this.textSenhaC.Size = new System.Drawing.Size(171, 23);
            this.textSenhaC.TabIndex = 9;
            this.textSenhaC.Tag = "";
            this.textSenhaC.Text = "Insira sua senha...";
            this.textSenhaC.TextChanged += new System.EventHandler(this.textSenhaC_TextChanged);
            this.textSenhaC.Enter += new System.EventHandler(this.textSenhaC_Enter);
            this.textSenhaC.Leave += new System.EventHandler(this.textSenhaC_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Senha";
            // 
            // textConfirmaSenha
            // 
            this.textConfirmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConfirmaSenha.ForeColor = System.Drawing.Color.Silver;
            this.textConfirmaSenha.Location = new System.Drawing.Point(141, 254);
            this.textConfirmaSenha.Name = "textConfirmaSenha";
            this.textConfirmaSenha.Size = new System.Drawing.Size(171, 23);
            this.textConfirmaSenha.TabIndex = 11;
            this.textConfirmaSenha.Tag = "";
            this.textConfirmaSenha.Text = "Confirme sua senha...";
            this.textConfirmaSenha.Enter += new System.EventHandler(this.textConfirmaSenha_Enter);
            this.textConfirmaSenha.Leave += new System.EventHandler(this.textConfirmaSenha_Leave);
            this.textConfirmaSenha.Validated += new System.EventHandler(this.textConfirmaSenha_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Confirmar senha";
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(141, 372);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastro.TabIndex = 12;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(566, 168);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(647, 168);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 8;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdmin.Location = new System.Drawing.Point(566, 220);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(79, 21);
            this.checkBoxAdmin.TabIndex = 17;
            this.checkBoxAdmin.Text = "É Admin";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(315, 259);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(168, 15);
            this.lblErro.TabIndex = 18;
            this.lblErro.Text = "Por favor digite a senha igual ";
            this.lblErro.Visible = false;
            // 
            // lblErro1
            // 
            this.lblErro1.AutoSize = true;
            this.lblErro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro1.ForeColor = System.Drawing.Color.Red;
            this.lblErro1.Location = new System.Drawing.Point(315, 212);
            this.lblErro1.Name = "lblErro1";
            this.lblErro1.Size = new System.Drawing.Size(155, 15);
            this.lblErro1.TabIndex = 19;
            this.lblErro1.Text = "Formato de senha inválido ";
            // 
            // pictureUsuario
            // 
            this.pictureUsuario.BackColor = System.Drawing.Color.SeaShell;
            this.pictureUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureUsuario.Location = new System.Drawing.Point(566, 27);
            this.pictureUsuario.Name = "pictureUsuario";
            this.pictureUsuario.Size = new System.Drawing.Size(156, 117);
            this.pictureUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUsuario.TabIndex = 16;
            this.pictureUsuario.TabStop = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErro1);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.pictureUsuario);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.textConfirmaSenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textSenhaC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textUsuarioC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNum);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSobrenome);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastro";
            this.Text = "Novo Usuário - AirSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastro_FormClosing);
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textSobrenome;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textUsuarioC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSenhaC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textConfirmaSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.PictureBox pictureUsuario;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label lblErro1;
    }
}
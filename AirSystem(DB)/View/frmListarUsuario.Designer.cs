namespace AirSystem.View
{
    partial class frmListarUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListaAluno = new System.Windows.Forms.DataGridView();
            this.textBuscaNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.pictureUsuario1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNome1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSobrenome1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEndereco1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUsuario1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEnderecoNum1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxSenha1 = new System.Windows.Forms.TextBox();
            this.textBoxConfirmaSenha1 = new System.Windows.Forms.TextBox();
            this.btnAlterar1 = new System.Windows.Forms.Button();
            this.btnDeletar1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuario1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaAluno
            // 
            this.dgvListaAluno.AllowUserToAddRows = false;
            this.dgvListaAluno.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaAluno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAluno.Location = new System.Drawing.Point(12, 29);
            this.dgvListaAluno.MultiSelect = false;
            this.dgvListaAluno.Name = "dgvListaAluno";
            this.dgvListaAluno.ReadOnly = true;
            this.dgvListaAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaAluno.Size = new System.Drawing.Size(358, 389);
            this.dgvListaAluno.TabIndex = 0;
            this.dgvListaAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAluno_CellClick);
            this.dgvListaAluno.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvListaAluno_DataError);
            // 
            // textBuscaNome
            // 
            this.textBuscaNome.BackColor = System.Drawing.Color.White;
            this.textBuscaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscaNome.ForeColor = System.Drawing.Color.Black;
            this.textBuscaNome.Location = new System.Drawing.Point(69, 448);
            this.textBuscaNome.Name = "textBuscaNome";
            this.textBuscaNome.Size = new System.Drawing.Size(171, 23);
            this.textBuscaNome.TabIndex = 2;
            this.textBuscaNome.Tag = "";
            this.textBuscaNome.TextChanged += new System.EventHandler(this.textBuscaNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(413, 479);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(549, 479);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(630, 479);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(711, 479);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 7;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // pictureUsuario1
            // 
            this.pictureUsuario1.BackColor = System.Drawing.Color.SeaShell;
            this.pictureUsuario1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureUsuario1.Location = new System.Drawing.Point(513, 29);
            this.pictureUsuario1.Name = "pictureUsuario1";
            this.pictureUsuario1.Size = new System.Drawing.Size(156, 117);
            this.pictureUsuario1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUsuario1.TabIndex = 17;
            this.pictureUsuario1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Dados do Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nome:";
            // 
            // textBoxNome1
            // 
            this.textBoxNome1.BackColor = System.Drawing.Color.White;
            this.textBoxNome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome1.ForeColor = System.Drawing.Color.Black;
            this.textBoxNome1.Location = new System.Drawing.Point(513, 173);
            this.textBoxNome1.Name = "textBoxNome1";
            this.textBoxNome1.Size = new System.Drawing.Size(171, 23);
            this.textBoxNome1.TabIndex = 19;
            this.textBoxNome1.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sobrenome:";
            // 
            // textBoxSobrenome1
            // 
            this.textBoxSobrenome1.BackColor = System.Drawing.Color.White;
            this.textBoxSobrenome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSobrenome1.ForeColor = System.Drawing.Color.Black;
            this.textBoxSobrenome1.Location = new System.Drawing.Point(513, 224);
            this.textBoxSobrenome1.Name = "textBoxSobrenome1";
            this.textBoxSobrenome1.Size = new System.Drawing.Size(171, 23);
            this.textBoxSobrenome1.TabIndex = 21;
            this.textBoxSobrenome1.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Endereço:";
            // 
            // textBoxEndereco1
            // 
            this.textBoxEndereco1.BackColor = System.Drawing.Color.White;
            this.textBoxEndereco1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEndereco1.ForeColor = System.Drawing.Color.Black;
            this.textBoxEndereco1.Location = new System.Drawing.Point(513, 273);
            this.textBoxEndereco1.Name = "textBoxEndereco1";
            this.textBoxEndereco1.Size = new System.Drawing.Size(171, 23);
            this.textBoxEndereco1.TabIndex = 23;
            this.textBoxEndereco1.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nascimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Usuário:";
            // 
            // textBoxUsuario1
            // 
            this.textBoxUsuario1.BackColor = System.Drawing.Color.White;
            this.textBoxUsuario1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario1.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsuario1.Location = new System.Drawing.Point(513, 362);
            this.textBoxUsuario1.Name = "textBoxUsuario1";
            this.textBoxUsuario1.Size = new System.Drawing.Size(171, 23);
            this.textBoxUsuario1.TabIndex = 27;
            this.textBoxUsuario1.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(690, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Nº";
            // 
            // textBoxEnderecoNum1
            // 
            this.textBoxEnderecoNum1.BackColor = System.Drawing.Color.White;
            this.textBoxEnderecoNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnderecoNum1.ForeColor = System.Drawing.Color.Black;
            this.textBoxEnderecoNum1.Location = new System.Drawing.Point(724, 273);
            this.textBoxEnderecoNum1.Name = "textBoxEnderecoNum1";
            this.textBoxEnderecoNum1.Size = new System.Drawing.Size(64, 23);
            this.textBoxEnderecoNum1.TabIndex = 29;
            this.textBoxEnderecoNum1.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(376, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Senha:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(376, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Confirmar Senha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(513, 315);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 23);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // textBoxSenha1
            // 
            this.textBoxSenha1.BackColor = System.Drawing.Color.White;
            this.textBoxSenha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha1.ForeColor = System.Drawing.Color.Black;
            this.textBoxSenha1.Location = new System.Drawing.Point(513, 398);
            this.textBoxSenha1.Name = "textBoxSenha1";
            this.textBoxSenha1.Size = new System.Drawing.Size(171, 23);
            this.textBoxSenha1.TabIndex = 34;
            this.textBoxSenha1.Tag = "";
            // 
            // textBoxConfirmaSenha1
            // 
            this.textBoxConfirmaSenha1.BackColor = System.Drawing.Color.White;
            this.textBoxConfirmaSenha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmaSenha1.ForeColor = System.Drawing.Color.Black;
            this.textBoxConfirmaSenha1.Location = new System.Drawing.Point(513, 429);
            this.textBoxConfirmaSenha1.Name = "textBoxConfirmaSenha1";
            this.textBoxConfirmaSenha1.Size = new System.Drawing.Size(171, 23);
            this.textBoxConfirmaSenha1.TabIndex = 35;
            this.textBoxConfirmaSenha1.Tag = "";
            // 
            // btnAlterar1
            // 
            this.btnAlterar1.BackColor = System.Drawing.Color.White;
            this.btnAlterar1.Location = new System.Drawing.Point(694, 29);
            this.btnAlterar1.Name = "btnAlterar1";
            this.btnAlterar1.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar1.TabIndex = 36;
            this.btnAlterar1.Text = "Alterar";
            this.btnAlterar1.UseVisualStyleBackColor = false;
            this.btnAlterar1.Click += new System.EventHandler(this.btnAlterar1_Click);
            // 
            // btnDeletar1
            // 
            this.btnDeletar1.BackColor = System.Drawing.Color.White;
            this.btnDeletar1.Location = new System.Drawing.Point(694, 72);
            this.btnDeletar1.Name = "btnDeletar1";
            this.btnDeletar1.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar1.TabIndex = 37;
            this.btnDeletar1.Text = "Deletar";
            this.btnDeletar1.UseVisualStyleBackColor = false;
            this.btnDeletar1.Click += new System.EventHandler(this.btnDeletar1_Click);
            // 
            // frmListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.btnDeletar1);
            this.Controls.Add(this.btnAlterar1);
            this.Controls.Add(this.textBoxConfirmaSenha1);
            this.Controls.Add(this.textBoxSenha1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxEnderecoNum1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxUsuario1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEndereco1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSobrenome1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNome1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureUsuario1);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBuscaNome);
            this.Controls.Add(this.dgvListaAluno);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListarUsuario";
            this.Text = "Listar Usuario - AirSystem";
            this.Load += new System.EventHandler(this.frmListarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuario1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaAluno;
        private System.Windows.Forms.TextBox textBuscaNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.PictureBox pictureUsuario1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNome1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSobrenome1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEndereco1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUsuario1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEnderecoNum1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxSenha1;
        private System.Windows.Forms.TextBox textBoxConfirmaSenha1;
        private System.Windows.Forms.Button btnAlterar1;
        private System.Windows.Forms.Button btnDeletar1;
    }
}
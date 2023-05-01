namespace SistemaLogin
{
    partial class FormLogin
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
            this.usuario = new System.Windows.Forms.Label();
            this.texUsuario = new System.Windows.Forms.TextBox();
            this.texSen = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.Label();
            this.btnCance = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(13, 13);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(64, 20);
            this.usuario.TabIndex = 0;
            this.usuario.Text = "Usuário";
            // 
            // texUsuario
            // 
            this.texUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texUsuario.Location = new System.Drawing.Point(12, 51);
            this.texUsuario.Name = "texUsuario";
            this.texUsuario.Size = new System.Drawing.Size(255, 26);
            this.texUsuario.TabIndex = 1;
            // 
            // texSen
            // 
            this.texSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texSen.Location = new System.Drawing.Point(12, 149);
            this.texSen.Name = "texSen";
            this.texSen.PasswordChar = '*';
            this.texSen.Size = new System.Drawing.Size(255, 26);
            this.texSen.TabIndex = 3;
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(13, 111);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(56, 20);
            this.senha.TabIndex = 2;
            this.senha.Text = "Senha";
            // 
            // btnCance
            // 
            this.btnCance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCance.Location = new System.Drawing.Point(12, 213);
            this.btnCance.Name = "btnCance";
            this.btnCance.Size = new System.Drawing.Size(119, 33);
            this.btnCance.TabIndex = 4;
            this.btnCance.Text = "Cancelar";
            this.btnCance.UseVisualStyleBackColor = true;
            this.btnCance.Click += new System.EventHandler(this.btnCance_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(148, 213);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(119, 33);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Entrar";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // FormLogin
            // 
            this.ClientSize = new System.Drawing.Size(335, 285);
            this.ControlBox = false;
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnCance);
            this.Controls.Add(this.texSen);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.texUsuario);
            this.Controls.Add(this.usuario);
            this.Name = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.TextBox texUsuario;
        private System.Windows.Forms.TextBox texSen;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.Button btnCance;
        private System.Windows.Forms.Button btnEnter;
    }
}
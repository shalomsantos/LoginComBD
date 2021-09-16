
namespace Banco_de_dados.Apresentação
{
    partial class formCadastreSe
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbComTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(43, 247);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(232, 37);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(43, 83);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(232, 29);
            this.txbNome.TabIndex = 5;
            this.txbNome.Text = "Nome";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(43, 143);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(232, 29);
            this.txbTelefone.TabIndex = 6;
            this.txbTelefone.Text = "Telefone";
            // 
            // txbComTelefone
            // 
            this.txbComTelefone.Location = new System.Drawing.Point(43, 202);
            this.txbComTelefone.Name = "txbComTelefone";
            this.txbComTelefone.Size = new System.Drawing.Size(232, 29);
            this.txbComTelefone.TabIndex = 7;
            this.txbComTelefone.Text = "Confirm. Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Novo Cadastro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Evento click no input limpa capos para preenchimento";
            // 
            // formCadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbComTelefone);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "formCadastreSe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formCadastreSe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbComTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
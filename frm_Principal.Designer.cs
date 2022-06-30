
namespace ProjetoAlura
{
    partial class frm_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.txt_Texto = new System.Windows.Forms.TextBox();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.lbl_Informação = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(94, 164);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Mostrar.TabIndex = 0;
            this.btn_Mostrar.Text = "Clique aqui";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // txt_Texto
            // 
            this.txt_Texto.Location = new System.Drawing.Point(94, 220);
            this.txt_Texto.Name = "txt_Texto";
            this.txt_Texto.Size = new System.Drawing.Size(100, 20);
            this.txt_Texto.TabIndex = 1;
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Location = new System.Drawing.Point(91, 148);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(137, 13);
            this.lbl_Texto.TabIndex = 2;
            this.lbl_Texto.Text = "Seu texto vai aparecer aqui";
            // 
            // lbl_Informação
            // 
            this.lbl_Informação.AutoSize = true;
            this.lbl_Informação.Location = new System.Drawing.Point(91, 204);
            this.lbl_Informação.Name = "lbl_Informação";
            this.lbl_Informação.Size = new System.Drawing.Size(92, 13);
            this.lbl_Informação.TabIndex = 3;
            this.lbl_Informação.Text = "Escreva um texto ";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(94, 262);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_Fechar.TabIndex = 4;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.lbl_Informação);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.txt_Texto);
            this.Controls.Add(this.btn_Mostrar);
            this.Name = "frm_Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.TextBox txt_Texto;
        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.Label lbl_Informação;
        private System.Windows.Forms.Button btn_Fechar;
    }
}


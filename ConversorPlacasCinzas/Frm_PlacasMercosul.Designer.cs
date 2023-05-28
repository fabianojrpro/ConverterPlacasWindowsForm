namespace ConversorPlacasCinzas
{
    partial class Frm_Conversor
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
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Btn_Importar = new System.Windows.Forms.Button();
            this.Pgb_BarraDeProgresso = new System.Windows.Forms.ProgressBar();
            this.Lbl_TextoAjuda = new System.Windows.Forms.Label();
            this.Lbl_Mensagem = new System.Windows.Forms.Label();
            this.Btn_Reiniciar = new System.Windows.Forms.Button();
            this.Ptb_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Location = new System.Drawing.Point(397, 226);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fechar.TabIndex = 0;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Btn_Importar
            // 
            this.Btn_Importar.Location = new System.Drawing.Point(194, 154);
            this.Btn_Importar.Name = "Btn_Importar";
            this.Btn_Importar.Size = new System.Drawing.Size(94, 33);
            this.Btn_Importar.TabIndex = 1;
            this.Btn_Importar.Text = "Upload";
            this.Btn_Importar.UseVisualStyleBackColor = true;
            this.Btn_Importar.Click += new System.EventHandler(this.Btn_Importar_Click);
            // 
            // Pgb_BarraDeProgresso
            // 
            this.Pgb_BarraDeProgresso.Location = new System.Drawing.Point(165, 193);
            this.Pgb_BarraDeProgresso.Name = "Pgb_BarraDeProgresso";
            this.Pgb_BarraDeProgresso.Size = new System.Drawing.Size(152, 16);
            this.Pgb_BarraDeProgresso.TabIndex = 2;
            this.Pgb_BarraDeProgresso.Visible = false;
            // 
            // Lbl_TextoAjuda
            // 
            this.Lbl_TextoAjuda.AutoSize = true;
            this.Lbl_TextoAjuda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TextoAjuda.Location = new System.Drawing.Point(147, 115);
            this.Lbl_TextoAjuda.Name = "Lbl_TextoAjuda";
            this.Lbl_TextoAjuda.Size = new System.Drawing.Size(193, 18);
            this.Lbl_TextoAjuda.TabIndex = 3;
            this.Lbl_TextoAjuda.Text = "Escolha um arquivo .txt";
            this.Lbl_TextoAjuda.Click += new System.EventHandler(this.Lbl_TextoAjuda_Click);
            // 
            // Lbl_Mensagem
            // 
            this.Lbl_Mensagem.AutoSize = true;
            this.Lbl_Mensagem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mensagem.Location = new System.Drawing.Point(125, 133);
            this.Lbl_Mensagem.Name = "Lbl_Mensagem";
            this.Lbl_Mensagem.Size = new System.Drawing.Size(245, 18);
            this.Lbl_Mensagem.TabIndex = 4;
            this.Lbl_Mensagem.Text = "Arquivo gerado com sucesso!";
            this.Lbl_Mensagem.Visible = false;
            this.Lbl_Mensagem.Click += new System.EventHandler(this.Lbl_Mensagem_Click);
            // 
            // Btn_Reiniciar
            // 
            this.Btn_Reiniciar.Location = new System.Drawing.Point(316, 226);
            this.Btn_Reiniciar.Name = "Btn_Reiniciar";
            this.Btn_Reiniciar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Reiniciar.TabIndex = 5;
            this.Btn_Reiniciar.Text = "Reiniciar";
            this.Btn_Reiniciar.UseVisualStyleBackColor = true;
            this.Btn_Reiniciar.Click += new System.EventHandler(this.Btn_Reiniciar_Click);
            // 
            // Ptb_Logo
            // 
            this.Ptb_Logo.Image = global::ConversorPlacasCinzas.Properties.Resources.fashion__1_;
            this.Ptb_Logo.Location = new System.Drawing.Point(194, 12);
            this.Ptb_Logo.Name = "Ptb_Logo";
            this.Ptb_Logo.Size = new System.Drawing.Size(101, 96);
            this.Ptb_Logo.TabIndex = 6;
            this.Ptb_Logo.TabStop = false;
            // 
            // Frm_Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.Ptb_Logo);
            this.Controls.Add(this.Btn_Reiniciar);
            this.Controls.Add(this.Lbl_Mensagem);
            this.Controls.Add(this.Lbl_TextoAjuda);
            this.Controls.Add(this.Pgb_BarraDeProgresso);
            this.Controls.Add(this.Btn_Importar);
            this.Controls.Add(this.Btn_Fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Frm_Conversor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Placas mercosul";
            this.Load += new System.EventHandler(this.Frm_Conversor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Button Btn_Importar;
        private System.Windows.Forms.ProgressBar Pgb_BarraDeProgresso;
        private System.Windows.Forms.Label Lbl_TextoAjuda;
        private System.Windows.Forms.Label Lbl_Mensagem;
        private System.Windows.Forms.Button Btn_Reiniciar;
        private System.Windows.Forms.PictureBox Ptb_Logo;
    }
}


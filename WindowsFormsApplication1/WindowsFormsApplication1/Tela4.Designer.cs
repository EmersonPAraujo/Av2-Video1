namespace WindowsFormsApplication1
{
    partial class Tela4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela4));
            this.BtnContinuar = new System.Windows.Forms.Button();
            this.Tema1 = new System.Windows.Forms.Label();
            this.txtResumo = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.BtnResumo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinuar.Location = new System.Drawing.Point(328, 361);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(166, 54);
            this.BtnContinuar.TabIndex = 16;
            this.BtnContinuar.Text = "Continuar";
            this.BtnContinuar.UseVisualStyleBackColor = true;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // Tema1
            // 
            this.Tema1.AutoSize = true;
            this.Tema1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tema1.Location = new System.Drawing.Point(24, 20);
            this.Tema1.Name = "Tema1";
            this.Tema1.Size = new System.Drawing.Size(535, 136);
            this.Tema1.TabIndex = 15;
            this.Tema1.Text = "Agora fale em voz alta o que você\r\naprendeu sobre o assunto, e depois \r\ncompare c" +
    "om o resumo que foi \r\nfeito no passo anterior.";
            this.Tema1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtResumo
            // 
            this.txtResumo.AutoSize = true;
            this.txtResumo.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResumo.Location = new System.Drawing.Point(54, 182);
            this.txtResumo.MaximumSize = new System.Drawing.Size(500, 100);
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(477, 80);
            this.txtResumo.TabIndex = 17;
            this.txtResumo.Text = resources.GetString("txtResumo.Text");
            this.txtResumo.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(58, 361);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(166, 54);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // BtnResumo
            // 
            this.BtnResumo.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResumo.Location = new System.Drawing.Point(204, 294);
            this.BtnResumo.Name = "BtnResumo";
            this.BtnResumo.Size = new System.Drawing.Size(178, 41);
            this.BtnResumo.TabIndex = 19;
            this.BtnResumo.Text = "Exibir Resumo";
            this.BtnResumo.UseVisualStyleBackColor = true;
            this.BtnResumo.Click += new System.EventHandler(this.BtnResumo_Click);
            // 
            // Tela4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 427);
            this.Controls.Add(this.BtnResumo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.BtnContinuar);
            this.Controls.Add(this.Tema1);
            this.Name = "Tela4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnContinuar;
        private System.Windows.Forms.Label Tema1;
        private System.Windows.Forms.Label txtResumo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button BtnResumo;
    }
}
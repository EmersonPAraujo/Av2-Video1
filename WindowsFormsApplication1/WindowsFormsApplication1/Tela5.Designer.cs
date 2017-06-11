namespace WindowsFormsApplication1
{
    partial class Tela5
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
            this.btnVoltar3 = new System.Windows.Forms.Button();
            this.BtnContinuar = new System.Windows.Forms.Button();
            this.Tema1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltar3
            // 
            this.btnVoltar3.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar3.Location = new System.Drawing.Point(220, 242);
            this.btnVoltar3.Name = "btnVoltar3";
            this.btnVoltar3.Size = new System.Drawing.Size(166, 54);
            this.btnVoltar3.TabIndex = 23;
            this.btnVoltar3.Text = "Retornar";
            this.btnVoltar3.UseVisualStyleBackColor = true;
            this.btnVoltar3.Click += new System.EventHandler(this.btnVoltar3_Click);
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinuar.Location = new System.Drawing.Point(220, 344);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(166, 54);
            this.BtnContinuar.TabIndex = 21;
            this.BtnContinuar.Text = "Continuar";
            this.BtnContinuar.UseVisualStyleBackColor = true;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // Tema1
            // 
            this.Tema1.AutoSize = true;
            this.Tema1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tema1.Location = new System.Drawing.Point(12, 18);
            this.Tema1.Name = "Tema1";
            this.Tema1.Size = new System.Drawing.Size(560, 136);
            this.Tema1.TabIndex = 20;
            this.Tema1.Text = "Se durante o passo anterior você teve \r\ndificuldade em algum ponto, está na \r\nhor" +
    "a de revisar o assunto, retorne ao\r\n 3° passo.";
            this.Tema1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Tela5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 427);
            this.Controls.Add(this.btnVoltar3);
            this.Controls.Add(this.BtnContinuar);
            this.Controls.Add(this.Tema1);
            this.Name = "Tela5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar3;
        private System.Windows.Forms.Button BtnContinuar;
        private System.Windows.Forms.Label Tema1;
    }
}
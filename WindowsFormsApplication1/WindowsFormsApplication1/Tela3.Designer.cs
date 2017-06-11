namespace WindowsFormsApplication1
{
    partial class Tela3
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
            this.button1 = new System.Windows.Forms.Button();
            this.Tema1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 68);
            this.label1.TabIndex = 12;
            this.label1.Text = "Faça um breve resumo sobre o que \r\nvocê já entendeu sobre o assunto.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(198, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tema1
            // 
            this.Tema1.AutoSize = true;
            this.Tema1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tema1.Location = new System.Drawing.Point(46, 33);
            this.Tema1.Name = "Tema1";
            this.Tema1.Size = new System.Drawing.Size(493, 68);
            this.Tema1.TabIndex = 9;
            this.Tema1.Text = "Agora está na hora de começar a \r\nestudar como de costume.";
            this.Tema1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 264);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(557, 75);
            this.txtDescricao.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Máximo 200 Caracteres";
            // 
            // Tela3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tema1);
            this.Name = "Tela3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Tema1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
    }
}
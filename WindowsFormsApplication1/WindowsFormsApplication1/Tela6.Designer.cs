namespace WindowsFormsApplication1
{
    partial class Tela6
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
            this.Tema1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tema1
            // 
            this.Tema1.AutoSize = true;
            this.Tema1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tema1.Location = new System.Drawing.Point(22, 9);
            this.Tema1.Name = "Tema1";
            this.Tema1.Size = new System.Drawing.Size(534, 204);
            this.Tema1.TabIndex = 24;
            this.Tema1.Text = "Faça um outro resumo, mas dessa \r\nvez de forma mais simplificada, \r\nde forma que " +
    "a maioria das pessoas\r\npossa compreender o assunto, se \r\npossível inclua imagens" +
    " para deixar \r\ntudo mais claro.";
            this.Tema1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 223);
            this.label1.MaximumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 68);
            this.label1.TabIndex = 25;
            this.label1.Text = "Você conseguiu fazer o resumo simples do seu estudo?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F);
            this.button1.Location = new System.Drawing.Point(392, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 54);
            this.button1.TabIndex = 26;
            this.button1.Text = "Sim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F);
            this.button2.Location = new System.Drawing.Point(74, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 54);
            this.button2.TabIndex = 27;
            this.button2.Text = "Não";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tela6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 427);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tema1);
            this.Name = "Tela6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tema1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
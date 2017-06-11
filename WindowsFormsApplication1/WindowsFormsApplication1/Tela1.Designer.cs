namespace WindowsFormsApplication1
{
    partial class Tela1
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
            this.BtnSim1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tema1
            // 
            this.Tema1.AutoSize = true;
            this.Tema1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tema1.Location = new System.Drawing.Point(36, 29);
            this.Tema1.Name = "Tema1";
            this.Tema1.Size = new System.Drawing.Size(503, 102);
            this.Tema1.TabIndex = 0;
            this.Tema1.Text = "Primeiro, escolha o tema que você\r\ndeseja estudar ou que queira\r\naprimorar seu co" +
    "nheimento.";
            this.Tema1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnSim1
            // 
            this.BtnSim1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSim1.Location = new System.Drawing.Point(127, 347);
            this.BtnSim1.Name = "BtnSim1";
            this.BtnSim1.Size = new System.Drawing.Size(102, 54);
            this.BtnSim1.TabIndex = 2;
            this.BtnSim1.Text = "Sim";
            this.BtnSim1.UseVisualStyleBackColor = true;
            this.BtnSim1.Click += new System.EventHandler(this.BtnSim1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(325, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "Não";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Você já escolheu o seu tema?";
            // 
            // Tela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSim1);
            this.Controls.Add(this.Tema1);
            this.Name = "Tela1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tema1;
        private System.Windows.Forms.Button BtnSim1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button2;
    }
}
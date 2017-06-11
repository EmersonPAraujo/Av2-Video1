using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Tela6 : Form
    {
        public Tela6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parabéns você consegiu estudar com metodologia Feynman");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensagem = "Realize o resumo para completar a metodologia Feynman." +
                               "\nVocê deseja continuar ?";
            string aviso = "Aviso!";
            //MessageBox.Show(mensagem);
            MessageBoxButtons botao = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show(mensagem, aviso ,botao,MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                var novamente = new TelaInicial();
                novamente.ShowDialog();
            }
            else
            {
                this.Close();
            }
        }
    }
}

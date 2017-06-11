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
    public partial class Tela4 : Form
    {
        public Tela4()
        {
            InitializeComponent();
        }

        public Tela4(string texto)
        {
            InitializeComponent();
            txtResumo.Text = texto;
            txtResumo.Visible = false;
            
        }

        private void BtnResumo_Click(object sender, EventArgs e)
        {
            txtResumo.Visible = true;
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            var continuar = new Tela5();
            continuar.ShowDialog();
            this.Close();

        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var voltar = new Tela3();
            voltar.ShowDialog();
            this.Close();

        }
    }
}

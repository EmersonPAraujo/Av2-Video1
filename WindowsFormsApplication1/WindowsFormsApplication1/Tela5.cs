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
    public partial class Tela5 : Form
    {
        public Tela5()
        {
            InitializeComponent();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            var tela6 = new Tela6();
            tela6.ShowDialog();
            this.Close();

        }

        private void btnVoltar3_Click(object sender, EventArgs e)
        {
            var retornar = new Tela4();
            retornar.ShowDialog();
            this.Close();

        }
    }
}

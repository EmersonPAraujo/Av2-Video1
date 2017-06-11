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
    public partial class Tela2 : Form
    {
        public Tela2()
        {
            InitializeComponent();
        }

        private void BtnSim2_Click(object sender, EventArgs e)
        {
            var tela3 = new Tela3();
            tela3.ShowDialog();
            this.Close();

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            var frmMetodo = new Tela1();
            frmMetodo.MensagemAlternativa();
            this.Close();

        }
    }
}

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
    public partial class Tela1 : Form
    {
        public Tela1()
        {
            InitializeComponent();
            //this.Hide();
        }

        private void BtnSim1_Click(object sender, EventArgs e)
        {
            var tela2 = new Tela2();
            tela2.ShowDialog();
            Hide();
        }



        public void MensagemAlternativa()
        {
            MessageBox.Show("Por favor realize atividade que está sendo pedida nessa tela");
            this.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            MensagemAlternativa();
            this.Close();

        }
    }
}

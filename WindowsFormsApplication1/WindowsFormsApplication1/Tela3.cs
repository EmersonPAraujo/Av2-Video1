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
    public partial class Tela3 : Form
    {
        public Tela3()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tela4 = new Tela4(txtDescricao.Text);
            tela4.ShowDialog();
            this.Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAlura
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            lbl_Texto.Text = txt_Texto.Text;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

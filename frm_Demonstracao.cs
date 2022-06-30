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
    public partial class frm_Demonstracao : Form
    {
        public frm_Demonstracao()
        {
            InitializeComponent();
        }

        private void txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            txt_Msg.AppendText("\r\n" + "Pressionei uma tecla: " + e.KeyCode + "\r\n");
            lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Input.Text = "";
            txt_Msg.Text = "";
            lbl_Lower.Text = "";
            lbl_Maius.Text = "";
            lbl_Menos.Text = "";
            lbl_Upper.Text = "";
        }
    }
}

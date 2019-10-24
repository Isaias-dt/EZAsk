using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZAsk.Helper;

namespace EZAsk
{
    public partial class FrmForum : Form
    {
        
        public FrmForum()
        {
            InitializeComponent();
        }

        private void FrmForum_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FrmForum_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'eZAskDataSet.Forum'. Você pode movê-la ou removê-la conforme necessário.
            //this.forumTableAdapter.Fill(this.eZAskDataSet.Forum);
            this.WindowState = FormWindowState.Maximized; // maximinizando a form Forum dentro do conteiner principal.
        }

        private void grdForum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new FrmResponder().ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
          
        }
    }
}

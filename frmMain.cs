using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoe_Collection
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnshoes_Click(object sender, EventArgs e)
        {
            frmShoes frmShoes = new frmShoes();
            frmShoes.ShowDialog();
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            frmsupplier frmsupplier = new frmsupplier();
            frmsupplier.ShowDialog();
        }

        private void btnowner_Click(object sender, EventArgs e)
        {
            frmowner frmowner = new frmowner();
            frmowner.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmorders frmorders = new frmorders();
            frmorders.ShowDialog();
        }

        private void btnshoesupplier_Click(object sender, EventArgs e)
        {
            frmshoesupplier frmshoesupplier = new frmshoesupplier();
            frmshoesupplier.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            frmshoeowner frmshoeowner = new frmshoeowner();
            frmshoeowner.ShowDialog();
        }

        private void btnshoeowner_Click(object sender, EventArgs e)
        {
            frmshoeowner frmshoeowner1 = new frmshoeowner();
        }

        private void btnorderitems_Click(object sender, EventArgs e)
        {
            frmorderitems frmorderitems = new frmorderitems();
            frmorderitems.ShowDialog();
        }
    }
}

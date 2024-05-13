using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapelInventoryManagement
{
    public partial class Borrow : Form
    {
        private OleDbConnection con = Connections.GetConnection();
        public Borrow()
        {
            InitializeComponent();
        }

        private void loaddatagrid()
        {
            using (OleDbConnection con = Connections.GetConnection())
            {
                con.Open();

                OleDbCommand items = new OleDbCommand("SELECT * FROM Items", con);

                OleDbDataAdapter adap = new OleDbDataAdapter(items);
                DataTable dt = new DataTable();
                adap.Fill(dt);

                dgvItems.DataSource = dt;
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtItem.Clear();
            txtQty.Clear();
            txtAvail.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_СОЦЗАЩИАТ
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        void Sotrudniki()
        {
            string sq = @"SELECT        fam, name, otch, phone
FROM            Users
where typeuser = 2";
            SqlConnection con = new SqlConnection(FormAftorization.txtcon);
            con.Open();
            SqlCommand q = new SqlCommand(sq, con);
            SqlDataReader rez = q.ExecuteReader();
            while (rez.Read())
                dgvWork.Rows.Add(rez["fam"], rez["name"], rez["otch"], rez["phone"]);
            con.Close();
        }

        void Add()
        {
            if (tbAdd.Text.Trim() == "")
                return;
            string sq = $@"insert into PT
values ('{tbAdd.Text}')";
            SqlConnection con = new SqlConnection(FormAftorization.txtcon);
            con.Open();
            SqlCommand q = new SqlCommand(sq, con);
            q.ExecuteNonQuery();
            con.Close();
        }
        void Search()
        {
            dgvWork.Rows.Clear();
            if (tbSearch.Text.Trim() == "")
                return;
            string sq = $@"SELECT        fam, name, otch, phone
FROM            Users
where fam like '{tbSearch.Text}%'and typeuser = 2";
            SqlConnection con = new SqlConnection(FormAftorization.txtcon);
            con.Open();
            SqlCommand q = new SqlCommand(sq, con);
            SqlDataReader rez = q.ExecuteReader();
            while (rez.Read())
                dgvWork.Rows.Add(rez["fam"], rez["name"], rez["otch"], rez["phone"]);
            con.Close();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'соцзащитаDataSet.PT' table. You can move, or remove it, as needed.
            this.pTTableAdapter.Fill(this.соцзащитаDataSet.PT);
            // TODO: This line of code loads data into the 'соцзащитаDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.соцзащитаDataSet.Users);
            Sotrudniki();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Add();
            pTTableAdapter.Fill(this.соцзащитаDataSet.PT);
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drv in dgvPT.SelectedRows)
                dgvPT.Rows.RemoveAt(drv.Index);
            bsPT.EndEdit();
            pTTableAdapter.Update(this.соцзащитаDataSet.PT);
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            Search();
            if(tbSearch.Text.Trim() == "")
            {
                dgvWork.Rows.Clear();
                Sotrudniki();
            }
        }

        private void bProf_Click(object sender, EventArgs e)
        {
            FormEdit frm = new FormEdit();
            frm.bsUsers.Filter = bsUsers.Filter;
            frm.ShowDialog();
        }
    }
}

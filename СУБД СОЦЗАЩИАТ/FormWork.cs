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
using Excel = Microsoft.Office.Interop.Excel;

namespace СУБД_СОЦЗАЩИАТ
{
    public partial class FormWork : Form
    {
        public FormWork()
        {
            InitializeComponent();
        }
        void Users()
        {
            string sq = @"SELECT        fam, name, otch, phone, iduser
FROM            Users
where typeuser = 1";
            SqlConnection con = new SqlConnection(FormAftorization.txtcon);
            con.Open();
            SqlCommand q = new SqlCommand(sq, con);
            SqlDataReader rez = q.ExecuteReader();
            while (rez.Read())
                dgvUsers.Rows.Add(rez["fam"], rez["name"], rez["otch"], rez["phone"], rez["iduser"]);
            con.Close();
        }

        void Rez()
        {
            string sq = @"SELECT        Rez.iduser, PT.namept, Rez.rez, Rez.data, PT.idpt, Rez.idrez
FROM            PT INNER JOIN
                         Rez ON PT.idpt = Rez.idposob";
            SqlConnection con = new SqlConnection(FormAftorization.txtcon);
            con.Open();
            SqlCommand q = new SqlCommand(sq, con);
            SqlDataReader rez = q.ExecuteReader();
            while (rez.Read())
                dgvRez.Rows.Add(rez["iduser"], rez["namept"], rez["rez"], rez["data"], rez["idpt"], rez["idrez"]);
            con.Close();
        }
        
        private void FormWork_Load(object sender, EventArgs e)
        {
         
            // TODO: This line of code loads data into the 'соцзащитаDataSet.Rez' table. You can move, or remove it, as needed.
            this.rezTableAdapter.Fill(this.соцзащитаDataSet.Rez);
            // TODO: This line of code loads data into the 'соцзащитаDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.соцзащитаDataSet.Users);
            // TODO: This line of code loads data into the 'соцзащитаDataSet.Rez' table. You can move, or remove it, as needed.
            Rez();
            Users();
        }

        private void bSaveDoc_Click(object sender, EventArgs e)
        {
            int row = 1;
            Excel.Application ex = new Excel.Application();
            ex.Visible = true;
            ex.Workbooks.Open(Application.StartupPath + "\\Данные.xlsx", null, true);
            Excel.Worksheet l1 = ex.Worksheets.get_Item(1);
            for(int i = 0; i <= dgvUsers.RowCount - 1; i++)
            {
                l1.get_Range("A" + row).Value = dgvUsers.Rows[i].Cells[0].Value;
                l1.get_Range("B" + row).Value = dgvUsers.Rows[i].Cells[1].Value;
                l1.get_Range("C" + row).Value = dgvUsers.Rows[i].Cells[2].Value;
                l1.get_Range("D" + row).Value = dgvUsers.Rows[i].Cells[3].Value;
                row++;
            }
        }

        private void bTrue_Click(object sender, EventArgs e)
        {
            if (tbSum.Text.Trim() == "")
                return;
            for (int i = 0; i <= tbSum.Text.Length; i++)
            {
                if (char.IsLetter(tbSum.Text[i]))
                    return;
            }
            SqlConnection con = new SqlConnection(FormAftorization.txtcon);
            con.Open();
            foreach (DataGridViewRow drv in dgvRez.SelectedRows)
            {
                bool f = bool.Parse(dgvRez.Rows[drv.Index].Cells[2].Value.ToString());
                if (f)
                    return;
                string sq = $@"Update Rez
set rez = 1
where iduser = {dgvRez.Rows[drv.Index].Cells[0].Value} and idrez = {dgvRez.Rows[drv.Index].Cells[5].Value}";
                SqlCommand q = new SqlCommand(sq, con);
                q.ExecuteNonQuery();

                string sq2 = $@"insert into Posobie
values ({dgvRez.Rows[drv.Index].Cells[0].Value},{dgvRez.Rows[drv.Index].Cells[4].Value},{tbSum.Text.Trim()})";
                SqlCommand q2 = new SqlCommand(sq2, con);
                q2.ExecuteNonQuery();
            }
            con.Close();
            dgvRez.Rows.Clear();
            Rez();
        }

        private void bProf_Click(object sender, EventArgs e)
        {
            FormEdit frm = new FormEdit();
            frm.bsUsers.Filter = bsUsers.Filter;
            frm.ShowDialog();
        }
    }
}

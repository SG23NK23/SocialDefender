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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        void Rez()
        {
            string date = DateTime.Now.ToShortDateString();
            string sq = $@"insert into Rez
values ({liduser.Text},{lidpt.Text},0,'{date}')";
            SqlConnection con = new SqlConnection(FormAftorization.txtcon);
            con.Open();
            SqlCommand q = new SqlCommand(sq, con);
            q.ExecuteNonQuery();         
            con.Close();
        }

        void table()
        {
            string sq = $@"SELECT        PT.namept, Posobie.sumposob
FROM            Posobie INNER JOIN
                         PT ON Posobie.posobietype = PT.idpt INNER JOIN
                         Rez ON PT.idpt = Rez.idposob INNER JOIN
                         Users ON Posobie.iduser = Users.iduser
where Users.iduser = {liduser.Text} and typeuser = 1 and Rez.iduser = {liduser.Text} and rez = 1";
            SqlConnection con = new SqlConnection(FormAftorization.txtcon);
            con.Open();
            SqlCommand q = new SqlCommand(sq, con);
            SqlDataReader rez = q.ExecuteReader();
            while (rez.Read())
                dgvPosob.Rows.Add(rez["namept"].ToString(),rez["sumposob"].ToString());
            con.Close();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'соцзащитаDataSet.PT' table. You can move, or remove it, as needed.
            this.pTTableAdapter.Fill(this.соцзащитаDataSet.PT);
            // TODO: This line of code loads data into the 'соцзащитаDataSet.Posobie' table. You can move, or remove it, as needed.
            this.posobieTableAdapter.Fill(this.соцзащитаDataSet.Posobie);
            // TODO: This line of code loads data into the 'соцзащитаDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.соцзащитаDataSet.Users);

            table();
            combPosob.SelectedIndex = 0;
        }

        private void bMess_Click(object sender, EventArgs e)
        {
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

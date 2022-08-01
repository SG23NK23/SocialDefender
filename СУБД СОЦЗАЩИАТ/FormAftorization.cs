using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace СУБД_СОЦЗАЩИАТ
{
    public partial class FormAftorization : Form
    {
        public FormAftorization()
        {
            InitializeComponent();
        }

        public static string txtcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Соцзащита.mdf;Integrated Security=True;Connect Timeout=30";

        private void FormAftorization_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'соцзащитаDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.соцзащитаDataSet.Users);
        }

        private void lReg_Click(object sender, EventArgs e)
        {
            FormReg frm = new FormReg();
            if (frm.ShowDialog() == DialogResult.OK)
                this.usersTableAdapter.Fill(this.соцзащитаDataSet.Users);
        }

        private void bLog_Click(object sender, EventArgs e)
        {
            if(tbLog.Text.Trim() == "")
            {
                MessageBox.Show("Логин пустой");
                return;
            }
            if(tbPass.Text.Trim() == "")
            {
                MessageBox.Show("Пароль пустой");
                return; 
            }

            try
            {
                string sq = $@"select * 
 from Users 
 where login = '{tbLog.Text}' and pass = '{tbPass.Text}'";
                SqlConnection con = new SqlConnection(txtcon);
                con.Open();
                SqlCommand q = new SqlCommand(sq, con);
                SqlDataReader rez = q.ExecuteReader();
                rez.Read();
                LTU.Text = rez["typeuser"].ToString();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Логин или пароль не правильные");
                return;
            }
                
           


            if (LTU.Text == "1")
            {
                FormUser frm = new FormUser();
                frm.bsUsers.Filter = $@"login = '{tbLog.Text}' and pass = '{tbPass.Text}'";
                frm.ShowDialog();
            }
            else if (LTU.Text == "2")
            {
                FormWork frm = new FormWork();
                frm.bsUsers.Filter = $@"login = '{tbLog.Text}' and pass = '{tbPass.Text}'";
                frm.ShowDialog();
            }
            else if (LTU.Text == "3")
            {
                FormAdmin frm = new FormAdmin();
                frm.bsUsers.Filter = $@"login = '{tbLog.Text}' and pass = '{tbPass.Text}'";
                frm.ShowDialog();
            }
            else return;
        }

        private void bVopr_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\help.chm");
        }
    }
}

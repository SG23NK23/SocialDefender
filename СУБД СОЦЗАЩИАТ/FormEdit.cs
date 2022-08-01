using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_СОЦЗАЩИАТ
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'соцзащитаDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.соцзащитаDataSet.Users);

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string pass = tbPassDB.Text;
            if (pass != tbPassChek.Text)
            {
                MessageBox.Show("Старый пароль не совпадает с ведённым");
                return;
            }
            if(tbFam.Text == "" || tbName.Text == "" || tbPhone.Text == "")
            {
                MessageBox.Show("Имя, фамилия и телефон не могут быть пустыми");
                return;
            }
            if(tbPhone.Text.Length >= 12)
            {
                MessageBox.Show("Телефон превышает длину");
                return;
            }
            for(int i = 0; i <tbPhone.Text.Length;i++)
            {
                if(!char.IsDigit(tbPhone.Text[i]))
                {
                    MessageBox.Show("в поле телефон недопустимый символ");
                    return;
                }
              
            }

            bsUsers.EndEdit();
            usersTableAdapter.Update(this.соцзащитаDataSet.Users);
            this.Close();
        }
    }
}

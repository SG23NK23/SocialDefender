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
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsUsers.EndEdit();
            this.tableAdapterManager.UpdateAll(this.соцзащитаDataSet);

        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'соцзащитаDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.соцзащитаDataSet.Users);
            bsUsers.AddNew();
            lTU.Text = "1";
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            
            if (tbFam.Text == "" || tbName.Text == "" || tbPhone.Text == "" || tbLog.Text == "" || tbPassDB.Text == "")
            {
                MessageBox.Show("Имя, фамилия, телефон, пароль и логин не могут быть пустыми");
                return;
            }
            if (tbPhone.Text.Length >= 12)
            {
                MessageBox.Show("Телефон превышает длину");
                return;
            }
            for (int i = 0; i < tbPhone.Text.Length; i++)
            {
                if (!char.IsDigit(tbPhone.Text[i]))
                {
                    MessageBox.Show("B поле телефон недопустимый символ");
                    return;
                }
            }
            if(tbPassDB.Text != tbPassChek.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            try
            {
                bsUsers.EndEdit();
                this.usersTableAdapter.Update(this.соцзащитаDataSet.Users);
            }
            catch
            {
                MessageBox.Show("В бд есть такой пользователь", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbLog.Focus();
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}

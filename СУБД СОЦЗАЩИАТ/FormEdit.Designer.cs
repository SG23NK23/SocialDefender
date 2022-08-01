namespace СУБД_СОЦЗАЩИАТ
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label otchLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label passLabel;
            this.bCancel = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbPassDB = new System.Windows.Forms.TextBox();
            this.tbPassChek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.соцзащитаDataSet = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSet();
            this.usersTableAdapter = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.TableAdapterManager();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            otchLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            passLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.соцзащитаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(5, 15);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(56, 13);
            famLabel.TabIndex = 7;
            famLabel.Text = "Фамилия";
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Tomato;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(253, 64);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(100, 23);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.Tomato;
            this.bSave.Location = new System.Drawing.Point(362, 64);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(100, 23);
            this.bSave.TabIndex = 6;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tbFam
            // 
            this.tbFam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "fam", true));
            this.tbFam.Location = new System.Drawing.Point(61, 12);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(100, 20);
            this.tbFam.TabIndex = 8;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(5, 41);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(29, 13);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Имя";
            // 
            // tbName
            // 
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "name", true));
            this.tbName.Location = new System.Drawing.Point(61, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 9;
            // 
            // otchLabel
            // 
            otchLabel.AutoSize = true;
            otchLabel.Location = new System.Drawing.Point(5, 67);
            otchLabel.Name = "otchLabel";
            otchLabel.Size = new System.Drawing.Size(54, 13);
            otchLabel.TabIndex = 9;
            otchLabel.Text = "Отчество";
            // 
            // tbOtch
            // 
            this.tbOtch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "otch", true));
            this.tbOtch.Location = new System.Drawing.Point(61, 64);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.Size = new System.Drawing.Size(100, 20);
            this.tbOtch.TabIndex = 10;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(193, 15);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(52, 13);
            phoneLabel.TabIndex = 10;
            phoneLabel.Text = "Телефон";
            // 
            // tbPhone
            // 
            this.tbPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "phone", true));
            this.tbPhone.Location = new System.Drawing.Point(253, 12);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(147, 20);
            this.tbPhone.TabIndex = 11;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new System.Drawing.Point(196, 41);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(45, 13);
            passLabel.TabIndex = 11;
            passLabel.Text = "Пароль";
            // 
            // tbPassDB
            // 
            this.tbPassDB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "pass", true));
            this.tbPassDB.Location = new System.Drawing.Point(253, 38);
            this.tbPassDB.Name = "tbPassDB";
            this.tbPassDB.Size = new System.Drawing.Size(100, 20);
            this.tbPassDB.TabIndex = 12;
            // 
            // tbPassChek
            // 
            this.tbPassChek.Location = new System.Drawing.Point(490, 38);
            this.tbPassChek.Name = "tbPassChek";
            this.tbPassChek.Size = new System.Drawing.Size(100, 20);
            this.tbPassChek.TabIndex = 13;
            this.tbPassChek.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Подтверждение пароля";
            // 
            // bsUsers
            // 
            this.bsUsers.DataMember = "Users";
            this.bsUsers.DataSource = this.соцзащитаDataSet;
            // 
            // соцзащитаDataSet
            // 
            this.соцзащитаDataSet.DataSetName = "СоцзащитаDataSet";
            this.соцзащитаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PosobieTableAdapter = null;
            this.tableAdapterManager.PTTableAdapter = null;
            this.tableAdapterManager.RezTableAdapter = null;
            this.tableAdapterManager.TypeUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 90);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassChek);
            this.Controls.Add(passLabel);
            this.Controls.Add(this.tbPassDB);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(otchLabel);
            this.Controls.Add(this.tbOtch);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.tbName);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.tbFam);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEdit";
            this.Text = "Редактирование профиля";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.соцзащитаDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSave;
        private СоцзащитаDataSet соцзащитаDataSet;
        private СоцзащитаDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private СоцзащитаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbOtch;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbPassDB;
        private System.Windows.Forms.TextBox tbPassChek;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.BindingSource bsUsers;
    }
}
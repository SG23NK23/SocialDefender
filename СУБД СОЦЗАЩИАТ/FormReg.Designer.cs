namespace СУБД_СОЦЗАЩИАТ
{
    partial class FormReg
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passLabel;
            System.Windows.Forms.Label typeuserLabel;
            this.соцзащитаDataSet = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSet();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.TableAdapterManager();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.tbPassDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassChek = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lTU = new System.Windows.Forms.Label();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            otchLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passLabel = new System.Windows.Forms.Label();
            typeuserLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.соцзащитаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(5, 15);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(56, 13);
            famLabel.TabIndex = 1;
            famLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(32, 41);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(29, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Имя";
            // 
            // otchLabel
            // 
            otchLabel.AutoSize = true;
            otchLabel.Location = new System.Drawing.Point(7, 67);
            otchLabel.Name = "otchLabel";
            otchLabel.Size = new System.Drawing.Size(54, 13);
            otchLabel.TabIndex = 4;
            otchLabel.Text = "Отчество";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(199, 15);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(52, 13);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "Телефон";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(213, 41);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(38, 13);
            loginLabel.TabIndex = 8;
            loginLabel.Text = "Логин";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new System.Drawing.Point(469, 15);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(45, 13);
            passLabel.TabIndex = 10;
            passLabel.Text = "Пароль";
            // 
            // соцзащитаDataSet
            // 
            this.соцзащитаDataSet.DataSetName = "СоцзащитаDataSet";
            this.соцзащитаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsUsers
            // 
            this.bsUsers.DataMember = "Users";
            this.bsUsers.DataSource = this.соцзащитаDataSet;
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
            // tbFam
            // 
            this.tbFam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "fam", true));
            this.tbFam.Location = new System.Drawing.Point(67, 12);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(100, 20);
            this.tbFam.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "name", true));
            this.tbName.Location = new System.Drawing.Point(67, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 3;
            // 
            // tbOtch
            // 
            this.tbOtch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "otch", true));
            this.tbOtch.Location = new System.Drawing.Point(67, 64);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.Size = new System.Drawing.Size(100, 20);
            this.tbOtch.TabIndex = 5;
            // 
            // tbPhone
            // 
            this.tbPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "phone", true));
            this.tbPhone.Location = new System.Drawing.Point(257, 12);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(138, 20);
            this.tbPhone.TabIndex = 7;
            // 
            // tbLog
            // 
            this.tbLog.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "login", true));
            this.tbLog.Location = new System.Drawing.Point(257, 38);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(100, 20);
            this.tbLog.TabIndex = 9;
            // 
            // tbPassDB
            // 
            this.tbPassDB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "pass", true));
            this.tbPassDB.Location = new System.Drawing.Point(520, 12);
            this.tbPassDB.Name = "tbPassDB";
            this.tbPassDB.Size = new System.Drawing.Size(100, 20);
            this.tbPassDB.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Подтверждение пароля";
            // 
            // tbPassChek
            // 
            this.tbPassChek.Location = new System.Drawing.Point(520, 38);
            this.tbPassChek.Name = "tbPassChek";
            this.tbPassChek.Size = new System.Drawing.Size(100, 20);
            this.tbPassChek.TabIndex = 15;
            this.tbPassChek.UseSystemPasswordChar = true;
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.Tomato;
            this.bSave.Location = new System.Drawing.Point(295, 61);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(122, 23);
            this.bSave.TabIndex = 18;
            this.bSave.Text = "Зарегистрироваться";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Tomato;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(186, 61);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(100, 23);
            this.bCancel.TabIndex = 17;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            // 
            // typeuserLabel
            // 
            typeuserLabel.AutoSize = true;
            typeuserLabel.Location = new System.Drawing.Point(299, 154);
            typeuserLabel.Name = "typeuserLabel";
            typeuserLabel.Size = new System.Drawing.Size(50, 13);
            typeuserLabel.TabIndex = 19;
            typeuserLabel.Text = "typeuser:";
            // 
            // lTU
            // 
            this.lTU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "typeuser", true));
            this.lTU.Location = new System.Drawing.Point(355, 154);
            this.lTU.Name = "lTU";
            this.lTU.Size = new System.Drawing.Size(100, 23);
            this.lTU.TabIndex = 20;
            this.lTU.Text = "label2";
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 91);
            this.Controls.Add(typeuserLabel);
            this.Controls.Add(this.lTU);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassChek);
            this.Controls.Add(passLabel);
            this.Controls.Add(this.tbPassDB);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(otchLabel);
            this.Controls.Add(this.tbOtch);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.tbName);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.tbFam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReg";
            this.Text = "Регистрация пользователя";
            this.Load += new System.EventHandler(this.FormReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.соцзащитаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private СоцзащитаDataSet соцзащитаDataSet;
        private System.Windows.Forms.BindingSource bsUsers;
        private СоцзащитаDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private СоцзащитаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbOtch;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.TextBox tbPassDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassChek;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lTU;
    }
}
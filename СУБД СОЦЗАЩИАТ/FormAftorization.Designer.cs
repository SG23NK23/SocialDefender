namespace СУБД_СОЦЗАЩИАТ
{
    partial class FormAftorization
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAftorization));
            this.соцзащитаDataSet = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSet();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.TableAdapterManager();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.bLog = new System.Windows.Forms.Button();
            this.lReg = new System.Windows.Forms.Label();
            this.LTU = new System.Windows.Forms.Label();
            this.bVopr = new System.Windows.Forms.Button();
            loginLabel = new System.Windows.Forms.Label();
            passLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.соцзащитаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(3, 15);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(38, 13);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Логин";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new System.Drawing.Point(3, 41);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(45, 13);
            passLabel.TabIndex = 2;
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
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(50, 12);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(100, 20);
            this.tbLog.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(50, 38);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 3;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // bLog
            // 
            this.bLog.BackColor = System.Drawing.Color.Tomato;
            this.bLog.Location = new System.Drawing.Point(51, 64);
            this.bLog.Name = "bLog";
            this.bLog.Size = new System.Drawing.Size(100, 21);
            this.bLog.TabIndex = 4;
            this.bLog.Text = "Вход";
            this.bLog.UseVisualStyleBackColor = false;
            this.bLog.Click += new System.EventHandler(this.bLog_Click);
            // 
            // lReg
            // 
            this.lReg.AutoSize = true;
            this.lReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lReg.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lReg.Location = new System.Drawing.Point(153, 68);
            this.lReg.Name = "lReg";
            this.lReg.Size = new System.Drawing.Size(72, 13);
            this.lReg.TabIndex = 6;
            this.lReg.Text = "Регистрация";
            this.lReg.Click += new System.EventHandler(this.lReg_Click);
            // 
            // LTU
            // 
            this.LTU.AutoSize = true;
            this.LTU.Location = new System.Drawing.Point(26, 116);
            this.LTU.Name = "LTU";
            this.LTU.Size = new System.Drawing.Size(35, 13);
            this.LTU.TabIndex = 7;
            this.LTU.Text = "label1";
            // 
            // bVopr
            // 
            this.bVopr.BackColor = System.Drawing.Color.Tomato;
            this.bVopr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bVopr.Location = new System.Drawing.Point(6, 57);
            this.bVopr.Name = "bVopr";
            this.bVopr.Size = new System.Drawing.Size(32, 31);
            this.bVopr.TabIndex = 8;
            this.bVopr.Text = "?";
            this.bVopr.UseVisualStyleBackColor = false;
            this.bVopr.Click += new System.EventHandler(this.bVopr_Click);
            // 
            // FormAftorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(234, 89);
            this.Controls.Add(this.bVopr);
            this.Controls.Add(this.LTU);
            this.Controls.Add(this.lReg);
            this.Controls.Add(this.bLog);
            this.Controls.Add(passLabel);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.tbLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAftorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.FormAftorization_Load);
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
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button bLog;
        private System.Windows.Forms.Label lReg;
        private System.Windows.Forms.Label LTU;
        private System.Windows.Forms.Button bVopr;
    }
}


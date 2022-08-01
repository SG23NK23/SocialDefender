namespace СУБД_СОЦЗАЩИАТ
{
    partial class FormUser
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
            System.Windows.Forms.Label nameptLabel;
            System.Windows.Forms.Label iduserLabel;
            System.Windows.Forms.Label idptLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.famLabel1 = new System.Windows.Forms.Label();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.соцзащитаDataSet = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bProf = new System.Windows.Forms.Button();
            this.otchLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bMess = new System.Windows.Forms.Button();
            this.dgvPosob = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combPosob = new System.Windows.Forms.ComboBox();
            this.bsPT = new System.Windows.Forms.BindingSource(this.components);
            this.liduser = new System.Windows.Forms.Label();
            this.usersTableAdapter = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.TableAdapterManager();
            this.bsPosob = new System.Windows.Forms.BindingSource(this.components);
            this.posobieTableAdapter = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.PosobieTableAdapter();
            this.pTTableAdapter = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.PTTableAdapter();
            this.lidpt = new System.Windows.Forms.Label();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            otchLabel = new System.Windows.Forms.Label();
            nameptLabel = new System.Windows.Forms.Label();
            iduserLabel = new System.Windows.Forms.Label();
            idptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.соцзащитаDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPosob)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(113, 16);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(56, 13);
            famLabel.TabIndex = 1;
            famLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(140, 39);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(29, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Имя";
            // 
            // otchLabel
            // 
            otchLabel.AutoSize = true;
            otchLabel.Location = new System.Drawing.Point(115, 62);
            otchLabel.Name = "otchLabel";
            otchLabel.Size = new System.Drawing.Size(54, 13);
            otchLabel.TabIndex = 5;
            otchLabel.Text = "Отчество";
            // 
            // nameptLabel
            // 
            nameptLabel.AutoSize = true;
            nameptLabel.Location = new System.Drawing.Point(3, 100);
            nameptLabel.Name = "nameptLabel";
            nameptLabel.Size = new System.Drawing.Size(104, 13);
            nameptLabel.TabIndex = 3;
            nameptLabel.Text = "Запрос на пособие";
            // 
            // iduserLabel
            // 
            iduserLabel.AutoSize = true;
            iduserLabel.Location = new System.Drawing.Point(121, 227);
            iduserLabel.Name = "iduserLabel";
            iduserLabel.Size = new System.Drawing.Size(38, 13);
            iduserLabel.TabIndex = 9;
            iduserLabel.Text = "iduser:";
            // 
            // idptLabel
            // 
            idptLabel.AutoSize = true;
            idptLabel.Location = new System.Drawing.Point(139, 271);
            idptLabel.Name = "idptLabel";
            idptLabel.Size = new System.Drawing.Size(27, 13);
            idptLabel.TabIndex = 10;
            idptLabel.Text = "idpt:";
            // 
            // famLabel1
            // 
            this.famLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "fam", true));
            this.famLabel1.Location = new System.Drawing.Point(178, 16);
            this.famLabel1.Name = "famLabel1";
            this.famLabel1.Size = new System.Drawing.Size(100, 23);
            this.famLabel1.TabIndex = 2;
            this.famLabel1.Text = "label1";
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bProf);
            this.panel1.Controls.Add(otchLabel);
            this.panel1.Controls.Add(this.otchLabel1);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(famLabel);
            this.panel1.Controls.Add(this.famLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 99);
            this.panel1.TabIndex = 3;
            // 
            // bProf
            // 
            this.bProf.BackColor = System.Drawing.Color.Tomato;
            this.bProf.Location = new System.Drawing.Point(253, 0);
            this.bProf.Name = "bProf";
            this.bProf.Size = new System.Drawing.Size(100, 29);
            this.bProf.TabIndex = 5;
            this.bProf.Text = "Профиль";
            this.bProf.UseVisualStyleBackColor = false;
            this.bProf.Click += new System.EventHandler(this.bProf_Click);
            // 
            // otchLabel1
            // 
            this.otchLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "otch", true));
            this.otchLabel1.Location = new System.Drawing.Point(178, 62);
            this.otchLabel1.Name = "otchLabel1";
            this.otchLabel1.Size = new System.Drawing.Size(100, 23);
            this.otchLabel1.TabIndex = 6;
            this.otchLabel1.Text = "label1";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "name", true));
            this.nameLabel1.Location = new System.Drawing.Point(178, 39);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 4;
            this.nameLabel1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bMess
            // 
            this.bMess.BackColor = System.Drawing.Color.Tomato;
            this.bMess.Location = new System.Drawing.Point(0, 164);
            this.bMess.Name = "bMess";
            this.bMess.Size = new System.Drawing.Size(121, 21);
            this.bMess.TabIndex = 7;
            this.bMess.Text = "Отправить";
            this.bMess.UseVisualStyleBackColor = false;
            this.bMess.Click += new System.EventHandler(this.bMess_Click);
            // 
            // dgvPosob
            // 
            this.dgvPosob.AllowUserToAddRows = false;
            this.dgvPosob.AllowUserToDeleteRows = false;
            this.dgvPosob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPosob.Location = new System.Drawing.Point(121, 99);
            this.dgvPosob.Name = "dgvPosob";
            this.dgvPosob.ReadOnly = true;
            this.dgvPosob.RowHeadersVisible = false;
            this.dgvPosob.Size = new System.Drawing.Size(232, 86);
            this.dgvPosob.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название пособия";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Сумма";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // combPosob
            // 
            this.combPosob.DataSource = this.bsPT;
            this.combPosob.DisplayMember = "namept";
            this.combPosob.FormattingEnabled = true;
            this.combPosob.Location = new System.Drawing.Point(1, 117);
            this.combPosob.Name = "combPosob";
            this.combPosob.Size = new System.Drawing.Size(120, 21);
            this.combPosob.TabIndex = 9;
            this.combPosob.ValueMember = "idpt";
            // 
            // bsPT
            // 
            this.bsPT.DataMember = "PT";
            this.bsPT.DataSource = this.соцзащитаDataSet;
            // 
            // liduser
            // 
            this.liduser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "iduser", true));
            this.liduser.Location = new System.Drawing.Point(165, 227);
            this.liduser.Name = "liduser";
            this.liduser.Size = new System.Drawing.Size(100, 23);
            this.liduser.TabIndex = 10;
            this.liduser.Text = "label1";
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
            // posobieTableAdapter
            // 
            this.posobieTableAdapter.ClearBeforeFill = true;
            // 
            // pTTableAdapter
            // 
            this.pTTableAdapter.ClearBeforeFill = true;
            // 
            // lidpt
            // 
            this.lidpt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPT, "idpt", true));
            this.lidpt.Location = new System.Drawing.Point(172, 271);
            this.lidpt.Name = "lidpt";
            this.lidpt.Size = new System.Drawing.Size(100, 23);
            this.lidpt.TabIndex = 11;
            this.lidpt.Text = "label1";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 188);
            this.Controls.Add(idptLabel);
            this.Controls.Add(this.lidpt);
            this.Controls.Add(iduserLabel);
            this.Controls.Add(this.liduser);
            this.Controls.Add(this.combPosob);
            this.Controls.Add(this.dgvPosob);
            this.Controls.Add(this.bMess);
            this.Controls.Add(nameptLabel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUser";
            this.Text = "Пользователь";
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.соцзащитаDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPosob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private СоцзащитаDataSet соцзащитаDataSet;
        private СоцзащитаDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private СоцзащитаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label famLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label otchLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bProf;
        private System.Windows.Forms.Button bMess;
        private System.Windows.Forms.DataGridView dgvPosob;
        private System.Windows.Forms.ComboBox combPosob;
        public System.Windows.Forms.BindingSource bsUsers;
        private System.Windows.Forms.BindingSource bsPosob;
        private СоцзащитаDataSetTableAdapters.PosobieTableAdapter posobieTableAdapter;
        private System.Windows.Forms.Label liduser;
        private System.Windows.Forms.BindingSource bsPT;
        private СоцзащитаDataSetTableAdapters.PTTableAdapter pTTableAdapter;
        private System.Windows.Forms.Label lidpt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
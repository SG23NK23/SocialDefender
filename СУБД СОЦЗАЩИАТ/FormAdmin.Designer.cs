namespace СУБД_СОЦЗАЩИАТ
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.соцзащитаDataSet = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSet();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.otchLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.famLabel1 = new System.Windows.Forms.Label();
            this.bProf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPT = new System.Windows.Forms.DataGridView();
            this.nameptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPT = new System.Windows.Forms.BindingSource(this.components);
            this.dgvWork = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pTTableAdapter = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.PTTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdd = new System.Windows.Forms.TextBox();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            otchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.соцзащитаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(113, 7);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(56, 13);
            famLabel.TabIndex = 5;
            famLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(136, 31);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(29, 13);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Имя";
            // 
            // otchLabel
            // 
            otchLabel.AutoSize = true;
            otchLabel.Location = new System.Drawing.Point(115, 54);
            otchLabel.Name = "otchLabel";
            otchLabel.Size = new System.Drawing.Size(54, 13);
            otchLabel.TabIndex = 7;
            otchLabel.Text = "Отчество";
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(otchLabel);
            this.panel1.Controls.Add(this.otchLabel1);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameLabel1);
            this.panel1.Controls.Add(famLabel);
            this.panel1.Controls.Add(this.famLabel1);
            this.panel1.Controls.Add(this.bProf);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 76);
            this.panel1.TabIndex = 4;
            // 
            // otchLabel1
            // 
            this.otchLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "otch", true));
            this.otchLabel1.Location = new System.Drawing.Point(175, 54);
            this.otchLabel1.Name = "otchLabel1";
            this.otchLabel1.Size = new System.Drawing.Size(100, 23);
            this.otchLabel1.TabIndex = 8;
            this.otchLabel1.Text = "label1";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "name", true));
            this.nameLabel1.Location = new System.Drawing.Point(175, 31);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 7;
            this.nameLabel1.Text = "label1";
            // 
            // famLabel1
            // 
            this.famLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "fam", true));
            this.famLabel1.Location = new System.Drawing.Point(175, 7);
            this.famLabel1.Name = "famLabel1";
            this.famLabel1.Size = new System.Drawing.Size(100, 23);
            this.famLabel1.TabIndex = 6;
            this.famLabel1.Text = "label1";
            // 
            // bProf
            // 
            this.bProf.BackColor = System.Drawing.Color.Tomato;
            this.bProf.Location = new System.Drawing.Point(521, 0);
            this.bProf.Name = "bProf";
            this.bProf.Size = new System.Drawing.Size(100, 29);
            this.bProf.TabIndex = 5;
            this.bProf.Text = "Профиль";
            this.bProf.UseVisualStyleBackColor = false;
            this.bProf.Click += new System.EventHandler(this.bProf_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvPT
            // 
            this.dgvPT.AllowUserToAddRows = false;
            this.dgvPT.AllowUserToDeleteRows = false;
            this.dgvPT.AutoGenerateColumns = false;
            this.dgvPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameptDataGridViewTextBoxColumn});
            this.dgvPT.DataSource = this.bsPT;
            this.dgvPT.Location = new System.Drawing.Point(3, 92);
            this.dgvPT.Name = "dgvPT";
            this.dgvPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPT.Size = new System.Drawing.Size(163, 150);
            this.dgvPT.TabIndex = 5;
            // 
            // nameptDataGridViewTextBoxColumn
            // 
            this.nameptDataGridViewTextBoxColumn.DataPropertyName = "namept";
            this.nameptDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameptDataGridViewTextBoxColumn.Name = "nameptDataGridViewTextBoxColumn";
            this.nameptDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bsPT
            // 
            this.bsPT.DataMember = "PT";
            this.bsPT.DataSource = this.соцзащитаDataSet;
            // 
            // dgvWork
            // 
            this.dgvWork.AllowUserToAddRows = false;
            this.dgvWork.AllowUserToDeleteRows = false;
            this.dgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvWork.Location = new System.Drawing.Point(172, 92);
            this.dgvWork.Name = "dgvWork";
            this.dgvWork.ReadOnly = true;
            this.dgvWork.Size = new System.Drawing.Size(447, 150);
            this.dgvWork.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Отчество";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Телефон";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bDel
            // 
            this.bDel.BackColor = System.Drawing.Color.Tomato;
            this.bDel.Location = new System.Drawing.Point(1, 261);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(165, 20);
            this.bDel.TabIndex = 7;
            this.bDel.Text = "Удалить";
            this.bDel.UseVisualStyleBackColor = false;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Tomato;
            this.bAdd.Location = new System.Drawing.Point(1, 242);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(165, 21);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.Tomato;
            this.bSearch.Location = new System.Drawing.Point(321, 246);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(167, 29);
            this.bSearch.TabIndex = 9;
            this.bSearch.Text = "Поиск по фамилии";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(494, 251);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(122, 20);
            this.tbSearch.TabIndex = 10;
            // 
            // pTTableAdapter
            // 
            this.pTTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Пособия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Сотрудники";
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(172, 243);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(122, 20);
            this.tbAdd.TabIndex = 13;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 281);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.dgvWork);
            this.Controls.Add(this.dgvPT);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdmin";
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.соцзащитаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private СоцзащитаDataSet соцзащитаDataSet;
        private СоцзащитаDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private СоцзащитаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label otchLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label famLabel1;
        private System.Windows.Forms.Button bProf;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.BindingSource bsUsers;
        private System.Windows.Forms.DataGridView dgvPT;
        private System.Windows.Forms.DataGridView dgvWork;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.BindingSource bsPT;
        private СоцзащитаDataSetTableAdapters.PTTableAdapter pTTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
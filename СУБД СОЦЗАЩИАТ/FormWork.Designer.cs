namespace СУБД_СОЦЗАЩИАТ
{
    partial class FormWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWork));
            this.panel1 = new System.Windows.Forms.Panel();
            this.otchLabel1 = new System.Windows.Forms.Label();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.соцзащитаDataSet = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSet();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.famLabel1 = new System.Windows.Forms.Label();
            this.bProf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bTrue = new System.Windows.Forms.Button();
            this.bSaveDoc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRez = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.usersTableAdapter = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.TableAdapterManager();
            this.bsRez = new System.Windows.Forms.BindingSource(this.components);
            this.rezTableAdapter = new СУБД_СОЦЗАЩИАТ.СоцзащитаDataSetTableAdapters.RezTableAdapter();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            otchLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.соцзащитаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRez)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(100, 16);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(56, 13);
            famLabel.TabIndex = 5;
            famLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(127, 39);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(29, 13);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Имя";
            // 
            // otchLabel
            // 
            otchLabel.AutoSize = true;
            otchLabel.Location = new System.Drawing.Point(102, 62);
            otchLabel.Name = "otchLabel";
            otchLabel.Size = new System.Drawing.Size(54, 13);
            otchLabel.TabIndex = 7;
            otchLabel.Text = "Отчество";
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
            this.panel1.Size = new System.Drawing.Size(1020, 106);
            this.panel1.TabIndex = 4;
            // 
            // otchLabel1
            // 
            this.otchLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "otch", true));
            this.otchLabel1.Location = new System.Drawing.Point(162, 62);
            this.otchLabel1.Name = "otchLabel1";
            this.otchLabel1.Size = new System.Drawing.Size(100, 23);
            this.otchLabel1.TabIndex = 8;
            this.otchLabel1.Text = "label3";
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
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "name", true));
            this.nameLabel1.Location = new System.Drawing.Point(162, 39);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 7;
            this.nameLabel1.Text = "label3";
            // 
            // famLabel1
            // 
            this.famLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "fam", true));
            this.famLabel1.Location = new System.Drawing.Point(162, 16);
            this.famLabel1.Name = "famLabel1";
            this.famLabel1.Size = new System.Drawing.Size(100, 23);
            this.famLabel1.TabIndex = 6;
            this.famLabel1.Text = "label3";
            // 
            // bProf
            // 
            this.bProf.BackColor = System.Drawing.Color.Tomato;
            this.bProf.Location = new System.Drawing.Point(918, 0);
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
            this.pictureBox1.Size = new System.Drawing.Size(100, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8});
            this.dgvUsers.Location = new System.Drawing.Point(2, 126);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(444, 189);
            this.dgvUsers.TabIndex = 5;
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
            // Column8
            // 
            this.Column8.HeaderText = "id";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Пользователи";
            // 
            // bTrue
            // 
            this.bTrue.BackColor = System.Drawing.Color.Tomato;
            this.bTrue.Location = new System.Drawing.Point(920, 130);
            this.bTrue.Name = "bTrue";
            this.bTrue.Size = new System.Drawing.Size(100, 29);
            this.bTrue.TabIndex = 9;
            this.bTrue.Text = "Разрешить";
            this.bTrue.UseVisualStyleBackColor = false;
            this.bTrue.Click += new System.EventHandler(this.bTrue_Click);
            // 
            // bSaveDoc
            // 
            this.bSaveDoc.BackColor = System.Drawing.Color.Tomato;
            this.bSaveDoc.Location = new System.Drawing.Point(919, 263);
            this.bSaveDoc.Name = "bSaveDoc";
            this.bSaveDoc.Size = new System.Drawing.Size(100, 52);
            this.bSaveDoc.TabIndex = 10;
            this.bSaveDoc.Text = "Сохранить в документ пользователей";
            this.bSaveDoc.UseVisualStyleBackColor = false;
            this.bSaveDoc.Click += new System.EventHandler(this.bSaveDoc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Заявка";
            // 
            // dgvRez
            // 
            this.dgvRez.AllowUserToAddRows = false;
            this.dgvRez.AllowUserToDeleteRows = false;
            this.dgvRez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRez.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgvRez.Location = new System.Drawing.Point(468, 126);
            this.dgvRez.Name = "dgvRez";
            this.dgvRez.ReadOnly = true;
            this.dgvRez.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRez.Size = new System.Drawing.Size(448, 189);
            this.dgvRez.TabIndex = 12;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "IdПользователя";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Пособие";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Откл./Прин.";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Дата";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "idp";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "idrez";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column11.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "iduser";
            this.dataGridViewTextBoxColumn1.HeaderText = "iduser";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idposob";
            this.dataGridViewTextBoxColumn2.HeaderText = "idposob";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "rez";
            this.dataGridViewCheckBoxColumn1.HeaderText = "rez";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "data";
            this.dataGridViewTextBoxColumn3.HeaderText = "data";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(919, 165);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(100, 20);
            this.tbSum.TabIndex = 13;
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
            // bsRez
            // 
            this.bsRez.DataMember = "Rez";
            this.bsRez.DataSource = this.соцзащитаDataSet;
            // 
            // rezTableAdapter
            // 
            this.rezTableAdapter.ClearBeforeFill = true;
            // 
            // FormWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 324);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.dgvRez);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bSaveDoc);
            this.Controls.Add(this.bTrue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormWork";
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.FormWork_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.соцзащитаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bProf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bTrue;
        private System.Windows.Forms.Button bSaveDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private СоцзащитаDataSet соцзащитаDataSet;
        public System.Windows.Forms.BindingSource bsUsers;
        private СоцзащитаDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private СоцзащитаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bsRez;
        private СоцзащитаDataSetTableAdapters.RezTableAdapter rezTableAdapter;
        private System.Windows.Forms.DataGridView dgvRez;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Label otchLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label famLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}
namespace ExampleSQLApp
{
    partial class connectionTestForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.users_dataGridView = new System.Windows.Forms.DataGridView();
            this.rolenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roledescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miit_local_User_Auth_n_Role_Data = new ExampleSQLApp.miit_local_User_Auth_n_Role_Data();
            this.listBox = new System.Windows.Forms.ListBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miit_localDataSet = new ExampleSQLApp.miit_localDataSet();
            this.usersTableAdapter = new ExampleSQLApp.miit_localDataSetTableAdapters.usersTableAdapter();
            this.miitlocalUserAuthnRoleDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new ExampleSQLApp.miit_local_User_Auth_n_Role_DataTableAdapters.rolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.users_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miit_local_User_Auth_n_Role_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miit_localDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miitlocalUserAuthnRoleDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // users_dataGridView
            // 
            this.users_dataGridView.AutoGenerateColumns = false;
            this.users_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.users_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.users_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.users_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rolenameDataGridViewTextBoxColumn,
            this.roledescriptionDataGridViewTextBoxColumn});
            this.users_dataGridView.DataSource = this.rolesBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.users_dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.users_dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.users_dataGridView.Location = new System.Drawing.Point(0, 301);
            this.users_dataGridView.Name = "users_dataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.users_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.users_dataGridView.RowHeadersWidth = 51;
            this.users_dataGridView.RowTemplate.Height = 24;
            this.users_dataGridView.Size = new System.Drawing.Size(1100, 150);
            this.users_dataGridView.TabIndex = 0;
            this.users_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_dataGridView_CellContentClick);
            // 
            // rolenameDataGridViewTextBoxColumn
            // 
            this.rolenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rolenameDataGridViewTextBoxColumn.DataPropertyName = "role_name";
            this.rolenameDataGridViewTextBoxColumn.FillWeight = 33F;
            this.rolenameDataGridViewTextBoxColumn.HeaderText = "role_name";
            this.rolenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rolenameDataGridViewTextBoxColumn.Name = "rolenameDataGridViewTextBoxColumn";
            this.rolenameDataGridViewTextBoxColumn.Width = 157;
            // 
            // roledescriptionDataGridViewTextBoxColumn
            // 
            this.roledescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roledescriptionDataGridViewTextBoxColumn.DataPropertyName = "role_description";
            this.roledescriptionDataGridViewTextBoxColumn.FillWeight = 67F;
            this.roledescriptionDataGridViewTextBoxColumn.HeaderText = "role_description";
            this.roledescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roledescriptionDataGridViewTextBoxColumn.Name = "roledescriptionDataGridViewTextBoxColumn";
            this.roledescriptionDataGridViewTextBoxColumn.Width = 216;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.miit_local_User_Auth_n_Role_Data;
            // 
            // miit_local_User_Auth_n_Role_Data
            // 
            this.miit_local_User_Auth_n_Role_Data.DataSetName = "miit_local_User_Auth_n_Role_Data";
            this.miit_local_User_Auth_n_Role_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 32;
            this.listBox.Location = new System.Drawing.Point(39, 13);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(982, 132);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.miit_localDataSet;
            // 
            // miit_localDataSet
            // 
            this.miit_localDataSet.DataSetName = "miit_localDataSet";
            this.miit_localDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // miitlocalUserAuthnRoleDataBindingSource
            // 
            this.miitlocalUserAuthnRoleDataBindingSource.DataSource = this.miit_local_User_Auth_n_Role_Data;
            this.miitlocalUserAuthnRoleDataBindingSource.Position = 0;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // connectionTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 451);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.users_dataGridView);
            this.Name = "connectionTestForm";
            this.Text = "connectionTestForm";
            this.Load += new System.EventHandler(this.connectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.users_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miit_local_User_Auth_n_Role_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miit_localDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miitlocalUserAuthnRoleDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView users_dataGridView;
        private miit_localDataSet miit_localDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private miit_localDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ListBox listBox;
        private miit_local_User_Auth_n_Role_Data miit_local_User_Auth_n_Role_Data;
        private System.Windows.Forms.BindingSource miitlocalUserAuthnRoleDataBindingSource;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private miit_local_User_Auth_n_Role_DataTableAdapters.rolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roledescriptionDataGridViewTextBoxColumn;
    }
}
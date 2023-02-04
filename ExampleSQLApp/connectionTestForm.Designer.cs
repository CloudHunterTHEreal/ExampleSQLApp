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
            this.users_dataGridView = new System.Windows.Forms.DataGridView();
            this.nicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miit_localDataSet = new ExampleSQLApp.miit_localDataSet();
            this.usersTableAdapter = new ExampleSQLApp.miit_localDataSetTableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.users_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miit_localDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // users_dataGridView
            // 
            this.users_dataGridView.AutoGenerateColumns = false;
            this.users_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nicknameDataGridViewTextBoxColumn});
            this.users_dataGridView.DataSource = this.usersBindingSource;
            this.users_dataGridView.Location = new System.Drawing.Point(200, 32);
            this.users_dataGridView.Name = "users_dataGridView";
            this.users_dataGridView.RowHeadersWidth = 51;
            this.users_dataGridView.RowTemplate.Height = 24;
            this.users_dataGridView.Size = new System.Drawing.Size(541, 150);
            this.users_dataGridView.TabIndex = 0;
            this.users_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_dataGridView_CellContentClick);
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            this.nicknameDataGridViewTextBoxColumn.DataPropertyName = "nickname";
            this.nicknameDataGridViewTextBoxColumn.HeaderText = "nickname";
            this.nicknameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            this.nicknameDataGridViewTextBoxColumn.Width = 125;
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
            // connectionTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.users_dataGridView);
            this.Name = "connectionTestForm";
            this.Text = "connectionTestForm";
            this.Load += new System.EventHandler(this.connectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.users_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miit_localDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView users_dataGridView;
        private miit_localDataSet miit_localDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private miit_localDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
    }
}
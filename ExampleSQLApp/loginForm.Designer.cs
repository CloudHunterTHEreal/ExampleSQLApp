namespace ExampleSQLApp
{
    partial class loginForm
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
            this.loginMainPanel = new System.Windows.Forms.Panel();
            this.loginButtonsPanel = new System.Windows.Forms.Panel();
            this.loginDataDrop = new System.Windows.Forms.Button();
            this.loginDataEnter = new System.Windows.Forms.Button();
            this.fieldPasswordInput = new System.Windows.Forms.TextBox();
            this.iconPassword = new System.Windows.Forms.PictureBox();
            this.fieldUserNameInput = new System.Windows.Forms.TextBox();
            this.iconUserName = new System.Windows.Forms.PictureBox();
            this.loginTopPanel = new System.Windows.Forms.Panel();
            this.labelCloseLoginFormBottom = new System.Windows.Forms.Label();
            this.labelLoginTopPanel = new System.Windows.Forms.Label();
            this.loginMainPanel.SuspendLayout();
            this.loginButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUserName)).BeginInit();
            this.loginTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginMainPanel
            // 
            this.loginMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(201)))), ((int)(((byte)(128)))));
            this.loginMainPanel.Controls.Add(this.loginButtonsPanel);
            this.loginMainPanel.Controls.Add(this.fieldPasswordInput);
            this.loginMainPanel.Controls.Add(this.iconPassword);
            this.loginMainPanel.Controls.Add(this.fieldUserNameInput);
            this.loginMainPanel.Controls.Add(this.iconUserName);
            this.loginMainPanel.Controls.Add(this.loginTopPanel);
            this.loginMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginMainPanel.Location = new System.Drawing.Point(0, 0);
            this.loginMainPanel.Name = "loginMainPanel";
            this.loginMainPanel.Size = new System.Drawing.Size(636, 372);
            this.loginMainPanel.TabIndex = 0;
            this.loginMainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginMainPanel_MouseDown);
            this.loginMainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginMainPanel_MouseMove);
            // 
            // loginButtonsPanel
            // 
            this.loginButtonsPanel.Controls.Add(this.loginDataDrop);
            this.loginButtonsPanel.Controls.Add(this.loginDataEnter);
            this.loginButtonsPanel.Location = new System.Drawing.Point(168, 288);
            this.loginButtonsPanel.Name = "loginButtonsPanel";
            this.loginButtonsPanel.Size = new System.Drawing.Size(300, 72);
            this.loginButtonsPanel.TabIndex = 5;
            // 
            // loginDataDrop
            // 
            this.loginDataDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginDataDrop.BackgroundImage = global::ExampleSQLApp.Properties.Resources._211651_close_round_icon;
            this.loginDataDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginDataDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginDataDrop.Location = new System.Drawing.Point(154, 4);
            this.loginDataDrop.Name = "loginDataDrop";
            this.loginDataDrop.Size = new System.Drawing.Size(143, 63);
            this.loginDataDrop.TabIndex = 1;
            this.loginDataDrop.UseVisualStyleBackColor = true;
            // 
            // loginDataEnter
            // 
            this.loginDataEnter.BackgroundImage = global::ExampleSQLApp.Properties.Resources._211643_checkmark_round_icon;
            this.loginDataEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginDataEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginDataEnter.Location = new System.Drawing.Point(4, 4);
            this.loginDataEnter.Name = "loginDataEnter";
            this.loginDataEnter.Size = new System.Drawing.Size(143, 63);
            this.loginDataEnter.TabIndex = 0;
            this.loginDataEnter.UseVisualStyleBackColor = true;
            this.loginDataEnter.Click += new System.EventHandler(this.loginDataEnter_Click);
            this.loginDataEnter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loginDataEnter_MouseClick);
            // 
            // fieldPasswordInput
            // 
            this.fieldPasswordInput.BackColor = System.Drawing.Color.Gainsboro;
            this.fieldPasswordInput.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldPasswordInput.Location = new System.Drawing.Point(153, 196);
            this.fieldPasswordInput.Multiline = true;
            this.fieldPasswordInput.Name = "fieldPasswordInput";
            this.fieldPasswordInput.Size = new System.Drawing.Size(418, 86);
            this.fieldPasswordInput.TabIndex = 4;
            this.fieldPasswordInput.Text = "Пароль";
            this.fieldPasswordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fieldPasswordInput.UseSystemPasswordChar = true;
            // 
            // iconPassword
            // 
            this.iconPassword.Image = global::ExampleSQLApp.Properties.Resources._9024815_password_light_icon;
            this.iconPassword.Location = new System.Drawing.Point(52, 196);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(94, 86);
            this.iconPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPassword.TabIndex = 3;
            this.iconPassword.TabStop = false;
            // 
            // fieldUserNameInput
            // 
            this.fieldUserNameInput.BackColor = System.Drawing.Color.Gainsboro;
            this.fieldUserNameInput.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldUserNameInput.Location = new System.Drawing.Point(153, 104);
            this.fieldUserNameInput.Multiline = true;
            this.fieldUserNameInput.Name = "fieldUserNameInput";
            this.fieldUserNameInput.Size = new System.Drawing.Size(418, 86);
            this.fieldUserNameInput.TabIndex = 2;
            this.fieldUserNameInput.Text = "Пользователь";
            this.fieldUserNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconUserName
            // 
            this.iconUserName.Image = global::ExampleSQLApp.Properties.Resources._7106356_graph_infographic_data_person_element_icon;
            this.iconUserName.Location = new System.Drawing.Point(52, 104);
            this.iconUserName.Name = "iconUserName";
            this.iconUserName.Size = new System.Drawing.Size(94, 86);
            this.iconUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconUserName.TabIndex = 1;
            this.iconUserName.TabStop = false;
            // 
            // loginTopPanel
            // 
            this.loginTopPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.loginTopPanel.Controls.Add(this.labelCloseLoginFormBottom);
            this.loginTopPanel.Controls.Add(this.labelLoginTopPanel);
            this.loginTopPanel.Location = new System.Drawing.Point(0, 0);
            this.loginTopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.loginTopPanel.Name = "loginTopPanel";
            this.loginTopPanel.Size = new System.Drawing.Size(633, 101);
            this.loginTopPanel.TabIndex = 0;
            // 
            // labelCloseLoginFormBottom
            // 
            this.labelCloseLoginFormBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseLoginFormBottom.AutoSize = true;
            this.labelCloseLoginFormBottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseLoginFormBottom.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCloseLoginFormBottom.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelCloseLoginFormBottom.Location = new System.Drawing.Point(571, 0);
            this.labelCloseLoginFormBottom.Name = "labelCloseLoginFormBottom";
            this.labelCloseLoginFormBottom.Size = new System.Drawing.Size(62, 65);
            this.labelCloseLoginFormBottom.TabIndex = 1;
            this.labelCloseLoginFormBottom.Text = "X";
            this.labelCloseLoginFormBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCloseLoginFormBottom.Click += new System.EventHandler(this.labelCloseLoginForm_Click);
            this.labelCloseLoginFormBottom.MouseLeave += new System.EventHandler(this.labelCloseLoginFormBottom_MouseLeave);
            this.labelCloseLoginFormBottom.MouseHover += new System.EventHandler(this.labelCloseLoginForm_MouseHover);
            // 
            // labelLoginTopPanel
            // 
            this.labelLoginTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.labelLoginTopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLoginTopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoginTopPanel.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoginTopPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelLoginTopPanel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelLoginTopPanel.Location = new System.Drawing.Point(0, 0);
            this.labelLoginTopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoginTopPanel.Name = "labelLoginTopPanel";
            this.labelLoginTopPanel.Size = new System.Drawing.Size(633, 101);
            this.labelLoginTopPanel.TabIndex = 0;
            this.labelLoginTopPanel.Text = "Авторизация";
            this.labelLoginTopPanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelLoginTopPanel.Click += new System.EventHandler(this.labelLoginTopPanel_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 372);
            this.Controls.Add(this.loginMainPanel);
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.loginMainPanel.ResumeLayout(false);
            this.loginMainPanel.PerformLayout();
            this.loginButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUserName)).EndInit();
            this.loginTopPanel.ResumeLayout(false);
            this.loginTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginMainPanel;
        private System.Windows.Forms.Panel loginTopPanel;
        private System.Windows.Forms.Label labelLoginTopPanel;
        private System.Windows.Forms.Label labelCloseLoginFormBottom;
        private System.Windows.Forms.PictureBox iconUserName;
        private System.Windows.Forms.Panel loginButtonsPanel;
        private System.Windows.Forms.TextBox fieldPasswordInput;
        private System.Windows.Forms.PictureBox iconPassword;
        private System.Windows.Forms.TextBox fieldUserNameInput;
        private System.Windows.Forms.Button loginDataDrop;
        private System.Windows.Forms.Button loginDataEnter;
    }
}
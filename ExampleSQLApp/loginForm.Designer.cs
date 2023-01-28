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
            this.loginTopPanel = new System.Windows.Forms.Panel();
            this.labelLoginTopPanel = new System.Windows.Forms.Label();
            this.loginMainPanel.SuspendLayout();
            this.loginTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginMainPanel
            // 
            this.loginMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(201)))), ((int)(((byte)(128)))));
            this.loginMainPanel.Controls.Add(this.loginTopPanel);
            this.loginMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginMainPanel.Location = new System.Drawing.Point(0, 0);
            this.loginMainPanel.Name = "loginMainPanel";
            this.loginMainPanel.Size = new System.Drawing.Size(636, 372);
            this.loginMainPanel.TabIndex = 0;
            // 
            // loginTopPanel
            // 
            this.loginTopPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.loginTopPanel.Controls.Add(this.labelLoginTopPanel);
            this.loginTopPanel.Location = new System.Drawing.Point(3, 3);
            this.loginTopPanel.Name = "loginTopPanel";
            this.loginTopPanel.Size = new System.Drawing.Size(633, 189);
            this.loginTopPanel.TabIndex = 0;
            // 
            // labelLoginTopPanel
            // 
            this.labelLoginTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.labelLoginTopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLoginTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLoginTopPanel.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoginTopPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelLoginTopPanel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelLoginTopPanel.Location = new System.Drawing.Point(0, 0);
            this.labelLoginTopPanel.Name = "labelLoginTopPanel";
            this.labelLoginTopPanel.Size = new System.Drawing.Size(633, 131);
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
            this.loginTopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginMainPanel;
        private System.Windows.Forms.Panel loginTopPanel;
        private System.Windows.Forms.Label labelLoginTopPanel;
    }
}
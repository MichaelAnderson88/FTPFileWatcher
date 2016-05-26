namespace FTPFileWatcher
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.filesInfoLabel = new System.Windows.Forms.Label();
            this.filesLabel = new System.Windows.Forms.Label();
            this.buttonSQLWatcher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SQLChangesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check FTP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filesInfoLabel
            // 
            this.filesInfoLabel.AutoSize = true;
            this.filesInfoLabel.Location = new System.Drawing.Point(94, 18);
            this.filesInfoLabel.Name = "filesInfoLabel";
            this.filesInfoLabel.Size = new System.Drawing.Size(74, 13);
            this.filesInfoLabel.TabIndex = 1;
            this.filesInfoLabel.Text = "Files in Folder:";
            // 
            // filesLabel
            // 
            this.filesLabel.AutoSize = true;
            this.filesLabel.Location = new System.Drawing.Point(171, 18);
            this.filesLabel.Name = "filesLabel";
            this.filesLabel.Size = new System.Drawing.Size(0, 13);
            this.filesLabel.TabIndex = 2;
            // 
            // buttonSQLWatcher
            // 
            this.buttonSQLWatcher.Location = new System.Drawing.Point(13, 72);
            this.buttonSQLWatcher.Name = "buttonSQLWatcher";
            this.buttonSQLWatcher.Size = new System.Drawing.Size(75, 23);
            this.buttonSQLWatcher.TabIndex = 3;
            this.buttonSQLWatcher.Text = "SQL Watcher";
            this.buttonSQLWatcher.UseVisualStyleBackColor = true;
            this.buttonSQLWatcher.Click += new System.EventHandler(this.buttonSQLWatcher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Changes:";
            // 
            // SQLChangesLabel
            // 
            this.SQLChangesLabel.AutoSize = true;
            this.SQLChangesLabel.Location = new System.Drawing.Point(152, 77);
            this.SQLChangesLabel.Name = "SQLChangesLabel";
            this.SQLChangesLabel.Size = new System.Drawing.Size(0, 13);
            this.SQLChangesLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SQLChangesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSQLWatcher);
            this.Controls.Add(this.filesLabel);
            this.Controls.Add(this.filesInfoLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label filesInfoLabel;
        private System.Windows.Forms.Label filesLabel;
        private System.Windows.Forms.Button buttonSQLWatcher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SQLChangesLabel;
    }
}


namespace Unique_Words
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
            this.initialListBox = new System.Windows.Forms.ListBox();
            this.afterListBox = new System.Windows.Forms.ListBox();
            this.uniqueWordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // initialListBox
            // 
            this.initialListBox.FormattingEnabled = true;
            this.initialListBox.Location = new System.Drawing.Point(12, 38);
            this.initialListBox.Name = "initialListBox";
            this.initialListBox.Size = new System.Drawing.Size(259, 355);
            this.initialListBox.TabIndex = 0;
            // 
            // afterListBox
            // 
            this.afterListBox.FormattingEnabled = true;
            this.afterListBox.Location = new System.Drawing.Point(442, 38);
            this.afterListBox.Name = "afterListBox";
            this.afterListBox.Size = new System.Drawing.Size(259, 355);
            this.afterListBox.TabIndex = 1;
            // 
            // uniqueWordButton
            // 
            this.uniqueWordButton.Location = new System.Drawing.Point(291, 156);
            this.uniqueWordButton.Name = "uniqueWordButton";
            this.uniqueWordButton.Size = new System.Drawing.Size(130, 126);
            this.uniqueWordButton.TabIndex = 2;
            this.uniqueWordButton.Text = "Find Unique Words";
            this.uniqueWordButton.UseVisualStyleBackColor = true;
            this.uniqueWordButton.Click += new System.EventHandler(this.uniqueWordButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.uniqueWordButton);
            this.Controls.Add(this.afterListBox);
            this.Controls.Add(this.initialListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox initialListBox;
        private System.Windows.Forms.ListBox afterListBox;
        private System.Windows.Forms.Button uniqueWordButton;
    }
}


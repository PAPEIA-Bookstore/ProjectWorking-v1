namespace login_register
{
    partial class Forum
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
            forumLabel1 = new Label();
            SuspendLayout();
            // 
            // forumLabel1
            // 
            forumLabel1.AutoSize = true;
            forumLabel1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forumLabel1.ForeColor = Color.FromArgb(73, 60, 52);
            forumLabel1.Location = new Point(12, 9);
            forumLabel1.Name = "forumLabel1";
            forumLabel1.Size = new Size(144, 42);
            forumLabel1.TabIndex = 0;
            forumLabel1.Text = "Forum";
            // 
            // Forum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1273, 716);
            Controls.Add(forumLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Forum";
            Text = "Forum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label forumLabel1;
    }
}
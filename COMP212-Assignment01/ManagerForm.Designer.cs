namespace COMP212_Assignment01
{
    partial class ManagerForm
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
            this.subscriptionButton = new System.Windows.Forms.Button();
            this.publishButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subscriptionButton
            // 
            this.subscriptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionButton.Location = new System.Drawing.Point(13, 34);
            this.subscriptionButton.Name = "subscriptionButton";
            this.subscriptionButton.Size = new System.Drawing.Size(136, 51);
            this.subscriptionButton.TabIndex = 0;
            this.subscriptionButton.Text = "Manage Subscription";
            this.subscriptionButton.UseVisualStyleBackColor = true;
            this.subscriptionButton.Click += new System.EventHandler(this.subscriptionButton_Click);
            // 
            // publishButton
            // 
            this.publishButton.Location = new System.Drawing.Point(173, 34);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(136, 51);
            this.publishButton.TabIndex = 1;
            this.publishButton.Text = "Publish Newsletter";
            this.publishButton.UseVisualStyleBackColor = true;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(334, 34);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(76, 51);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 117);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.subscriptionButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 156);
            this.MinimumSize = new System.Drawing.Size(440, 156);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Newsletter Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button subscriptionButton;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.Button exitButton;
    }
}


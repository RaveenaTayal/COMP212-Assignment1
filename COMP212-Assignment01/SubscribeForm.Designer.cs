namespace COMP212_Assignment01
{
    partial class SubscribeForm
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
            this.emailCheckBox = new System.Windows.Forms.CheckBox();
            this.mobileCheckBox = new System.Windows.Forms.CheckBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.subscribeButton = new System.Windows.Forms.Button();
            this.unsubscribeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailCheckBox
            // 
            this.emailCheckBox.AutoSize = true;
            this.emailCheckBox.Location = new System.Drawing.Point(35, 35);
            this.emailCheckBox.Name = "emailCheckBox";
            this.emailCheckBox.Size = new System.Drawing.Size(136, 17);
            this.emailCheckBox.TabIndex = 0;
            this.emailCheckBox.Text = "Message Sent by Email";
            this.emailCheckBox.UseVisualStyleBackColor = true;
            this.emailCheckBox.CheckedChanged += new System.EventHandler(this.emailCheckBox_CheckedChanged);
            // 
            // mobileCheckBox
            // 
            this.mobileCheckBox.AutoSize = true;
            this.mobileCheckBox.Location = new System.Drawing.Point(35, 75);
            this.mobileCheckBox.Name = "mobileCheckBox";
            this.mobileCheckBox.Size = new System.Drawing.Size(142, 17);
            this.mobileCheckBox.TabIndex = 1;
            this.mobileCheckBox.Text = "Message Sent by Mobile";
            this.mobileCheckBox.UseVisualStyleBackColor = true;
            this.mobileCheckBox.CheckedChanged += new System.EventHandler(this.mobileCheckBox_CheckedChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(219, 33);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(181, 20);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.Text = "Enter your email";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Enabled = false;
            this.mobileTextBox.Location = new System.Drawing.Point(219, 73);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(181, 20);
            this.mobileTextBox.TabIndex = 3;
            this.mobileTextBox.Text = "xxx-xxx-xxxx";
            // 
            // subscribeButton
            // 
            this.subscribeButton.Location = new System.Drawing.Point(35, 127);
            this.subscribeButton.Name = "subscribeButton";
            this.subscribeButton.Size = new System.Drawing.Size(82, 27);
            this.subscribeButton.TabIndex = 4;
            this.subscribeButton.Text = "Subscribe";
            this.subscribeButton.UseVisualStyleBackColor = true;
            this.subscribeButton.Click += new System.EventHandler(this.subscribeButton_Click);
            // 
            // unsubscribeButton
            // 
            this.unsubscribeButton.Location = new System.Drawing.Point(170, 127);
            this.unsubscribeButton.Name = "unsubscribeButton";
            this.unsubscribeButton.Size = new System.Drawing.Size(89, 27);
            this.unsubscribeButton.TabIndex = 5;
            this.unsubscribeButton.Text = "Unsubscribe";
            this.unsubscribeButton.UseVisualStyleBackColor = true;
            this.unsubscribeButton.Click += new System.EventHandler(this.unsubscribeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(318, 127);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(82, 27);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SubscribeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 185);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.unsubscribeButton);
            this.Controls.Add(this.subscribeButton);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.mobileCheckBox);
            this.Controls.Add(this.emailCheckBox);
            this.Name = "SubscribeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subscribe Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox emailCheckBox;
        private System.Windows.Forms.CheckBox mobileCheckBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.Button subscribeButton;
        private System.Windows.Forms.Button unsubscribeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
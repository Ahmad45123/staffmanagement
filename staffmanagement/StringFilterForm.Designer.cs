using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace staffmanagement
{
    public partial class StringFilterForm : Form
    {
        public CheckBox isStartOnly;

        public Button okButton;

        public TextBox textBox;
        private IContainer components;

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (this.components != null))
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.isStartOnly = new System.Windows.Forms.CheckBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isStartOnly
            // 
            this.isStartOnly.AutoSize = true;
            this.isStartOnly.Location = new System.Drawing.Point(13, 13);
            this.isStartOnly.Margin = new System.Windows.Forms.Padding(4);
            this.isStartOnly.Name = "isStartOnly";
            this.isStartOnly.Size = new System.Drawing.Size(91, 21);
            this.isStartOnly.TabIndex = 0;
            this.isStartOnly.Text = "اول النص فقط";
            this.isStartOnly.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(13, 40);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(445, 23);
            this.textBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(373, 68);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(85, 32);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "تم";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // StringFilterForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 109);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.isStartOnly);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StringFilterForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StringFilterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

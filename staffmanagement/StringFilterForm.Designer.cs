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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(StringFilterForm));
            this.isStartOnly = new CheckBox();
            this.textBox = new TextBox();
            this.okButton = new Button();
            base.SuspendLayout();
            this.isStartOnly.AutoSize = true;
            this.isStartOnly.Location = new Point(13, 13);
            this.isStartOnly.Margin = new Padding(4);
            this.isStartOnly.Name = "isStartOnly";
            this.isStartOnly.Size = new Size(0x5b, 0x15);
            this.isStartOnly.TabIndex = 0;
            this.isStartOnly.Text = "اول النص فقط";
            this.isStartOnly.UseVisualStyleBackColor = true;
            this.textBox.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            this.textBox.Location = new Point(13, 40);
            this.textBox.Name = "textBox";
            this.textBox.Size = new Size(0x1bd, 0x17);
            this.textBox.TabIndex = 1;
            this.okButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.okButton.Location = new Point(0x175, 0x44);
            this.okButton.Name = "okButton";
            this.okButton.Size = new Size(0x55, 0x20);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "تم";
            this.okButton.UseVisualStyleBackColor = true;
            base.AcceptButton = this.okButton;
            base.AutoScaleDimensions = new SizeF(8f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x1d1, 0x6d);
            base.Controls.Add(this.okButton);
            base.Controls.Add(this.textBox);
            base.Controls.Add(this.isStartOnly);
            this.Font = new Font("Microsoft Sans Serif", 10f);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.Margin = new Padding(4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "StringFilterForm";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "StringFilterForm";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}

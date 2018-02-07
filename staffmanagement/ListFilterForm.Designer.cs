using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace staffmanagement
{
    public partial class ListFilterForm : Form
    {
        private Button Button1;
        public ComboBox listBox;
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(ListFilterForm));
            this.listBox = new ComboBox();
            this.Button1 = new Button();
            base.SuspendLayout();
            this.listBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new Point(13, 13);
            this.listBox.Margin = new Padding(4, 4, 4, 4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new Size(0x148, 0x18);
            this.listBox.TabIndex = 0;
            this.Button1.Location = new Point(0x10a, 0x2c);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0x4b, 0x1b);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "تم";
            this.Button1.UseVisualStyleBackColor = true;
            base.AcceptButton = this.Button1;
            base.AutoScaleDimensions = new SizeF(8f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x162, 0x52);
            base.Controls.Add(this.Button1);
            base.Controls.Add(this.listBox);
            this.Font = new Font("Microsoft Sans Serif", 10f);
            base.Margin = new Padding(4, 4, 4, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ListFilterForm";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ListFilterForm";
            base.ResumeLayout(false);
        }
    }
}

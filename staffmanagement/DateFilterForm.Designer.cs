using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace staffmanagement
{
    public partial class DateFilterForm : Form
    {
        private Button Button1;
        public DateTimePicker endDate;
        private Label Label1;
        private Label Label2;
        public DateTimePicker startDate;
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(DateFilterForm));
            this.Label1 = new Label();
            this.startDate = new DateTimePicker();
            this.Label2 = new Label();
            this.endDate = new DateTimePicker();
            this.Button1 = new Button();
            base.SuspendLayout();
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(14, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x1c, 0x11);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "من :";
            this.startDate.Format = DateTimePickerFormat.Short;
            this.startDate.Location = new Point(0x30, 9);
            this.startDate.Name = "startDate";
            this.startDate.RightToLeftLayout = true;
            this.startDate.Size = new Size(200, 0x17);
            this.startDate.TabIndex = 1;
            this.Label2.AutoSize = true;
            this.Label2.Location = new Point(12, 0x2b);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(30, 0x11);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "الي :";
            this.endDate.Format = DateTimePickerFormat.Short;
            this.endDate.Location = new Point(0x30, 0x26);
            this.endDate.Name = "endDate";
            this.endDate.RightToLeftLayout = true;
            this.endDate.Size = new Size(200, 0x17);
            this.endDate.TabIndex = 3;
            this.Button1.Location = new Point(0xad, 0x43);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0x4b, 30);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "تم";
            this.Button1.UseVisualStyleBackColor = true;
            base.AcceptButton = this.Button1;
            base.AutoScaleDimensions = new SizeF(8f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x109, 0x6b);
            base.Controls.Add(this.Button1);
            base.Controls.Add(this.endDate);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.startDate);
            base.Controls.Add(this.Label1);
            this.Font = new Font("Microsoft Sans Serif", 10f);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Margin = new Padding(4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "DateFilterForm";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "DateFilterForm";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}

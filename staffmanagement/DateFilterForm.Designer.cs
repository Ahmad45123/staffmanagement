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
            this.Label1 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(28, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "من :";
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(48, 9);
            this.startDate.Name = "startDate";
            this.startDate.RightToLeftLayout = true;
            this.startDate.Size = new System.Drawing.Size(200, 23);
            this.startDate.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 43);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(30, 17);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "الي :";
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(48, 38);
            this.endDate.Name = "endDate";
            this.endDate.RightToLeftLayout = true;
            this.endDate.Size = new System.Drawing.Size(200, 23);
            this.endDate.TabIndex = 3;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(173, 67);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 30);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "تم";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DateFilterForm
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 107);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateFilterForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateFilterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

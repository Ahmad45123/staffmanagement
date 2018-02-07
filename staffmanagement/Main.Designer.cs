using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace staffmanagement
{
    partial class Main : Form
    {
        
        private MenuStrip MenuStrip1;
        
        private ToolStripSeparator ToolStripMenuItem1;
        
        private ToolStripSeparator ToolStripMenuItem2;
        
        private ToolStripSeparator ToolStripMenuItem3;
        
        private ToolStripSeparator ToolStripMenuItem4;
        
        private ToolStripMenuItem اداToolStripMenuItem;
        
        private ToolStripMenuItem اداراتToolStripMenuItem;
        
        private ToolStripMenuItem ادارةالموظفينToolStripMenuItem;
        
        private ToolStripMenuItem ادارةالوظائفToolStripMenuItem;
        
        private ToolStripMenuItem ادواتToolStripMenuItem;
        
        private ToolStripMenuItem استيرادToolStripMenuItem;
        
        private ToolStripMenuItem بحثToolStripMenuItem;
        
        private ToolStripMenuItem بحثToolStripMenuItem1;
        
        private ToolStripMenuItem تصديرToolStripMenuItem;
        
        private ToolStripMenuItem تعديلToolStripMenuItem;
        
        private ToolStripMenuItem تعديلToolStripMenuItem1;
        
        private ToolStripMenuItem تعليكاتToolStripMenuItem;
        
        private ToolStripMenuItem تعليماتToolStripMenuItem;
        
        private ToolStripMenuItem تغييركلمةالمرورToolStripMenuItem;
        
        private ToolStripMenuItem خروجToolStripMenuItem;
        
        private ToolStripMenuItem دعمفنيToolStripMenuItem;
        
        private ToolStripMenuItem ديربنجمToolStripMenuItem;
        
        private ToolStripMenuItem عنToolStripMenuItem;
        private ToolStripMenuItem مToolStripMenuItem;
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.مToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اداراتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ديربنجمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.تصديرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استيرادToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالموظفينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اداToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالوظائفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.بحثToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.بحثToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادواتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تغييركلمةالمرورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعليماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.تعليكاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دعمفنيToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مToolStripMenuItem,
            this.ادارةالموظفينToolStripMenuItem,
            this.بحثToolStripMenuItem,
            this.ادواتToolStripMenuItem,
            this.عنToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(630, 24);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // مToolStripMenuItem
            // 
            this.مToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اداراتToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.تصديرToolStripMenuItem,
            this.استيرادToolStripMenuItem,
            this.ToolStripMenuItem2,
            this.خروجToolStripMenuItem});
            this.مToolStripMenuItem.Name = "مToolStripMenuItem";
            this.مToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.مToolStripMenuItem.Text = "ملف";
            // 
            // اداراتToolStripMenuItem
            // 
            this.اداراتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ديربنجمToolStripMenuItem});
            this.اداراتToolStripMenuItem.Name = "اداراتToolStripMenuItem";
            this.اداراتToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.اداراتToolStripMenuItem.Text = "ادارات";
            // 
            // ديربنجمToolStripMenuItem
            // 
            this.ديربنجمToolStripMenuItem.Name = "ديربنجمToolStripMenuItem";
            this.ديربنجمToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.ديربنجمToolStripMenuItem.Text = "ديرب نجم";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(105, 6);
            // 
            // تصديرToolStripMenuItem
            // 
            this.تصديرToolStripMenuItem.Name = "تصديرToolStripMenuItem";
            this.تصديرToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.تصديرToolStripMenuItem.Text = "تصدير";
            // 
            // استيرادToolStripMenuItem
            // 
            this.استيرادToolStripMenuItem.Name = "استيرادToolStripMenuItem";
            this.استيرادToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.استيرادToolStripMenuItem.Text = "استيراد";
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(105, 6);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // ادارةالموظفينToolStripMenuItem
            // 
            this.ادارةالموظفينToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اداToolStripMenuItem,
            this.ادارةالوظائفToolStripMenuItem,
            this.ToolStripMenuItem4,
            this.تعديلToolStripMenuItem,
            this.تعديلToolStripMenuItem1,
            this.بحثToolStripMenuItem1});
            this.ادارةالموظفينToolStripMenuItem.Name = "ادارةالموظفينToolStripMenuItem";
            this.ادارةالموظفينToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.ادارةالموظفينToolStripMenuItem.Text = "ادارة الموظفين";
            // 
            // اداToolStripMenuItem
            // 
            this.اداToolStripMenuItem.Name = "اداToolStripMenuItem";
            this.اداToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.اداToolStripMenuItem.Text = "ادارة الاقسام";
            this.اداToolStripMenuItem.Click += new System.EventHandler(this.اداToolStripMenuItem_Click);
            // 
            // ادارةالوظائفToolStripMenuItem
            // 
            this.ادارةالوظائفToolStripMenuItem.Name = "ادارةالوظائفToolStripMenuItem";
            this.ادارةالوظائفToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ادارةالوظائفToolStripMenuItem.Text = "ادارة الوظائف";
            this.ادارةالوظائفToolStripMenuItem.Click += new System.EventHandler(this.ادارةالوظائفToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(138, 6);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.تعديلToolStripMenuItem.Text = "اضافة";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // تعديلToolStripMenuItem1
            // 
            this.تعديلToolStripMenuItem1.Name = "تعديلToolStripMenuItem1";
            this.تعديلToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.تعديلToolStripMenuItem1.Text = "تعديل";
            this.تعديلToolStripMenuItem1.Click += new System.EventHandler(this.تعديلToolStripMenuItem1_Click);
            // 
            // بحثToolStripMenuItem1
            // 
            this.بحثToolStripMenuItem1.Name = "بحثToolStripMenuItem1";
            this.بحثToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.بحثToolStripMenuItem1.Text = "بحث";
            // 
            // بحثToolStripMenuItem
            // 
            this.بحثToolStripMenuItem.Name = "بحثToolStripMenuItem";
            this.بحثToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.بحثToolStripMenuItem.Text = "السجل العام";
            this.بحثToolStripMenuItem.Click += new System.EventHandler(this.بحثToolStripMenuItem_Click);
            // 
            // ادواتToolStripMenuItem
            // 
            this.ادواتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تغييركلمةالمرورToolStripMenuItem});
            this.ادواتToolStripMenuItem.Name = "ادواتToolStripMenuItem";
            this.ادواتToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ادواتToolStripMenuItem.Text = "ادوات";
            // 
            // تغييركلمةالمرورToolStripMenuItem
            // 
            this.تغييركلمةالمرورToolStripMenuItem.Name = "تغييركلمةالمرورToolStripMenuItem";
            this.تغييركلمةالمرورToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.تغييركلمةالمرورToolStripMenuItem.Text = "تغيير كلمة المرور";
            this.تغييركلمةالمرورToolStripMenuItem.Click += new System.EventHandler(this.تغييركلمةالمرورToolStripMenuItem_Click);
            // 
            // عنToolStripMenuItem
            // 
            this.عنToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعليماتToolStripMenuItem,
            this.ToolStripMenuItem3,
            this.تعليكاتToolStripMenuItem,
            this.دعمفنيToolStripMenuItem});
            this.عنToolStripMenuItem.Name = "عنToolStripMenuItem";
            this.عنToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.عنToolStripMenuItem.Text = "مساعدة";
            // 
            // تعليماتToolStripMenuItem
            // 
            this.تعليماتToolStripMenuItem.Name = "تعليماتToolStripMenuItem";
            this.تعليماتToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.تعليماتToolStripMenuItem.Text = "التحقق من وجود تحديثات";
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(192, 6);
            // 
            // تعليكاتToolStripMenuItem
            // 
            this.تعليكاتToolStripMenuItem.Name = "تعليكاتToolStripMenuItem";
            this.تعليكاتToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.تعليكاتToolStripMenuItem.Text = "تعليمات";
            // 
            // دعمفنيToolStripMenuItem
            // 
            this.دعمفنيToolStripMenuItem.Name = "دعمفنيToolStripMenuItem";
            this.دعمفنيToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.دعمفنيToolStripMenuItem.Text = "دعم فني";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 422);
            this.Controls.Add(this.MenuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الوصيفي";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

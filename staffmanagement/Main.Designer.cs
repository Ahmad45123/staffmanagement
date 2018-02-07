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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Main));
            this.MenuStrip1 = new MenuStrip();
            this.مToolStripMenuItem = new ToolStripMenuItem();
            this.اداراتToolStripMenuItem = new ToolStripMenuItem();
            this.ديربنجمToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripMenuItem1 = new ToolStripSeparator();
            this.تصديرToolStripMenuItem = new ToolStripMenuItem();
            this.استيرادToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripMenuItem2 = new ToolStripSeparator();
            this.خروجToolStripMenuItem = new ToolStripMenuItem();
            this.ادارةالموظفينToolStripMenuItem = new ToolStripMenuItem();
            this.اداToolStripMenuItem = new ToolStripMenuItem();
            this.ادارةالوظائفToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripMenuItem4 = new ToolStripSeparator();
            this.تعديلToolStripMenuItem = new ToolStripMenuItem();
            this.تعديلToolStripMenuItem1 = new ToolStripMenuItem();
            this.بحثToolStripMenuItem1 = new ToolStripMenuItem();
            this.بحثToolStripMenuItem = new ToolStripMenuItem();
            this.ادواتToolStripMenuItem = new ToolStripMenuItem();
            this.تغييركلمةالمرورToolStripMenuItem = new ToolStripMenuItem();
            this.عنToolStripMenuItem = new ToolStripMenuItem();
            this.تعليماتToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripMenuItem3 = new ToolStripSeparator();
            this.تعليكاتToolStripMenuItem = new ToolStripMenuItem();
            this.دعمفنيToolStripMenuItem = new ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            base.SuspendLayout();
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.مToolStripMenuItem, this.ادارةالموظفينToolStripMenuItem, this.بحثToolStripMenuItem, this.ادواتToolStripMenuItem, this.عنToolStripMenuItem };
            this.MenuStrip1.Items.AddRange(toolStripItems);
            this.MenuStrip1.Location = new Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new Size(630, 0x18);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.اداراتToolStripMenuItem, this.ToolStripMenuItem1, this.تصديرToolStripMenuItem, this.استيرادToolStripMenuItem, this.ToolStripMenuItem2, this.خروجToolStripMenuItem };
            this.مToolStripMenuItem.DropDownItems.AddRange(itemArray2);
            this.مToolStripMenuItem.Name = "مToolStripMenuItem";
            this.مToolStripMenuItem.Size = new Size(0x2a, 20);
            this.مToolStripMenuItem.Text = "ملف";
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.ديربنجمToolStripMenuItem };
            this.اداراتToolStripMenuItem.DropDownItems.AddRange(itemArray3);
            this.اداراتToolStripMenuItem.Name = "اداراتToolStripMenuItem";
            this.اداراتToolStripMenuItem.Size = new Size(0x6c, 0x16);
            this.اداراتToolStripMenuItem.Text = "ادارات";
            this.ديربنجمToolStripMenuItem.Name = "ديربنجمToolStripMenuItem";
            this.ديربنجمToolStripMenuItem.Size = new Size(120, 0x16);
            this.ديربنجمToolStripMenuItem.Text = "ديرب نجم";
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new Size(0x69, 6);
            this.تصديرToolStripMenuItem.Name = "تصديرToolStripMenuItem";
            this.تصديرToolStripMenuItem.Size = new Size(0x6c, 0x16);
            this.تصديرToolStripMenuItem.Text = "تصدير";
            this.استيرادToolStripMenuItem.Name = "استيرادToolStripMenuItem";
            this.استيرادToolStripMenuItem.Size = new Size(0x6c, 0x16);
            this.استيرادToolStripMenuItem.Text = "استيراد";
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new Size(0x69, 6);
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new Size(0x6c, 0x16);
            this.خروجToolStripMenuItem.Text = "خروج";
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.اداToolStripMenuItem, this.ادارةالوظائفToolStripMenuItem, this.ToolStripMenuItem4, this.تعديلToolStripMenuItem, this.تعديلToolStripMenuItem1, this.بحثToolStripMenuItem1 };
            this.ادارةالموظفينToolStripMenuItem.DropDownItems.AddRange(itemArray4);
            this.ادارةالموظفينToolStripMenuItem.Name = "ادارةالموظفينToolStripMenuItem";
            this.ادارةالموظفينToolStripMenuItem.Size = new Size(0x5c, 20);
            this.ادارةالموظفينToolStripMenuItem.Text = "ادارة الموظفين";
            this.اداToolStripMenuItem.Name = "اداToolStripMenuItem";
            this.اداToolStripMenuItem.Size = new Size(0x8d, 0x16);
            this.اداToolStripMenuItem.Text = "ادارة الاقسام";
            this.ادارةالوظائفToolStripMenuItem.Name = "ادارةالوظائفToolStripMenuItem";
            this.ادارةالوظائفToolStripMenuItem.Size = new Size(0x8d, 0x16);
            this.ادارةالوظائفToolStripMenuItem.Text = "ادارة الوظائف";
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new Size(0x8a, 6);
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new Size(0x8d, 0x16);
            this.تعديلToolStripMenuItem.Text = "اضافة";
            this.تعديلToolStripMenuItem1.Name = "تعديلToolStripMenuItem1";
            this.تعديلToolStripMenuItem1.Size = new Size(0x8d, 0x16);
            this.تعديلToolStripMenuItem1.Text = "تعديل";
            this.بحثToolStripMenuItem1.Name = "بحثToolStripMenuItem1";
            this.بحثToolStripMenuItem1.Size = new Size(0x8d, 0x16);
            this.بحثToolStripMenuItem1.Text = "بحث";
            this.بحثToolStripMenuItem.Name = "بحثToolStripMenuItem";
            this.بحثToolStripMenuItem.Size = new Size(0x4e, 20);
            this.بحثToolStripMenuItem.Text = "السجل العام";
            ToolStripItem[] itemArray5 = new ToolStripItem[] { this.تغييركلمةالمرورToolStripMenuItem };
            this.ادواتToolStripMenuItem.DropDownItems.AddRange(itemArray5);
            this.ادواتToolStripMenuItem.Name = "ادواتToolStripMenuItem";
            this.ادواتToolStripMenuItem.Size = new Size(0x30, 20);
            this.ادواتToolStripMenuItem.Text = "ادوات";
            this.تغييركلمةالمرورToolStripMenuItem.Name = "تغييركلمةالمرورToolStripMenuItem";
            this.تغييركلمةالمرورToolStripMenuItem.Size = new Size(0x9c, 0x16);
            this.تغييركلمةالمرورToolStripMenuItem.Text = "تغيير كلمة المرور";
            ToolStripItem[] itemArray6 = new ToolStripItem[] { this.تعليماتToolStripMenuItem, this.ToolStripMenuItem3, this.تعليكاتToolStripMenuItem, this.دعمفنيToolStripMenuItem };
            this.عنToolStripMenuItem.DropDownItems.AddRange(itemArray6);
            this.عنToolStripMenuItem.Name = "عنToolStripMenuItem";
            this.عنToolStripMenuItem.Size = new Size(0x3a, 20);
            this.عنToolStripMenuItem.Text = "مساعدة";
            this.تعليماتToolStripMenuItem.Name = "تعليماتToolStripMenuItem";
            this.تعليماتToolStripMenuItem.Size = new Size(0xc3, 0x16);
            this.تعليماتToolStripMenuItem.Text = "التحقق من وجود تحديثات";
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new Size(0xc0, 6);
            this.تعليكاتToolStripMenuItem.Name = "تعليكاتToolStripMenuItem";
            this.تعليكاتToolStripMenuItem.Size = new Size(0xc3, 0x16);
            this.تعليكاتToolStripMenuItem.Text = "تعليمات";
            this.دعمفنيToolStripMenuItem.Name = "دعمفنيToolStripMenuItem";
            this.دعمفنيToolStripMenuItem.Size = new Size(0xc3, 0x16);
            this.دعمفنيToolStripMenuItem.Text = "دعم فني";
            base.AutoScaleDimensions = new SizeF(8f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(630, 0x1a6);
            base.Controls.Add(this.MenuStrip1);
            this.Font = new Font("Microsoft Sans Serif", 10f);
            base.IsMdiContainer = true;
            base.MainMenuStrip = this.MenuStrip1;
            base.Margin = new Padding(4);
            base.Name = "Main";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الوصيفي";
            base.WindowState = FormWindowState.Maximized;
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}

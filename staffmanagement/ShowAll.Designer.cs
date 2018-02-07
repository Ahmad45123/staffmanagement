using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace staffmanagement
{
    public partial class ShowAll
    {
        private DataGridView dataGrid;
        private ContextMenuStrip editStaffcontextMenu;
        private ContextMenuStrip headerMenuStrip;
        private ToolStripSeparator ToolStripMenuItem1;
        private ToolStripMenuItem تحديثToolStripMenuItem;
        private ToolStripMenuItem تصنيفToolStripMenuItem;
        private ToolStripMenuItem تعديلالموظفToolStripMenuItem;
        private ToolStripMenuItem مسحالموظفToolStripMenuItem;
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
            this.components = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(ShowAll));
            this.dataGrid = new DataGridView();
            this.editStaffcontextMenu = new ContextMenuStrip(this.components);
            this.تعديلالموظفToolStripMenuItem = new ToolStripMenuItem();
            this.مسحالموظفToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripMenuItem1 = new ToolStripSeparator();
            this.تحديثToolStripMenuItem = new ToolStripMenuItem();
            this.headerMenuStrip = new ContextMenuStrip(this.components);
            this.تصنيفToolStripMenuItem = new ToolStripMenuItem();
            ((ISupportInitialize)this.dataGrid).BeginInit();
            this.editStaffcontextMenu.SuspendLayout();
            this.headerMenuStrip.SuspendLayout();
            base.SuspendLayout();
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.Dock = DockStyle.Fill;
            this.dataGrid.Location = new Point(0, 0);
            this.dataGrid.Margin = new Padding(4, 3, 4, 3);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new Size(0x332, 0x1b5);
            this.dataGrid.TabIndex = 0;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.تعديلالموظفToolStripMenuItem, this.مسحالموظفToolStripMenuItem, this.ToolStripMenuItem1, this.تحديثToolStripMenuItem };
            this.editStaffcontextMenu.Items.AddRange(toolStripItems);
            this.editStaffcontextMenu.Name = "editStaffcontextMenu";
            this.editStaffcontextMenu.RightToLeft = RightToLeft.Yes;
            this.editStaffcontextMenu.Size = new Size(0x95, 0x4c);
            this.تعديلالموظفToolStripMenuItem.Name = "تعديلالموظفToolStripMenuItem";
            this.تعديلالموظفToolStripMenuItem.Size = new Size(0x94, 0x16);
            this.تعديلالموظفToolStripMenuItem.Text = "تعديل الموظف";
            this.مسحالموظفToolStripMenuItem.Name = "مسحالموظفToolStripMenuItem";
            this.مسحالموظفToolStripMenuItem.Size = new Size(0x94, 0x16);
            this.مسحالموظفToolStripMenuItem.Text = "مسح الموظف";
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new Size(0x91, 6);
            this.تحديثToolStripMenuItem.Name = "تحديثToolStripMenuItem";
            this.تحديثToolStripMenuItem.Size = new Size(0x94, 0x16);
            this.تحديثToolStripMenuItem.Text = "تحديث";
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.تصنيفToolStripMenuItem };
            this.headerMenuStrip.Items.AddRange(itemArray2);
            this.headerMenuStrip.Name = "headerMenuStrip";
            this.headerMenuStrip.RightToLeft = RightToLeft.Yes;
            this.headerMenuStrip.Size = new Size(0x61, 0x1a);
            this.تصنيفToolStripMenuItem.Name = "تصنيفToolStripMenuItem";
            this.تصنيفToolStripMenuItem.Size = new Size(0x60, 0x16);
            this.تصنيفToolStripMenuItem.Text = "بحث";
            base.AutoScaleDimensions = new SizeF(8f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x332, 0x1b5);
            base.Controls.Add(this.dataGrid);
            this.Font = new Font("Microsoft Sans Serif", 10f);
            base.Margin = new Padding(4, 3, 4, 3);
            base.Name = "ShowAll";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الموظفين";
            ((ISupportInitialize)this.dataGrid).EndInit();
            this.editStaffcontextMenu.ResumeLayout(false);
            this.headerMenuStrip.ResumeLayout(false);
            base.ResumeLayout(false);
        }
    }
}

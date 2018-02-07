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
            this.components = new System.ComponentModel.Container();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.editStaffcontextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلالموظفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مسحالموظفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headerMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تصنيفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تحديثToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.editStaffcontextMenu.SuspendLayout();
            this.headerMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(818, 437);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGrid_MouseClick);
            this.dataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGrid_MouseDoubleClick);
            // 
            // editStaffcontextMenu
            // 
            this.editStaffcontextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلالموظفToolStripMenuItem,
            this.مسحالموظفToolStripMenuItem});
            this.editStaffcontextMenu.Name = "editStaffcontextMenu";
            this.editStaffcontextMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editStaffcontextMenu.Size = new System.Drawing.Size(149, 48);
            // 
            // تعديلالموظفToolStripMenuItem
            // 
            this.تعديلالموظفToolStripMenuItem.Name = "تعديلالموظفToolStripMenuItem";
            this.تعديلالموظفToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.تعديلالموظفToolStripMenuItem.Text = "تعديل الموظف";
            this.تعديلالموظفToolStripMenuItem.Click += new System.EventHandler(this.تعديلالموظفToolStripMenuItem_Click);
            // 
            // مسحالموظفToolStripMenuItem
            // 
            this.مسحالموظفToolStripMenuItem.Name = "مسحالموظفToolStripMenuItem";
            this.مسحالموظفToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.مسحالموظفToolStripMenuItem.Text = "مسح الموظف";
            this.مسحالموظفToolStripMenuItem.Click += new System.EventHandler(this.مسحالموظفToolStripMenuItem_Click);
            // 
            // headerMenuStrip
            // 
            this.headerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تصنيفToolStripMenuItem,
            this.تحديثToolStripMenuItem});
            this.headerMenuStrip.Name = "headerMenuStrip";
            this.headerMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.headerMenuStrip.Size = new System.Drawing.Size(107, 48);
            // 
            // تصنيفToolStripMenuItem
            // 
            this.تصنيفToolStripMenuItem.Name = "تصنيفToolStripMenuItem";
            this.تصنيفToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.تصنيفToolStripMenuItem.Text = "بحث";
            this.تصنيفToolStripMenuItem.Click += new System.EventHandler(this.تصنيفToolStripMenuItem_Click);
            // 
            // تحديثToolStripMenuItem
            // 
            this.تحديثToolStripMenuItem.Name = "تحديثToolStripMenuItem";
            this.تحديثToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.تحديثToolStripMenuItem.Text = "تحديث";
            this.تحديثToolStripMenuItem.Click += new System.EventHandler(this.تحديثToolStripMenuItem_Click);
            // 
            // ShowAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 437);
            this.Controls.Add(this.dataGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ShowAll";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الموظفين";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.editStaffcontextMenu.ResumeLayout(false);
            this.headerMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private ToolStripMenuItem تحديثToolStripMenuItem;
    }
}

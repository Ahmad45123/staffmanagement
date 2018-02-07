using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace staffmanagement
{
    public partial class ManageDepartments : Form
    {
        private Button Button1;
        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn departmentName;
        private DataGridViewTextBoxColumn id;
        private Label Label1;
        private ContextMenuStrip menuStrip;
        private TextBox newDepartmentName;
        private Panel Panel1;
        private ToolStripMenuItem تعديلToolStripMenuItem;
        private ToolStripMenuItem مسحToolStripMenuItem;
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(ManageDepartments));
            this.dataGrid = new DataGridView();
            this.id = new DataGridViewTextBoxColumn();
            this.departmentName = new DataGridViewTextBoxColumn();
            this.Panel1 = new Panel();
            this.Button1 = new Button();
            this.newDepartmentName = new TextBox();
            this.Label1 = new Label();
            this.menuStrip = new ContextMenuStrip(this.components);
            this.مسحToolStripMenuItem = new ToolStripMenuItem();
            this.تعديلToolStripMenuItem = new ToolStripMenuItem();
            ((ISupportInitialize)this.dataGrid).BeginInit();
            this.Panel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            base.SuspendLayout();
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.id, this.departmentName };
            this.dataGrid.Columns.AddRange(dataGridViewColumns);
            this.dataGrid.Location = new Point(0, 0x42);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new Size(0x2db, 0x192);
            this.dataGrid.TabIndex = 0;
            this.id.HeaderText = "رقم القسم";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.departmentName.HeaderText = "اسم القسم";
            this.departmentName.Name = "departmentName";
            this.departmentName.ReadOnly = true;
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.newDepartmentName);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = DockStyle.Top;
            this.Panel1.Location = new Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new Size(0x2db, 60);
            this.Panel1.TabIndex = 1;
            this.Button1.Location = new Point(12, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0x4b, 0x22);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "اضافة القسم";
            this.Button1.UseVisualStyleBackColor = true;
            this.newDepartmentName.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.newDepartmentName.Location = new Point(0x5d, 0x13);
            this.newDepartmentName.Name = "newDepartmentName";
            this.newDepartmentName.Size = new Size(0x231, 0x17);
            this.newDepartmentName.TabIndex = 1;
            this.Label1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(660, 0x16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x3b, 0x11);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "اسم القسم :";
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.مسحToolStripMenuItem, this.تعديلToolStripMenuItem };
            this.menuStrip.Items.AddRange(toolStripItems);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = RightToLeft.Yes;
            this.menuStrip.Size = new Size(0x68, 0x30);
            this.مسحToolStripMenuItem.Name = "مسحToolStripMenuItem";
            this.مسحToolStripMenuItem.Size = new Size(0x67, 0x16);
            this.مسحToolStripMenuItem.Text = "مسح";
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new Size(0x67, 0x16);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            base.AcceptButton = this.Button1;
            base.AutoScaleDimensions = new SizeF(8f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x2db, 0x1d5);
            base.Controls.Add(this.Panel1);
            base.Controls.Add(this.dataGrid);
            this.Font = new Font("Microsoft Sans Serif", 10f);
            base.Margin = new Padding(4);
            base.Name = "ManageDepartments";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ادارة الاقسام";
            ((ISupportInitialize)this.dataGrid).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            base.ResumeLayout(false);
        }
    }
}

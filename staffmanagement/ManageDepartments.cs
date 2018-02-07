using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Windows.Forms;

namespace staffmanagement
{
    public partial class ManageDepartments : Form
    {
        public ManageDepartments()
        {
            Load += ManageDepartments_Load;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Department department = new Department {
                DepartmentName = newDepartmentName.Text
            };
            Main.Db.Insert(department);
            string[] values = { Convert.ToString(department.Id), department.DepartmentName };
            dataGrid.Rows.Add(values);
        }

        private void dataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo info = dataGrid.HitTest(e.X, e.Y);
                if (info.RowIndex != -1)
                {
                    dataGrid.ClearSelection();
                    dataGrid.Rows[info.RowIndex].Selected = true;
                    menuStrip.Show(dataGrid, e.Location);
                }
            }
        }

        private void ManageDepartments_Load(object sender, EventArgs e)
        {
            RefreshItems();
        }

        private void RefreshItems()
        {
            foreach (var current in Main.Db.Table<Department>())
            {
                string[] values = { Convert.ToString(current.Id), current.DepartmentName };
                dataGrid.Rows.Add(values);
            }
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 1)
            {
                var idd = Convert.ToString(dataGrid.SelectedRows[0].Cells[0].Value);
                string str = Interaction.InputBox("ادخل الاسم الجديد", "", Convert.ToString(dataGrid.SelectedRows[0].Cells[1].Value), -1, -1);
                if (str != "")
                {
                    Main.Db.Table<Department>().Single(depart => depart.Id == Convert.ToDouble(idd)).DepartmentName = str;
                    dataGrid.SelectedRows[0].Cells[1].Value = str;
                }
            }
        }

        private void مسحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((dataGrid.SelectedRows.Count == 1) && (Interaction.MsgBox("هل متأكد من مسح القسم ؟ سيتم مسح كل من في القسم", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes))
            {
                var idd = Convert.ToString(dataGrid.SelectedRows[0].Cells[0].Value);
                dataGrid.Rows.Remove(dataGrid.SelectedRows[0]);
                Department objectToDelete = Main.Db.Table<Department>().Single(x => x.Id == Convert.ToDouble(idd));
                Main.Db.Delete(objectToDelete);
            }
        }
    }
}


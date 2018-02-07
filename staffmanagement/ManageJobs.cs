using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Windows.Forms;

namespace staffmanagement
{

    public partial class ManageJobs : Form
    {
        public ManageJobs()
        {
            Load += ManageDepartments_Load;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Job job = new Job {
                JobName = newDepartmentName.Text
            };
            Main.Db.Insert(job);
            string[] values = { Convert.ToString(job.Id), job.JobName };
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
            foreach (var current in Main.Db.Table<Job>())
            {
                string[] values = { Convert.ToString(current.Id), current.JobName };
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
                    Main.Db.Table<Job>().Single<Job>(x => x.Id == double.Parse(idd)).JobName = str;
                    dataGrid.SelectedRows[0].Cells[1].Value = str;
                }
            }
        }

        private void مسحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((dataGrid.SelectedRows.Count == 1) && (Interaction.MsgBox("هل متأكد من مسح الوظيفة ؟ سيتم مسح كل من في الوظيفة", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes))
            {
                var idd = Convert.ToString(dataGrid.SelectedRows[0].Cells[0].Value);
                dataGrid.Rows.Remove(dataGrid.SelectedRows[0]);
                Job objectToDelete = Main.Db.Table<Job>().Single<Job>(x=> x.Id == double.Parse(idd));
                Main.Db.Delete(objectToDelete);
            }
        }
    }
}


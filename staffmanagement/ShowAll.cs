using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace staffmanagement
{
    public partial class ShowAll : Form
    {
        private int _headerSelected;

        public ShowAll()
        {
            Load += MainForm_Load;
            _headerSelected = -1;
            InitializeComponent();
        }

        private void dataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo info = dataGrid.HitTest(e.X, e.Y);
                if (info.Type == DataGridViewHitTestType.Cell)
                {
                    dataGrid.ClearSelection();
                    dataGrid.Rows[info.RowIndex].Selected = true;
                    editStaffcontextMenu.Show(dataGrid, e.Location);
                }
                else if (info.Type == DataGridViewHitTestType.ColumnHeader)
                {
                    _headerSelected = info.ColumnIndex;
                    headerMenuStrip.Show(dataGrid, e.Location);
                }
            }
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView.HitTestInfo info = dataGrid.HitTest(e.X, e.Y);
                if (info.Type == DataGridViewHitTestType.Cell)
                {
                    var t = Convert.ToString(dataGrid.Rows[info.RowIndex].Cells[0].Value);
                    Staff staff = Main.Db.Table<Staff>().Single(x => x.Id == int.Parse(t));
                    new ManageStaff { 
                        SelStaff = staff,
                        IsEdit = true,
                        MdiParent = Program.mainForm,
                        PrintButton = { Visible = true },
                        Text = "بطاقة الموظف",
                        TabPage1 = { Enabled = false },
                        TabPage2 = { Enabled = false },
                        TabPage3 = { Enabled = false },
                        TabPage4 = { Enabled = false },
                        saveButton = { Enabled = false },
                        editButton = { Visible = true }
                    }.Show();
                }
            }
        }

        private void LoadStaffListIntoList(IEnumerable<Staff> stffList)
        {
            dataGrid.SuspendLayout();
            dataGrid.Rows.Clear();
            List<DataGridViewRow> list = new List<DataGridViewRow>();

            foreach (var stf in stffList)
            {
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dataGrid);

                foreach (DataGridViewColumn current in dataGrid.Columns)
                {
                    var t = typeof(Staff).GetProperty(current.Name);
                    if ((t.PropertyType == typeof(int)) & (t.Name == "CurrentJob"))
                    {
                        Job job = Main.Db.Table<Job>().Single<Job>(x => x.Id == (int) t.GetValue(stf, null));
                        item.Cells[current.Index].Value = job.JobName;
                    }
                    else if ((t.PropertyType == typeof(int)) & (t.Name == "CurrentDepartment"))
                    {
                        Department department = Main.Db.Table<Department>()
                            .Single(x => x.Id == (int) t.GetValue(stf, null));
                        item.Cells[current.Index].Value = department.DepartmentName;
                    }
                    else if ((t.PropertyType == typeof(string)) | (t.PropertyType == typeof(int)))
                    {
                        item.Cells[current.Index].Value = t.GetValue(stf, null).ToString();
                    }
                    else if (t.PropertyType == typeof(DateTime))
                    {
                        item.Cells[current.Index].Value = ((DateTime) t.GetValue(stf, null)).ToShortDateString();
                    }
                    else if (t.PropertyType == typeof(Staff.EnumGender))
                    {
                        switch ((Staff.EnumGender) Convert.ToInt32(t.GetValue(stf, null)))
                        {
                            case Staff.EnumGender.Male:
                                item.Cells[current.Index].Value = "ذكر";
                                break;

                            case Staff.EnumGender.Female:
                                item.Cells[current.Index].Value = "انثي";
                                break;
                        }
                    }
                    else if (t.PropertyType == typeof(Staff.EnumRelegion))
                    {
                        switch ((Staff.EnumRelegion) Convert.ToInt32(t.GetValue(stf, null)))
                        {
                            case Staff.EnumRelegion.Muslim:
                                item.Cells[current.Index].Value = "مسلم";
                                break;

                            case Staff.EnumRelegion.Christian:
                                item.Cells[current.Index].Value = "مسيحي";
                                break;
                        }
                    }
                    else if (t.PropertyType == typeof(Staff.EnumMartialStatus))
                    {
                        switch ((Staff.EnumMartialStatus) Convert.ToInt32(t.GetValue(stf, null)))
                        {
                            case Staff.EnumMartialStatus.Single:
                                item.Cells[current.Index].Value = "غير متزوج";
                                break;

                            case Staff.EnumMartialStatus.Married:
                                item.Cells[current.Index].Value = "متزوج";
                                break;

                            case Staff.EnumMartialStatus.Widowed:
                                item.Cells[current.Index].Value = "ارملة";
                                break;

                            case Staff.EnumMartialStatus.Divorced:
                                item.Cells[current.Index].Value = "مطلقة";
                                break;
                        }
                    }
                }
            }

            dataGrid.Rows.AddRange(list.ToArray());
            dataGrid.ResumeLayout();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            foreach (PropertyInfo info in typeof(Staff).GetProperties())
            {
                if (info.GetCustomAttributes(false).Length != 0)
                {
                    object argument = info.GetCustomAttributes(false).ElementAtOrDefault(0);
                    string headerText = Convert.ToString(argument);
                    int num2 = dataGrid.Columns.Add(info.Name, headerText);
                    dataGrid.Columns[num2].Tag = info.PropertyType;
                    dataGrid.Columns[num2].DataPropertyName = info.Name;
                }
            }
            LoadStaffListIntoList(Main.Db.Table<Staff>());
        }

        private void تحديثToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadStaffListIntoList(Main.Db.Table<Staff>());
        }

        private void تصنيفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGrid.SuspendLayout();
            if (_headerSelected != -1)
            {
                if ((Type)dataGrid.Columns[_headerSelected].Tag == typeof(string))
                {
                    StringFilterForm form = new StringFilterForm
                    {
                        Text = dataGrid.Columns[_headerSelected].HeaderText
                    };
                    form.ShowDialog();

                    foreach (DataGridViewRow current in dataGrid.Rows)
                    {
                        if (form.isStartOnly.Checked)
                        {
                            if (!current.Cells[_headerSelected].Value.ToString().StartsWith(form.textBox.Text))
                            {
                                current.Visible = false;
                            }
                        }
                        else if (!current.Cells[_headerSelected].Value.ToString().Contains(form.textBox.Text))
                        {
                            current.Visible = false;
                        }
                    }
                }
                else if ((Type)dataGrid.Columns[_headerSelected].Tag == typeof(DateTime))
                {
                    DateFilterForm form2 = new DateFilterForm();
                    form2.ShowDialog();
                    form2.Text = dataGrid.Columns[_headerSelected].HeaderText;

                    foreach (DataGridViewRow row2 in dataGrid.Rows)
                    {
                        if ((DateTime.Compare(DateTime.Parse(Convert.ToString(row2.Cells[_headerSelected].Value)), form2.startDate.Value) < 0) | (DateTime.Compare(DateTime.Parse(Convert.ToString(row2.Cells[_headerSelected].Value)), form2.endDate.Value) > 0))
                        {
                            row2.Visible = false;
                        }
                    }
                }
                else if ((Type)dataGrid.Columns[_headerSelected].Tag == typeof(int) && ((dataGrid.Columns[_headerSelected].Name == "CurrentDepartment") || (dataGrid.Columns[_headerSelected].Name == "CurrentJob")))
                {
                    ListFilterForm form3 = new ListFilterForm();
                    if (dataGrid.Columns[_headerSelected].Name == "CurrentJob")
                    {
                        foreach (Job job in Main.Db.Table<Job>())
                        {
                            form3.listBox.Items.Add(job.JobName);
                        }
                    }
                    else if (dataGrid.Columns[_headerSelected].Name == "CurrentDepartment")
                    {
                        foreach (Department department in Main.Db.Table<Department>())
                        {
                            form3.listBox.Items.Add(department.DepartmentName);
                        }
                    }
                    form3.listBox.SelectedIndex = 0;
                    form3.ShowDialog();

                    foreach (DataGridViewRow row3 in dataGrid.Rows)
                    {
                        if (row3.Cells[_headerSelected].Value != form3.listBox.SelectedItem)
                        {
                            row3.Visible = false;
                        }
                    }
                }
                else if ((Type)dataGrid.Columns[_headerSelected].Tag == typeof(Staff.EnumGender) || (Type)dataGrid.Columns[_headerSelected].Tag == typeof(Staff.EnumMartialStatus) || (Type)dataGrid.Columns[_headerSelected].Tag == typeof(Staff.EnumRelegion))
                {
                    ListFilterForm form4 = new ListFilterForm();
                    if ((Type)dataGrid.Columns[_headerSelected].Tag == typeof(Staff.EnumGender))
                    {
                        string[] items = { "ذكر", "انثي" };
                        form4.listBox.Items.AddRange(items);
                    }
                    if ((Type)dataGrid.Columns[_headerSelected].Tag == typeof(Staff.EnumMartialStatus))
                    {
                        string[] textArray2 = { "غير متزوج", "متزوج", "ارملة", "مطلقة" };
                        form4.listBox.Items.AddRange(textArray2);
                    }
                    if ((Type)dataGrid.Columns[_headerSelected].Tag == typeof(Staff.EnumRelegion))
                    {
                        string[] textArray3 = { "مسلم", "مسيحي" };
                        form4.listBox.Items.AddRange(textArray3);
                    }
                    form4.listBox.SelectedIndex = 0;
                    form4.ShowDialog();

                    foreach (DataGridViewRow row4 in dataGrid.Rows)
                    {
                        if (row4.Cells[_headerSelected].Value != form4.listBox.SelectedItem)
                        {
                            row4.Visible = false;
                        }
                    }
                }
                _headerSelected = -1;
                dataGrid.ResumeLayout();
            }
        }

        private void تعديلالموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = Convert.ToString(dataGrid.SelectedRows[0].Cells[0].Value);
            Staff staff = Main.Db.Table<Staff>().Single<Staff>(x => x.Id == int.Parse(id));
            new ManageStaff { 
                SelStaff = staff,
                IsEdit = true,
                MdiParent = Program.mainForm,
                PrintButton = { Visible = true },
                Text = "تعديل الموظف"
            }.Show();
        }

        private void مسحالموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = Convert.ToString(dataGrid.SelectedRows[0].Cells[0].Value);
            Staff objectToDelete = Main.Db.Table<Staff>().Single<Staff>(x => x.Id == int.Parse(id));
            Main.Db.Delete(objectToDelete);
            dataGrid.Rows.RemoveAt(dataGrid.SelectedRows[0].Index);
        }
    }
}


using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace staffmanagement
{
    public partial class ManageStaff : Form
    {
        public bool IsEdit;
        public Staff SelStaff;

        public ManageStaff()
        {
            IsEdit = false;
            SelStaff = null;
            InitializeComponent();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            foreach (Department department in Main.Db.Table<Department>())
            {
                CurrentDepartment.Items.Add(department.DepartmentName);
            }
            foreach (Job job in Main.Db.Table<Job>())
            {
                CurrentJob.Items.Add(job.JobName);
            }
            ShowInSelStaff();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TabPage1.Enabled = true;
            TabPage2.Enabled = true;
            TabPage3.Enabled = true;
            TabPage4.Enabled = true;
            saveButton.Enabled = true;
            editButton.Visible = false;
        }

        /*public IEnumerable<Control> GetAll(Control control, System.Type type)
        {
            _Closure$__286-0 e$__- = new _Closure$__286-0 {
                $VB$Me = this,
                $VB$Local_type = type
            };
            IEnumerable<Control> second = control.Controls.Cast<Control>();
            return second.SelectMany<Control, Control>(new Func<Control, IEnumerable<Control>>(e$__-._Lambda$__0)).Concat<Control>(second).Where<Control>(new Func<Control, bool>(e$__-._Lambda$__1));
        }*/

        private void Identity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Identity_Leave(this, EventArgs.Empty);
            }
        }

        private void Identity_Leave(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                Staff staff = Main.Db.Table<Staff>().SingleOrDefault(x => x.Identity == Identity.Text);
                if (staff != null)
                {
                    SelStaff = staff;
                    ShowInSelStaff();
                    saveButton.Enabled = true;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            if (IsEdit & (SelStaff != null))
            {
                staff = Main.Db.Table<Staff>().SingleOrDefault(x => x.Id == SelStaff.Id);
            }
            foreach (PropertyInfo info in staff.GetType().GetProperties())
            {
                if (info.Name != "Id")
                {
                    if (info.PropertyType != typeof(string))
                    {
                        if (info.PropertyType != typeof(DateTime))
                        {
                            if (!(((info.PropertyType == typeof(Staff.EnumGender)) | (info.PropertyType == typeof(Staff.EnumRelegion))) | (info.PropertyType == typeof(Staff.EnumMartialStatus))))
                            {
                                if (!((info.PropertyType == typeof(int)) & (info.Name == "CurrentDepartment")))
                                {
                                    if (!((info.PropertyType == typeof(int)) & (info.Name == "CurrentJob")))
                                    {
                                        throw new Exception("Unknown type!");
                                    }
                                    var jobname = CurrentJob.SelectedItem.ToString();
                                    Job job = Main.Db.Table<Job>().Single(x => x.JobName == jobname);
                                    info.SetValue(staff, job.Id, null);
                                }
                                else
                                {
                                    var depname = CurrentDepartment.SelectedItem.ToString();
                                    Department department = Main.Db.Table<Department>().Single(x => x.DepartmentName == depname);
                                    info.SetValue(staff, department.Id, null);
                                }
                            }
                            else
                            {
                                info.SetValue(staff, ((ComboBox) Controls.Find(info.Name, true)[0]).SelectedIndex, null);
                            }
                        }
                        else
                        {
                            info.SetValue(staff, ((DateTimePicker) Controls.Find(info.Name, true)[0]).Value, null);
                        }
                    }
                    else
                    {
                        info.SetValue(staff, ((TextBox) Controls.Find(info.Name, true)[0]).Text, null);
                    }
                }
            }
            if (!IsEdit)
            {
                Main.Db.Insert(staff);
            }
            else
            {
                Main.Db.Update(staff);
            }
            MessageBox.Show("تم الحفظ");
        }

        private void ShowInSelStaff()
        {
            if (SelStaff != null)
            {
                foreach (PropertyInfo info in typeof(Staff).GetProperties())
                {
                    if (info.Name != "Id")
                    {
                        if (info.PropertyType != typeof(string))
                        {
                            if (info.PropertyType != typeof(DateTime))
                            {
                                if (!(((info.PropertyType == typeof(Staff.EnumGender)) | (info.PropertyType == typeof(Staff.EnumRelegion))) | (info.PropertyType == typeof(Staff.EnumMartialStatus))))
                                {
                                    if (!((info.PropertyType == typeof(int)) & (info.Name == "CurrentDepartment")))
                                    {
                                        if (!((info.PropertyType == typeof(int)) & (info.Name == "CurrentJob")))
                                        {
                                            throw new Exception("Unknown type!");
                                        }
                                        CurrentJob.SelectedIndex = ((int) info.GetValue(SelStaff, null)) - 1;
                                    }
                                    else
                                    {
                                        CurrentDepartment.SelectedIndex = ((int) info.GetValue(SelStaff, null)) - 1;
                                    }
                                }
                                else
                                {
                                    ((ComboBox) Controls.Find(info.Name, true)[0]).SelectedIndex = Convert.ToInt32(info.GetValue(SelStaff, null));
                                }
                            }
                            else
                            {
                                ((DateTimePicker) Controls.Find(info.Name, true)[0]).Value = Convert.ToDateTime(info.GetValue(SelStaff, null));
                            }
                        }
                        else
                        {
                            ((TextBox) Controls.Find(info.Name, true)[0]).Text = Convert.ToString(info.GetValue(SelStaff, null));
                        }
                    }
                }
            }
        }

        private void TeacherCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TeacherCode_Leave(this, EventArgs.Empty);
            }
        }

        private void TeacherCode_Leave(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                Staff staff = Main.Db.Table<Staff>().SingleOrDefault(x => x.TeacherCode == TeacherCode.Text);
                if (staff != null)
                {
                    SelStaff = staff;
                    ShowInSelStaff();
                    saveButton.Enabled = true;
                }
            }
        }
    }
}


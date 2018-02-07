using System;
using System.Windows.Forms;
using SQLite;

namespace staffmanagement
{
    public partial class Main : Form
    {
        public static readonly SQLiteConnection Db;

        public Main()
        {
            Load += Main_Load;
            FormClosing += Main_FormClosing;
            InitializeComponent();
        }

        static Main()
        {
            Db = new SQLiteConnection("data.db", true);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Db.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Db.CreateTable<Department>(CreateFlags.None);
            Db.CreateTable<Job>(CreateFlags.None);
            Db.CreateTable<Staff>(CreateFlags.None);
        }

        private void اداToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageDepartments { MdiParent = this }.Show();
        }

        private void ادارةالوظائفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageJobs { MdiParent = this }.Show();
        }

        private void بحثToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ShowAll { MdiParent = this }.Show();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageStaff { MdiParent = this }.Show();
        }

        private void تعديلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ManageStaff { 
                MdiParent = this,
                IsEdit = true,
                saveButton = { Enabled = false },
                Text = "تعديل الموظف"
            }.Show();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


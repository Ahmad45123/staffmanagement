using System;
using System.Windows.Forms;
using SQLite;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace staffmanagement
{
    public partial class Main : Form
    {
        public static readonly SQLiteConnection Db;

        public Main()
        {
            Load += Main_Load;
            FormClosing += Main_FormClosing;

            if(Properties.Settings.Default.password != "")
            {
                var enteredText = Interaction.InputBox("فضلا ادخل كلمة المرور");
                if(CreateSHAHash(enteredText) != Properties.Settings.Default.password)
                    Close();
            }

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
            Db.CreateTable<Department>();
            Db.CreateTable<Job>();
            Db.CreateTable<Staff>();
        }

        public static string CreateSHAHash(string Phrase)
        {
            SHA512Managed HashTool = new SHA512Managed();
            Byte[] PhraseAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(Phrase));
            Byte[] EncryptedBytes = HashTool.ComputeHash(PhraseAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);
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

        private void تغييركلمةالمرورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newPass = Interaction.InputBox("فضلا ادخل كلمة مرور جديدة");
            Properties.Settings.Default.password = CreateSHAHash(newPass);
            Properties.Settings.Default.Save();
        }
    }
}
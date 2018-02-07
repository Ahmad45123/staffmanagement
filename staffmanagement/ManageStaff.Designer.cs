using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace staffmanagement
{
    public partial class ManageStaff : Form
    {
        private TextBox Address;
        private TextBox AddressGovernerate;
        private TextBox BirthGovernerate;   
        private ComboBox CurrentDepartment;
        
        private ComboBox CurrentJob;
        
        private TextBox CurrentJobDecisionNo;
        
        private DateTimePicker CurrentJobDecisionNoDate;
        
        private DateTimePicker DateOfAppointment;
        
        private DateTimePicker DateOfBirth;
        
        private DateTimePicker DateOfQualification;
        
        private DateTimePicker DateOfStartWork;

        public Button editButton;
        
        private TextBox FinancialClass;
        
        private TextBox FinancialClassDecisionNo;
        
        private DateTimePicker FinancialClassEndDate;
        
        private DateTimePicker FinancialClassStartDate;
        
        private ComboBox Gender;
        
        private TextBox Identity;
        
        private Label Label1;
        
        private Label Label10;
        
        private Label Label11;
        
        private Label Label12;
        
        private Label Label13;
        
        private Label Label14;
        
        private Label Label15;
        
        private Label Label16;
        
        private Label Label17;
        
        private Label Label18;
        
        private Label Label19;
        
        private Label Label2;
        
        private Label Label20;
        
        private Label Label21;
        
        private Label Label22;
        
        private Label Label23;
        
        private Label Label24;
        
        private Label Label25;
        
        private Label Label26;
        
        private Label Label27;
        
        private Label Label28;
        
        private Label Label29;
        
        private Label Label3;
        
        private Label Label30;
        
        private Label Label31;
        
        private Label Label4;
        
        private Label Label5;
        
        private Label Label6;
        
        private Label Label7;
        
        private Label Label8;
        
        private Label Label9;
        
        private TextBox MarkOfQualification;
        
        private ComboBox MartialStatus;
        
        private TextBox Nationality;
        
        private TextBox PhoneNumber;
        
        private TextBox PlaceOfQualification;
        
        public Button PrintButton;
        
        private TextBox Qualification;
        
        private ComboBox Relegion;

        public Button saveButton;
        
        private TextBox SpecificGroup;
        
        private TextBox StaffName;
        
        private TextBox StatusOfJob;
        
        private TabControl TabControl1;
        
        public TabPage TabPage1;

        public TabPage TabPage2;

        public TabPage TabPage3;

        public TabPage TabPage4;
        
        private TextBox TeacherCode;
        
        private TextBox TeachSubject;
        
        private TextBox TypeOfAppointment;
        
        private TextBox TypeOfQualification;
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
            this.FinancialClassEndDate = new System.Windows.Forms.DateTimePicker();
            this.Label25 = new System.Windows.Forms.Label();
            this.FinancialClassStartDate = new System.Windows.Forms.DateTimePicker();
            this.Label24 = new System.Windows.Forms.Label();
            this.FinancialClassDecisionNo = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.FinancialClass = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.CurrentJobDecisionNoDate = new System.Windows.Forms.DateTimePicker();
            this.Label21 = new System.Windows.Forms.Label();
            this.CurrentJobDecisionNo = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.SpecificGroup = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.TypeOfAppointment = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.DateOfStartWork = new System.Windows.Forms.DateTimePicker();
            this.Label17 = new System.Windows.Forms.Label();
            this.CurrentJob = new System.Windows.Forms.ComboBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.CurrentDepartment = new System.Windows.Forms.ComboBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.StatusOfJob = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.DateOfAppointment = new System.Windows.Forms.DateTimePicker();
            this.Label13 = new System.Windows.Forms.Label();
            this.PlaceOfQualification = new System.Windows.Forms.TextBox();
            this.Label30 = new System.Windows.Forms.Label();
            this.MarkOfQualification = new System.Windows.Forms.TextBox();
            this.Label29 = new System.Windows.Forms.Label();
            this.DateOfQualification = new System.Windows.Forms.DateTimePicker();
            this.Label28 = new System.Windows.Forms.Label();
            this.Qualification = new System.Windows.Forms.TextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.TypeOfQualification = new System.Windows.Forms.TextBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.TeachSubject = new System.Windows.Forms.TextBox();
            this.Label31 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.AddressGovernerate = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.MartialStatus = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Nationality = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Relegion = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.BirthGovernerate = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.Identity = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TeacherCode = new System.Windows.Forms.TextBox();
            this.StaffName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.PrintButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // FinancialClassEndDate
            // 
            this.FinancialClassEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FinancialClassEndDate.Location = new System.Drawing.Point(399, 158);
            this.FinancialClassEndDate.Name = "FinancialClassEndDate";
            this.FinancialClassEndDate.Size = new System.Drawing.Size(103, 20);
            this.FinancialClassEndDate.TabIndex = 47;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(505, 161);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(133, 13);
            this.Label25.TabIndex = 46;
            this.Label25.Text = "تاريخ سريان الدرجة الحالية :";
            // 
            // FinancialClassStartDate
            // 
            this.FinancialClassStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FinancialClassStartDate.Location = new System.Drawing.Point(116, 130);
            this.FinancialClassStartDate.Name = "FinancialClassStartDate";
            this.FinancialClassStartDate.Size = new System.Drawing.Size(103, 20);
            this.FinancialClassStartDate.TabIndex = 45;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(225, 133);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(91, 13);
            this.Label24.TabIndex = 44;
            this.Label24.Text = "تاريخ قرار الدرجة :";
            // 
            // FinancialClassDecisionNo
            // 
            this.FinancialClassDecisionNo.Location = new System.Drawing.Point(331, 130);
            this.FinancialClassDecisionNo.Name = "FinancialClassDecisionNo";
            this.FinancialClassDecisionNo.Size = new System.Drawing.Size(180, 20);
            this.FinancialClassDecisionNo.TabIndex = 43;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(517, 133);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(114, 13);
            this.Label23.TabIndex = 42;
            this.Label23.Text = "رقم قرار الدرجة الحالية :";
            // 
            // FinancialClass
            // 
            this.FinancialClass.Location = new System.Drawing.Point(167, 100);
            this.FinancialClass.Name = "FinancialClass";
            this.FinancialClass.Size = new System.Drawing.Size(112, 20);
            this.FinancialClass.TabIndex = 41;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(285, 103);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(103, 13);
            this.Label22.TabIndex = 40;
            this.Label22.Text = "الدرحة المالية الحالية :";
            // 
            // CurrentJobDecisionNoDate
            // 
            this.CurrentJobDecisionNoDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CurrentJobDecisionNoDate.Location = new System.Drawing.Point(399, 100);
            this.CurrentJobDecisionNoDate.Name = "CurrentJobDecisionNoDate";
            this.CurrentJobDecisionNoDate.Size = new System.Drawing.Size(103, 20);
            this.CurrentJobDecisionNoDate.TabIndex = 39;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(509, 103);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(128, 13);
            this.Label21.TabIndex = 38;
            this.Label21.Text = "تاريخ قرار الوظيفة الحالية :";
            // 
            // CurrentJobDecisionNo
            // 
            this.CurrentJobDecisionNo.Location = new System.Drawing.Point(12, 71);
            this.CurrentJobDecisionNo.Name = "CurrentJobDecisionNo";
            this.CurrentJobDecisionNo.Size = new System.Drawing.Size(180, 20);
            this.CurrentJobDecisionNo.TabIndex = 37;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(198, 74);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(119, 13);
            this.Label20.TabIndex = 36;
            this.Label20.Text = "رقم قرار الوظيفة الحالية :";
            // 
            // SpecificGroup
            // 
            this.SpecificGroup.Location = new System.Drawing.Point(330, 71);
            this.SpecificGroup.Name = "SpecificGroup";
            this.SpecificGroup.Size = new System.Drawing.Size(211, 20);
            this.SpecificGroup.TabIndex = 35;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(547, 74);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(89, 13);
            this.Label19.TabIndex = 34;
            this.Label19.Text = "المجموعة النوعية :";
            // 
            // TypeOfAppointment
            // 
            this.TypeOfAppointment.Location = new System.Drawing.Point(12, 42);
            this.TypeOfAppointment.Name = "TypeOfAppointment";
            this.TypeOfAppointment.Size = new System.Drawing.Size(116, 20);
            this.TypeOfAppointment.TabIndex = 33;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(134, 45);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(64, 13);
            this.Label18.TabIndex = 32;
            this.Label18.Text = "نوع التعيين :";
            // 
            // DateOfStartWork
            // 
            this.DateOfStartWork.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfStartWork.Location = new System.Drawing.Point(204, 42);
            this.DateOfStartWork.Name = "DateOfStartWork";
            this.DateOfStartWork.Size = new System.Drawing.Size(103, 20);
            this.DateOfStartWork.TabIndex = 31;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(313, 45);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(96, 13);
            this.Label17.TabIndex = 30;
            this.Label17.Text = "تاريخ استلام العمل :";
            // 
            // CurrentJob
            // 
            this.CurrentJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentJob.FormattingEnabled = true;
            this.CurrentJob.Location = new System.Drawing.Point(198, 12);
            this.CurrentJob.Name = "CurrentJob";
            this.CurrentJob.Size = new System.Drawing.Size(182, 21);
            this.CurrentJob.TabIndex = 29;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(386, 15);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(46, 13);
            this.Label16.TabIndex = 28;
            this.Label16.Text = "الوظيفة :";
            // 
            // CurrentDepartment
            // 
            this.CurrentDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentDepartment.FormattingEnabled = true;
            this.CurrentDepartment.Location = new System.Drawing.Point(440, 12);
            this.CurrentDepartment.Name = "CurrentDepartment";
            this.CurrentDepartment.Size = new System.Drawing.Size(157, 21);
            this.CurrentDepartment.TabIndex = 27;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(603, 15);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(38, 13);
            this.Label15.TabIndex = 26;
            this.Label15.Text = "القسم :";
            // 
            // StatusOfJob
            // 
            this.StatusOfJob.Location = new System.Drawing.Point(417, 42);
            this.StatusOfJob.Name = "StatusOfJob";
            this.StatusOfJob.Size = new System.Drawing.Size(128, 20);
            this.StatusOfJob.TabIndex = 25;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(551, 45);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(87, 13);
            this.Label14.TabIndex = 24;
            this.Label14.Text = "الموقف من العمل :";
            // 
            // DateOfAppointment
            // 
            this.DateOfAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfAppointment.Location = new System.Drawing.Point(12, 12);
            this.DateOfAppointment.Name = "DateOfAppointment";
            this.DateOfAppointment.Size = new System.Drawing.Size(103, 20);
            this.DateOfAppointment.TabIndex = 9;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(121, 15);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(72, 13);
            this.Label13.TabIndex = 8;
            this.Label13.Text = "تاريخ التعيين :";
            // 
            // PlaceOfQualification
            // 
            this.PlaceOfQualification.Location = new System.Drawing.Point(17, 46);
            this.PlaceOfQualification.Name = "PlaceOfQualification";
            this.PlaceOfQualification.Size = new System.Drawing.Size(185, 20);
            this.PlaceOfQualification.TabIndex = 51;
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Location = new System.Drawing.Point(208, 49);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(126, 13);
            this.Label30.TabIndex = 50;
            this.Label30.Text = "جهة الحصول علي المؤهل :";
            // 
            // MarkOfQualification
            // 
            this.MarkOfQualification.Location = new System.Drawing.Point(345, 46);
            this.MarkOfQualification.Name = "MarkOfQualification";
            this.MarkOfQualification.Size = new System.Drawing.Size(230, 20);
            this.MarkOfQualification.TabIndex = 49;
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(577, 49);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(70, 13);
            this.Label29.TabIndex = 48;
            this.Label29.Text = "تقدير المؤهل :";
            // 
            // DateOfQualification
            // 
            this.DateOfQualification.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfQualification.Location = new System.Drawing.Point(15, 16);
            this.DateOfQualification.Name = "DateOfQualification";
            this.DateOfQualification.Size = new System.Drawing.Size(103, 20);
            this.DateOfQualification.TabIndex = 47;
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(121, 19);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(133, 13);
            this.Label28.TabIndex = 46;
            this.Label28.Text = "تاريخ الحصول علي المؤهل :";
            // 
            // Qualification
            // 
            this.Qualification.Location = new System.Drawing.Point(267, 17);
            this.Qualification.Name = "Qualification";
            this.Qualification.Size = new System.Drawing.Size(121, 20);
            this.Qualification.TabIndex = 29;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(394, 20);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(44, 13);
            this.Label27.TabIndex = 28;
            this.Label27.Text = "المؤهل :";
            // 
            // TypeOfQualification
            // 
            this.TypeOfQualification.Location = new System.Drawing.Point(446, 17);
            this.TypeOfQualification.Name = "TypeOfQualification";
            this.TypeOfQualification.Size = new System.Drawing.Size(128, 20);
            this.TypeOfQualification.TabIndex = 27;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(580, 20);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(64, 13);
            this.Label26.TabIndex = 26;
            this.Label26.Text = "نوع المؤهل :";
            // 
            // TeachSubject
            // 
            this.TeachSubject.Location = new System.Drawing.Point(340, 16);
            this.TeachSubject.Name = "TeachSubject";
            this.TeachSubject.Size = new System.Drawing.Size(230, 20);
            this.TeachSubject.TabIndex = 51;
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(572, 19);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(69, 13);
            this.Label31.TabIndex = 50;
            this.Label31.Text = "مادة التدريس :";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveButton.Location = new System.Drawing.Point(518, 228);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(153, 34);
            this.saveButton.TabIndex = 53;
            this.saveButton.Text = "حفظ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Location = new System.Drawing.Point(12, 8);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(663, 214);
            this.TabControl1.TabIndex = 54;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.PhoneNumber);
            this.TabPage1.Controls.Add(this.Label12);
            this.TabPage1.Controls.Add(this.Address);
            this.TabPage1.Controls.Add(this.Label11);
            this.TabPage1.Controls.Add(this.AddressGovernerate);
            this.TabPage1.Controls.Add(this.Label10);
            this.TabPage1.Controls.Add(this.MartialStatus);
            this.TabPage1.Controls.Add(this.Label9);
            this.TabPage1.Controls.Add(this.Nationality);
            this.TabPage1.Controls.Add(this.Label8);
            this.TabPage1.Controls.Add(this.Relegion);
            this.TabPage1.Controls.Add(this.Label7);
            this.TabPage1.Controls.Add(this.Gender);
            this.TabPage1.Controls.Add(this.Label6);
            this.TabPage1.Controls.Add(this.BirthGovernerate);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.DateOfBirth);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.Identity);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.TeacherCode);
            this.TabPage1.Controls.Add(this.StaffName);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(655, 188);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "البيانات الاساسية";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(444, 137);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(128, 20);
            this.PhoneNumber.TabIndex = 47;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(578, 140);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(67, 13);
            this.Label12.TabIndex = 46;
            this.Label12.Text = "رقم التليفون :";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(14, 108);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(373, 20);
            this.Address.TabIndex = 45;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(392, 111);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(45, 13);
            this.Label11.TabIndex = 44;
            this.Label11.Text = "العنوان :";
            // 
            // AddressGovernerate
            // 
            this.AddressGovernerate.Location = new System.Drawing.Point(444, 108);
            this.AddressGovernerate.Name = "AddressGovernerate";
            this.AddressGovernerate.Size = new System.Drawing.Size(113, 20);
            this.AddressGovernerate.TabIndex = 43;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(563, 111);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(82, 13);
            this.Label10.TabIndex = 42;
            this.Label10.Text = "محافظة العنوان :";
            // 
            // MartialStatus
            // 
            this.MartialStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MartialStatus.FormattingEnabled = true;
            this.MartialStatus.Items.AddRange(new object[] {
            "غير متزوج/ة",
            "متزوج/ة",
            "ارملة",
            "مطلقة"});
            this.MartialStatus.Location = new System.Drawing.Point(14, 78);
            this.MartialStatus.Name = "MartialStatus";
            this.MartialStatus.Size = new System.Drawing.Size(105, 21);
            this.MartialStatus.TabIndex = 41;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(125, 81);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(86, 13);
            this.Label9.TabIndex = 40;
            this.Label9.Text = "الحالة الاجتماعية :";
            // 
            // Nationality
            // 
            this.Nationality.Location = new System.Drawing.Point(222, 78);
            this.Nationality.Name = "Nationality";
            this.Nationality.Size = new System.Drawing.Size(112, 20);
            this.Nationality.TabIndex = 39;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(334, 81);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(51, 13);
            this.Label8.TabIndex = 38;
            this.Label8.Text = "الجنسية : ";
            // 
            // Relegion
            // 
            this.Relegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Relegion.FormattingEnabled = true;
            this.Relegion.Items.AddRange(new object[] {
            "مسلم",
            "مسيحي"});
            this.Relegion.Location = new System.Drawing.Point(393, 78);
            this.Relegion.Name = "Relegion";
            this.Relegion.Size = new System.Drawing.Size(91, 21);
            this.Relegion.TabIndex = 37;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(490, 81);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(41, 13);
            this.Label7.TabIndex = 36;
            this.Label7.Text = "الديانة :";
            // 
            // Gender
            // 
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "ذكر",
            "انثي"});
            this.Gender.Location = new System.Drawing.Point(534, 78);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(66, 21);
            this.Gender.TabIndex = 35;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(606, 80);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(36, 13);
            this.Label6.TabIndex = 34;
            this.Label6.Text = "النوع :";
            // 
            // BirthGovernerate
            // 
            this.BirthGovernerate.Location = new System.Drawing.Point(14, 48);
            this.BirthGovernerate.Name = "BirthGovernerate";
            this.BirthGovernerate.Size = new System.Drawing.Size(129, 20);
            this.BirthGovernerate.TabIndex = 33;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(149, 51);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(77, 13);
            this.Label5.TabIndex = 32;
            this.Label5.Text = "محافظة الميلاد :";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirth.Location = new System.Drawing.Point(235, 48);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(103, 20);
            this.DateOfBirth.TabIndex = 31;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(344, 51);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(68, 13);
            this.Label4.TabIndex = 30;
            this.Label4.Text = "تاريخ الميلاد :";
            // 
            // Identity
            // 
            this.Identity.Location = new System.Drawing.Point(421, 48);
            this.Identity.Name = "Identity";
            this.Identity.Size = new System.Drawing.Size(148, 20);
            this.Identity.TabIndex = 29;
            this.Identity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Identity_KeyDown);
            this.Identity.Leave += new System.EventHandler(this.Identity_Leave);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(575, 51);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(70, 13);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "الرقم القومي :";
            // 
            // TeacherCode
            // 
            this.TeacherCode.Location = new System.Drawing.Point(14, 16);
            this.TeacherCode.Name = "TeacherCode";
            this.TeacherCode.Size = new System.Drawing.Size(187, 20);
            this.TeacherCode.TabIndex = 27;
            this.TeacherCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeacherCode_KeyDown);
            this.TeacherCode.Leave += new System.EventHandler(this.TeacherCode_Leave);
            // 
            // StaffName
            // 
            this.StaffName.Location = new System.Drawing.Point(274, 16);
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(326, 20);
            this.StaffName.TabIndex = 26;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(207, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(59, 13);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "كود المعلم :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(606, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(36, 13);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "الاسم :";
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.FinancialClassEndDate);
            this.TabPage2.Controls.Add(this.Label15);
            this.TabPage2.Controls.Add(this.Label25);
            this.TabPage2.Controls.Add(this.Label13);
            this.TabPage2.Controls.Add(this.FinancialClassStartDate);
            this.TabPage2.Controls.Add(this.DateOfAppointment);
            this.TabPage2.Controls.Add(this.Label24);
            this.TabPage2.Controls.Add(this.Label14);
            this.TabPage2.Controls.Add(this.FinancialClassDecisionNo);
            this.TabPage2.Controls.Add(this.StatusOfJob);
            this.TabPage2.Controls.Add(this.Label23);
            this.TabPage2.Controls.Add(this.CurrentDepartment);
            this.TabPage2.Controls.Add(this.FinancialClass);
            this.TabPage2.Controls.Add(this.Label16);
            this.TabPage2.Controls.Add(this.Label22);
            this.TabPage2.Controls.Add(this.CurrentJob);
            this.TabPage2.Controls.Add(this.CurrentJobDecisionNoDate);
            this.TabPage2.Controls.Add(this.Label17);
            this.TabPage2.Controls.Add(this.Label21);
            this.TabPage2.Controls.Add(this.DateOfStartWork);
            this.TabPage2.Controls.Add(this.CurrentJobDecisionNo);
            this.TabPage2.Controls.Add(this.Label18);
            this.TabPage2.Controls.Add(this.Label20);
            this.TabPage2.Controls.Add(this.TypeOfAppointment);
            this.TabPage2.Controls.Add(this.SpecificGroup);
            this.TabPage2.Controls.Add(this.Label19);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(655, 188);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "البيانات الوظيفية";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.PlaceOfQualification);
            this.TabPage3.Controls.Add(this.TypeOfQualification);
            this.TabPage3.Controls.Add(this.Label30);
            this.TabPage3.Controls.Add(this.Label26);
            this.TabPage3.Controls.Add(this.MarkOfQualification);
            this.TabPage3.Controls.Add(this.Label27);
            this.TabPage3.Controls.Add(this.Label29);
            this.TabPage3.Controls.Add(this.Qualification);
            this.TabPage3.Controls.Add(this.DateOfQualification);
            this.TabPage3.Controls.Add(this.Label28);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(655, 188);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "بيانات اخر مؤهل";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.TeachSubject);
            this.TabPage4.Controls.Add(this.Label31);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(655, 188);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "خاص للمدرس";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(12, 224);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(137, 34);
            this.PrintButton.TabIndex = 55;
            this.PrintButton.Text = "طباعة";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Visible = false;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(391, 228);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(121, 34);
            this.editButton.TabIndex = 56;
            this.editButton.Text = "تعديل";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ManageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 267);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageStaff";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة موظف";
            this.Load += new System.EventHandler(this.AddStaff_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.ResumeLayout(false);

        }


    }
}

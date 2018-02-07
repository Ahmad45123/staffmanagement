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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(ManageStaff));
            this.FinancialClassEndDate = new DateTimePicker();
            this.Label25 = new Label();
            this.FinancialClassStartDate = new DateTimePicker();
            this.Label24 = new Label();
            this.FinancialClassDecisionNo = new TextBox();
            this.Label23 = new Label();
            this.FinancialClass = new TextBox();
            this.Label22 = new Label();
            this.CurrentJobDecisionNoDate = new DateTimePicker();
            this.Label21 = new Label();
            this.CurrentJobDecisionNo = new TextBox();
            this.Label20 = new Label();
            this.SpecificGroup = new TextBox();
            this.Label19 = new Label();
            this.TypeOfAppointment = new TextBox();
            this.Label18 = new Label();
            this.DateOfStartWork = new DateTimePicker();
            this.Label17 = new Label();
            this.CurrentJob = new ComboBox();
            this.Label16 = new Label();
            this.CurrentDepartment = new ComboBox();
            this.Label15 = new Label();
            this.StatusOfJob = new TextBox();
            this.Label14 = new Label();
            this.DateOfAppointment = new DateTimePicker();
            this.Label13 = new Label();
            this.PlaceOfQualification = new TextBox();
            this.Label30 = new Label();
            this.MarkOfQualification = new TextBox();
            this.Label29 = new Label();
            this.DateOfQualification = new DateTimePicker();
            this.Label28 = new Label();
            this.Qualification = new TextBox();
            this.Label27 = new Label();
            this.TypeOfQualification = new TextBox();
            this.Label26 = new Label();
            this.TeachSubject = new TextBox();
            this.Label31 = new Label();
            this.saveButton = new Button();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.PhoneNumber = new TextBox();
            this.Label12 = new Label();
            this.Address = new TextBox();
            this.Label11 = new Label();
            this.AddressGovernerate = new TextBox();
            this.Label10 = new Label();
            this.MartialStatus = new ComboBox();
            this.Label9 = new Label();
            this.Nationality = new TextBox();
            this.Label8 = new Label();
            this.Relegion = new ComboBox();
            this.Label7 = new Label();
            this.Gender = new ComboBox();
            this.Label6 = new Label();
            this.BirthGovernerate = new TextBox();
            this.Label5 = new Label();
            this.DateOfBirth = new DateTimePicker();
            this.Label4 = new Label();
            this.Identity = new TextBox();
            this.Label3 = new Label();
            this.TeacherCode = new TextBox();
            this.StaffName = new TextBox();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this.TabPage2 = new TabPage();
            this.TabPage3 = new TabPage();
            this.TabPage4 = new TabPage();
            this.PrintButton = new Button();
            this.editButton = new Button();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            base.SuspendLayout();
            this.FinancialClassEndDate.Format = DateTimePickerFormat.Short;
            this.FinancialClassEndDate.Location = new Point(0x18f, 0x9e);
            this.FinancialClassEndDate.Name = "FinancialClassEndDate";
            this.FinancialClassEndDate.Size = new Size(0x67, 20);
            this.FinancialClassEndDate.TabIndex = 0x2f;
            this.Label25.AutoSize = true;
            this.Label25.Location = new Point(0x1f9, 0xa1);
            this.Label25.Name = "Label25";
            this.Label25.Size = new Size(0x85, 13);
            this.Label25.TabIndex = 0x2e;
            this.Label25.Text = "تاريخ سريان الدرجة الحالية :";
            this.FinancialClassStartDate.Format = DateTimePickerFormat.Short;
            this.FinancialClassStartDate.Location = new Point(0x74, 130);
            this.FinancialClassStartDate.Name = "FinancialClassStartDate";
            this.FinancialClassStartDate.Size = new Size(0x67, 20);
            this.FinancialClassStartDate.TabIndex = 0x2d;
            this.Label24.AutoSize = true;
            this.Label24.Location = new Point(0xe1, 0x85);
            this.Label24.Name = "Label24";
            this.Label24.Size = new Size(0x5b, 13);
            this.Label24.TabIndex = 0x2c;
            this.Label24.Text = "تاريخ قرار الدرجة :";
            this.FinancialClassDecisionNo.Location = new Point(0x14b, 130);
            this.FinancialClassDecisionNo.Name = "FinancialClassDecisionNo";
            this.FinancialClassDecisionNo.Size = new Size(180, 20);
            this.FinancialClassDecisionNo.TabIndex = 0x2b;
            this.Label23.AutoSize = true;
            this.Label23.Location = new Point(0x205, 0x85);
            this.Label23.Name = "Label23";
            this.Label23.Size = new Size(0x72, 13);
            this.Label23.TabIndex = 0x2a;
            this.Label23.Text = "رقم قرار الدرجة الحالية :";
            this.FinancialClass.Location = new Point(0xa7, 100);
            this.FinancialClass.Name = "FinancialClass";
            this.FinancialClass.Size = new Size(0x70, 20);
            this.FinancialClass.TabIndex = 0x29;
            this.Label22.AutoSize = true;
            this.Label22.Location = new Point(0x11d, 0x67);
            this.Label22.Name = "Label22";
            this.Label22.Size = new Size(0x67, 13);
            this.Label22.TabIndex = 40;
            this.Label22.Text = "الدرحة المالية الحالية :";
            this.CurrentJobDecisionNoDate.Format = DateTimePickerFormat.Short;
            this.CurrentJobDecisionNoDate.Location = new Point(0x18f, 100);
            this.CurrentJobDecisionNoDate.Name = "CurrentJobDecisionNoDate";
            this.CurrentJobDecisionNoDate.Size = new Size(0x67, 20);
            this.CurrentJobDecisionNoDate.TabIndex = 0x27;
            this.Label21.AutoSize = true;
            this.Label21.Location = new Point(0x1fd, 0x67);
            this.Label21.Name = "Label21";
            this.Label21.Size = new Size(0x80, 13);
            this.Label21.TabIndex = 0x26;
            this.Label21.Text = "تاريخ قرار الوظيفة الحالية :";
            this.CurrentJobDecisionNo.Location = new Point(12, 0x47);
            this.CurrentJobDecisionNo.Name = "CurrentJobDecisionNo";
            this.CurrentJobDecisionNo.Size = new Size(180, 20);
            this.CurrentJobDecisionNo.TabIndex = 0x25;
            this.Label20.AutoSize = true;
            this.Label20.Location = new Point(0xc6, 0x4a);
            this.Label20.Name = "Label20";
            this.Label20.Size = new Size(0x77, 13);
            this.Label20.TabIndex = 0x24;
            this.Label20.Text = "رقم قرار الوظيفة الحالية :";
            this.SpecificGroup.Location = new Point(330, 0x47);
            this.SpecificGroup.Name = "SpecificGroup";
            this.SpecificGroup.Size = new Size(0xd3, 20);
            this.SpecificGroup.TabIndex = 0x23;
            this.Label19.AutoSize = true;
            this.Label19.Location = new Point(0x223, 0x4a);
            this.Label19.Name = "Label19";
            this.Label19.Size = new Size(0x59, 13);
            this.Label19.TabIndex = 0x22;
            this.Label19.Text = "المجموعة النوعية :";
            this.TypeOfAppointment.Location = new Point(12, 0x2a);
            this.TypeOfAppointment.Name = "TypeOfAppointment";
            this.TypeOfAppointment.Size = new Size(0x74, 20);
            this.TypeOfAppointment.TabIndex = 0x21;
            this.Label18.AutoSize = true;
            this.Label18.Location = new Point(0x86, 0x2d);
            this.Label18.Name = "Label18";
            this.Label18.Size = new Size(0x40, 13);
            this.Label18.TabIndex = 0x20;
            this.Label18.Text = "نوع التعيين :";
            this.DateOfStartWork.Format = DateTimePickerFormat.Short;
            this.DateOfStartWork.Location = new Point(0xcc, 0x2a);
            this.DateOfStartWork.Name = "DateOfStartWork";
            this.DateOfStartWork.Size = new Size(0x67, 20);
            this.DateOfStartWork.TabIndex = 0x1f;
            this.Label17.AutoSize = true;
            this.Label17.Location = new Point(0x139, 0x2d);
            this.Label17.Name = "Label17";
            this.Label17.Size = new Size(0x60, 13);
            this.Label17.TabIndex = 30;
            this.Label17.Text = "تاريخ استلام العمل :";
            this.CurrentJob.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CurrentJob.FormattingEnabled = true;
            this.CurrentJob.Location = new Point(0xc6, 12);
            this.CurrentJob.Name = "CurrentJob";
            this.CurrentJob.Size = new Size(0xb6, 0x15);
            this.CurrentJob.TabIndex = 0x1d;
            this.Label16.AutoSize = true;
            this.Label16.Location = new Point(0x182, 15);
            this.Label16.Name = "Label16";
            this.Label16.Size = new Size(0x2e, 13);
            this.Label16.TabIndex = 0x1c;
            this.Label16.Text = "الوظيفة :";
            this.CurrentDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CurrentDepartment.FormattingEnabled = true;
            this.CurrentDepartment.Location = new Point(440, 12);
            this.CurrentDepartment.Name = "CurrentDepartment";
            this.CurrentDepartment.Size = new Size(0x9d, 0x15);
            this.CurrentDepartment.TabIndex = 0x1b;
            this.Label15.AutoSize = true;
            this.Label15.Location = new Point(0x25b, 15);
            this.Label15.Name = "Label15";
            this.Label15.Size = new Size(0x26, 13);
            this.Label15.TabIndex = 0x1a;
            this.Label15.Text = "القسم :";
            this.StatusOfJob.Location = new Point(0x1a1, 0x2a);
            this.StatusOfJob.Name = "StatusOfJob";
            this.StatusOfJob.Size = new Size(0x80, 20);
            this.StatusOfJob.TabIndex = 0x19;
            this.Label14.AutoSize = true;
            this.Label14.Location = new Point(0x227, 0x2d);
            this.Label14.Name = "Label14";
            this.Label14.Size = new Size(0x57, 13);
            this.Label14.TabIndex = 0x18;
            this.Label14.Text = "الموقف من العمل :";
            this.DateOfAppointment.Format = DateTimePickerFormat.Short;
            this.DateOfAppointment.Location = new Point(12, 12);
            this.DateOfAppointment.Name = "DateOfAppointment";
            this.DateOfAppointment.Size = new Size(0x67, 20);
            this.DateOfAppointment.TabIndex = 9;
            this.Label13.AutoSize = true;
            this.Label13.Location = new Point(0x79, 15);
            this.Label13.Name = "Label13";
            this.Label13.Size = new Size(0x48, 13);
            this.Label13.TabIndex = 8;
            this.Label13.Text = "تاريخ التعيين :";
            this.PlaceOfQualification.Location = new Point(0x11, 0x2e);
            this.PlaceOfQualification.Name = "PlaceOfQualification";
            this.PlaceOfQualification.Size = new Size(0xb9, 20);
            this.PlaceOfQualification.TabIndex = 0x33;
            this.Label30.AutoSize = true;
            this.Label30.Location = new Point(0xd0, 0x31);
            this.Label30.Name = "Label30";
            this.Label30.Size = new Size(0x7e, 13);
            this.Label30.TabIndex = 50;
            this.Label30.Text = "جهة الحصول علي المؤهل :";
            this.MarkOfQualification.Location = new Point(0x159, 0x2e);
            this.MarkOfQualification.Name = "MarkOfQualification";
            this.MarkOfQualification.Size = new Size(230, 20);
            this.MarkOfQualification.TabIndex = 0x31;
            this.Label29.AutoSize = true;
            this.Label29.Location = new Point(0x241, 0x31);
            this.Label29.Name = "Label29";
            this.Label29.Size = new Size(70, 13);
            this.Label29.TabIndex = 0x30;
            this.Label29.Text = "تقدير المؤهل :";
            this.DateOfQualification.Format = DateTimePickerFormat.Short;
            this.DateOfQualification.Location = new Point(15, 0x10);
            this.DateOfQualification.Name = "DateOfQualification";
            this.DateOfQualification.Size = new Size(0x67, 20);
            this.DateOfQualification.TabIndex = 0x2f;
            this.Label28.AutoSize = true;
            this.Label28.Location = new Point(0x79, 0x13);
            this.Label28.Name = "Label28";
            this.Label28.Size = new Size(0x85, 13);
            this.Label28.TabIndex = 0x2e;
            this.Label28.Text = "تاريخ الحصول علي المؤهل :";
            this.Qualification.Location = new Point(0x10b, 0x11);
            this.Qualification.Name = "Qualification";
            this.Qualification.Size = new Size(0x79, 20);
            this.Qualification.TabIndex = 0x1d;
            this.Label27.AutoSize = true;
            this.Label27.Location = new Point(0x18a, 20);
            this.Label27.Name = "Label27";
            this.Label27.Size = new Size(0x2c, 13);
            this.Label27.TabIndex = 0x1c;
            this.Label27.Text = "المؤهل :";
            this.TypeOfQualification.Location = new Point(0x1be, 0x11);
            this.TypeOfQualification.Name = "TypeOfQualification";
            this.TypeOfQualification.Size = new Size(0x80, 20);
            this.TypeOfQualification.TabIndex = 0x1b;
            this.Label26.AutoSize = true;
            this.Label26.Location = new Point(580, 20);
            this.Label26.Name = "Label26";
            this.Label26.Size = new Size(0x40, 13);
            this.Label26.TabIndex = 0x1a;
            this.Label26.Text = "نوع المؤهل :";
            this.TeachSubject.Location = new Point(340, 0x10);
            this.TeachSubject.Name = "TeachSubject";
            this.TeachSubject.Size = new Size(230, 20);
            this.TeachSubject.TabIndex = 0x33;
            this.Label31.AutoSize = true;
            this.Label31.Location = new Point(0x23c, 0x13);
            this.Label31.Name = "Label31";
            this.Label31.Size = new Size(0x45, 13);
            this.Label31.TabIndex = 50;
            this.Label31.Text = "مادة التدريس :";
            this.saveButton.Font = new Font("Microsoft Sans Serif", 10f);
            this.saveButton.Location = new Point(0x206, 0xe4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new Size(0x99, 0x22);
            this.saveButton.TabIndex = 0x35;
            this.saveButton.Text = "حفظ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Location = new Point(12, 8);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x297, 0xd6);
            this.TabControl1.TabIndex = 0x36;
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
            this.TabPage1.Location = new Point(4, 0x16);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x28f, 0xbc);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "البيانات الاساسية";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.PhoneNumber.Location = new Point(0x1bc, 0x89);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new Size(0x80, 20);
            this.PhoneNumber.TabIndex = 0x2f;
            this.Label12.AutoSize = true;
            this.Label12.Location = new Point(0x242, 140);
            this.Label12.Name = "Label12";
            this.Label12.Size = new Size(0x43, 13);
            this.Label12.TabIndex = 0x2e;
            this.Label12.Text = "رقم التليفون :";
            this.Address.Location = new Point(14, 0x6c);
            this.Address.Name = "Address";
            this.Address.Size = new Size(0x175, 20);
            this.Address.TabIndex = 0x2d;
            this.Label11.AutoSize = true;
            this.Label11.Location = new Point(0x188, 0x6f);
            this.Label11.Name = "Label11";
            this.Label11.Size = new Size(0x2d, 13);
            this.Label11.TabIndex = 0x2c;
            this.Label11.Text = "العنوان :";
            this.AddressGovernerate.Location = new Point(0x1bc, 0x6c);
            this.AddressGovernerate.Name = "AddressGovernerate";
            this.AddressGovernerate.Size = new Size(0x71, 20);
            this.AddressGovernerate.TabIndex = 0x2b;
            this.Label10.AutoSize = true;
            this.Label10.Location = new Point(0x233, 0x6f);
            this.Label10.Name = "Label10";
            this.Label10.Size = new Size(0x52, 13);
            this.Label10.TabIndex = 0x2a;
            this.Label10.Text = "محافظة العنوان :";
            this.MartialStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.MartialStatus.FormattingEnabled = true;
            object[] items = new object[] { "غير متزوج/ة", "متزوج/ة", "ارملة", "مطلقة" };
            this.MartialStatus.Items.AddRange(items);
            this.MartialStatus.Location = new Point(14, 0x4e);
            this.MartialStatus.Name = "MartialStatus";
            this.MartialStatus.Size = new Size(0x69, 0x15);
            this.MartialStatus.TabIndex = 0x29;
            this.Label9.AutoSize = true;
            this.Label9.Location = new Point(0x7d, 0x51);
            this.Label9.Name = "Label9";
            this.Label9.Size = new Size(0x56, 13);
            this.Label9.TabIndex = 40;
            this.Label9.Text = "الحالة الاجتماعية :";
            this.Nationality.Location = new Point(0xde, 0x4e);
            this.Nationality.Name = "Nationality";
            this.Nationality.Size = new Size(0x70, 20);
            this.Nationality.TabIndex = 0x27;
            this.Label8.AutoSize = true;
            this.Label8.Location = new Point(0x14e, 0x51);
            this.Label8.Name = "Label8";
            this.Label8.Size = new Size(0x33, 13);
            this.Label8.TabIndex = 0x26;
            this.Label8.Text = "الجنسية : ";
            this.Relegion.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Relegion.FormattingEnabled = true;
            object[] objArray2 = new object[] { "مسلم", "مسيحي" };
            this.Relegion.Items.AddRange(objArray2);
            this.Relegion.Location = new Point(0x189, 0x4e);
            this.Relegion.Name = "Relegion";
            this.Relegion.Size = new Size(0x5b, 0x15);
            this.Relegion.TabIndex = 0x25;
            this.Label7.AutoSize = true;
            this.Label7.Location = new Point(490, 0x51);
            this.Label7.Name = "Label7";
            this.Label7.Size = new Size(0x29, 13);
            this.Label7.TabIndex = 0x24;
            this.Label7.Text = "الديانة :";
            this.Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Gender.FormattingEnabled = true;
            object[] objArray3 = new object[] { "ذكر", "انثي" };
            this.Gender.Items.AddRange(objArray3);
            this.Gender.Location = new Point(0x216, 0x4e);
            this.Gender.Name = "Gender";
            this.Gender.Size = new Size(0x42, 0x15);
            this.Gender.TabIndex = 0x23;
            this.Label6.AutoSize = true;
            this.Label6.Location = new Point(0x25e, 80);
            this.Label6.Name = "Label6";
            this.Label6.Size = new Size(0x24, 13);
            this.Label6.TabIndex = 0x22;
            this.Label6.Text = "النوع :";
            this.BirthGovernerate.Location = new Point(14, 0x30);
            this.BirthGovernerate.Name = "BirthGovernerate";
            this.BirthGovernerate.Size = new Size(0x81, 20);
            this.BirthGovernerate.TabIndex = 0x21;
            this.Label5.AutoSize = true;
            this.Label5.Location = new Point(0x95, 0x33);
            this.Label5.Name = "Label5";
            this.Label5.Size = new Size(0x4d, 13);
            this.Label5.TabIndex = 0x20;
            this.Label5.Text = "محافظة الميلاد :";
            this.DateOfBirth.Format = DateTimePickerFormat.Short;
            this.DateOfBirth.Location = new Point(0xeb, 0x30);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new Size(0x67, 20);
            this.DateOfBirth.TabIndex = 0x1f;
            this.Label4.AutoSize = true;
            this.Label4.Location = new Point(0x158, 0x33);
            this.Label4.Name = "Label4";
            this.Label4.Size = new Size(0x44, 13);
            this.Label4.TabIndex = 30;
            this.Label4.Text = "تاريخ الميلاد :";
            this.Identity.Location = new Point(0x1a5, 0x30);
            this.Identity.Name = "Identity";
            this.Identity.Size = new Size(0x94, 20);
            this.Identity.TabIndex = 0x1d;
            this.Label3.AutoSize = true;
            this.Label3.Location = new Point(0x23f, 0x33);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(70, 13);
            this.Label3.TabIndex = 0x1c;
            this.Label3.Text = "الرقم القومي :";
            this.TeacherCode.Location = new Point(14, 0x10);
            this.TeacherCode.Name = "TeacherCode";
            this.TeacherCode.Size = new Size(0xbb, 20);
            this.TeacherCode.TabIndex = 0x1b;
            this.StaffName.Location = new Point(0x112, 0x10);
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new Size(0x146, 20);
            this.StaffName.TabIndex = 0x1a;
            this.Label2.AutoSize = true;
            this.Label2.Location = new Point(0xcf, 0x13);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x3b, 13);
            this.Label2.TabIndex = 0x19;
            this.Label2.Text = "كود المعلم :";
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(0x25e, 0x13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x24, 13);
            this.Label1.TabIndex = 0x18;
            this.Label1.Text = "الاسم :";
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
            this.TabPage2.Location = new Point(4, 0x16);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x28f, 0xbc);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "البيانات الوظيفية";
            this.TabPage2.UseVisualStyleBackColor = true;
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
            this.TabPage3.Location = new Point(4, 0x16);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new Padding(3);
            this.TabPage3.Size = new Size(0x28f, 0xbc);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "بيانات اخر مؤهل";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.TabPage4.Controls.Add(this.TeachSubject);
            this.TabPage4.Controls.Add(this.Label31);
            this.TabPage4.Location = new Point(4, 0x16);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new Padding(3);
            this.TabPage4.Size = new Size(0x28f, 0xbc);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "خاص للمدرس";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.PrintButton.Location = new Point(12, 0xe0);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new Size(0x89, 0x22);
            this.PrintButton.TabIndex = 0x37;
            this.PrintButton.Text = "طباعة";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Visible = false;
            this.editButton.Location = new Point(0x187, 0xe4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new Size(0x79, 0x22);
            this.editButton.TabIndex = 0x38;
            this.editButton.Text = "تعديل";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x2ab, 0x10b);
            base.Controls.Add(this.editButton);
            base.Controls.Add(this.PrintButton);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.saveButton);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ManageStaff";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اضافة موظف";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            base.ResumeLayout(false);
        }


    }
}

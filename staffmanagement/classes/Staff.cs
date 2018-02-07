using System;
using System.ComponentModel;
using SQLite;

namespace staffmanagement
{
    public class Staff
    {
        [DisplayName("العنوان")]
        public string Address { get; set; }

        [DisplayName("محافظة العنوان")]
        public string AddressGovernerate { get; set; }

        [DisplayName("محافظة الميلاد")]
        public string BirthGovernerate { get; set; }

        [DisplayName("القسم")]
        public int CurrentDepartment { get; set; }

        [DisplayName("الوظيفة")]
        public int CurrentJob { get; set; }

        [DisplayName("رقم قرار الوظيفة الحالية")]
        public string CurrentJobDecisionNo { get; set; }

        [DisplayName("تاريخ قرار الوظيفة الحالية")]
        public DateTime CurrentJobDecisionNoDate { get; set; }

        [DisplayName("تاريخ التعيين")]
        public DateTime DateOfAppointment { get; set; }

        [DisplayName("تاريخ الميلاد")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("تاريخ الحصول علي المؤهل")]
        public DateTime DateOfQualification { get; set; }

        [DisplayName("تاريخ استلام العمل")]
        public DateTime DateOfStartWork { get; set; }

        [DisplayName("الدرجة المالية")]
        public string FinancialClass { get; set; }

        [DisplayName("رقم قرار الدرجة")]
        public string FinancialClassDecisionNo { get; set; }

        [DisplayName("تاريخ سريان الدرجة")]
        public DateTime FinancialClassEndDate { get; set; }

        [DisplayName("تاريخ قرار الدرجة")]
        public DateTime FinancialClassStartDate { get; set; }

        [DisplayName("النوع")]
        public EnumGender Gender { get; set; }

        [DisplayName("رقم التعريفي"), PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [DisplayName("الرقم القومي")]
        public string Identity { get; set; }

        [DisplayName("تقدير المؤهل")]
        public string MarkOfQualification { get; set; }

        [DisplayName("الحالة الاجتماعية")]
        public EnumMartialStatus MartialStatus { get; set; }

        [DisplayName("الجنسية")]
        public string Nationality { get; set; }

        [DisplayName("رقم التلفون")]
        public string PhoneNumber { get; set; }

        [DisplayName("جهة الحصول علي المؤهل")]
        public string PlaceOfQualification { get; set; }

        [DisplayName("المؤهل")]
        public string Qualification { get; set; }

        [DisplayName("الديانة")]
        public EnumRelegion Relegion { get; set; }

        [DisplayName("المجموعة النوعية")]
        public string SpecificGroup { get; set; }

        [DisplayName("الأسم")]
        public string StaffName { get; set; }

        [DisplayName("الموقف من العمل")]
        public string StatusOfJob { get; set; }

        [DisplayName("كود المعلم")]
        public string TeacherCode { get; set; }

        [DisplayName("مادة التدريس")]
        public string TeachSubject { get; set; }

        [DisplayName("نوع التعيين")]
        public string TypeOfAppointment { get; set; }

        [DisplayName("نوع المؤهل")]
        public string TypeOfQualification { get; set; }

        public enum EnumGender
        {
            Male,
            Female
        }

        public enum EnumMartialStatus
        {
            Single,
            Married,
            Widowed,
            Divorced
        }

        public enum EnumRelegion
        {
            Muslim,
            Christian
        }
    }
}


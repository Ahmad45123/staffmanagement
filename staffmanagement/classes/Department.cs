using SQLite;

namespace staffmanagement
{
    public class Department
    {
        public string DepartmentName { get; set; }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}


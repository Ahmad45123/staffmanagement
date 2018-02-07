namespace staffmanagement
{
    public class Job
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string JobName { get; set; }
    }
}


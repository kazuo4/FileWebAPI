namespace FileWebAPI.Models
{
    public class MyFile : IMyFile
    {
        public string FileName { get; set; }
        public string FileValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime Accessed { get; set; }  

        public MyFile(string fileName)
        {
            this.FileName = fileName;
            FileValue = string.Empty; // FileValue assigned empty string at creation
            CreatedAt = DateTime.Now;
        }
    }
}
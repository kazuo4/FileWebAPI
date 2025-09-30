namespace FileWebAPI
{
    public interface IMyFile
    {
        public string FileName { get; set; }
        public string FileValue { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}
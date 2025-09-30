namespace FileWebAPI.Models
{
    public interface IMyFile
    {
        public string FileName { get; set; } // name or id
        public string FileValue { get; set; } // file content
        DateTime CreatedAt { get; set; } // time file created
        DateTime UpdatedAt { get; set; } // time if file updated
        DateTime Accessed { get; set;  } // time file last read
    }
}
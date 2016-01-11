namespace PhotoContest.Models
{
    using System.ComponentModel.DataAnnotations;

    public class File
    {
        [Required]
        public int Id { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        [StringLength(100)]
        public string ContentType { get; set; }

        public byte[] Content { get; set; }
    }
}

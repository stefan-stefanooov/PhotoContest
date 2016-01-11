namespace PhotoContest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Photo
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int Vodes { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int FileId { get; set; }

        public virtual File File { get; set; }
    }
}

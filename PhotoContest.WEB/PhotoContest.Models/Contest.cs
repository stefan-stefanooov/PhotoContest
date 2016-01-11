namespace PhotoContest.Models
{
    using Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Contest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage ="The title must be more then 1 letter long.")]
        public string Title { get; set; }

        [MinLength(2, ErrorMessage = "The description must be more then 1 letter long.")]
        public string Description { get; set; }

        [Required]
        public RewardStrategy RewardStrategy { get; set; }

        public int? NumberOfWinners { get; set; }

        [Required]
        public VotingStrategy VotingStrategy { get; set; }

        public virtual ICollection<User> CommitteeList { get; set; }

        public virtual ICollection<User> ParticipantsList { get; set; }

        [Required]
        public DeadlineStrategy DeadlineStrategy { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }
    }
}

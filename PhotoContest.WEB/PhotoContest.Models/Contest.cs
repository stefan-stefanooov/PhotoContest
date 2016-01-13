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
        [Display(Name = "Reward Strategy")]
        public RewardStrategy RewardStrategy { get; set; }

        [Range(1, 10, ErrorMessage = "Number of winners should be between 1 and 10")]
        public int? NumberOfWinners { get; set; }

        [Required]
        [Display(Name = "Voting Strategy")]
        public VotingStrategy VotingStrategy { get; set; }

        public virtual ICollection<User> CommitteeList { get; set; }

        [Required]
        [Display(Name = "Participation Strategy")]
        public ParticipationStrategy ParticipationStrategy { get; set; }

        public virtual ICollection<User> ParticipantsList { get; set; }

        [Required]
        [Display(Name = "Deadline Strategy")]
        public DeadlineStrategy DeadlineStrategy { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public virtual ICollection<Photo> Pictures { get; set; }
    }
}

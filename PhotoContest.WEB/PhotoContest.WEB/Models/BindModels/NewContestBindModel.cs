using PhotoContest.Models;
using PhotoContest.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhotoContest.WEB.Models.BindModels
{
    public class NewContestBindModel
    {
        [Required]
        [MinLength(2, ErrorMessage = "The title must be more then 1 letter long.")]
        public string Title { get; set; }

        [MinLength(2, ErrorMessage = "The description must be more then 1 letter long.")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Reward Strategy")]
        public RewardStrategy RewardStrategy { get; set; }

        [Display(Name = "Number of Winners")]
        public int? NumberOfWinners { get; set; }

        [Required]
        [Display(Name = "Voting Strategy")]
        public VotingStrategy VotingStrategy { get; set; }

        public ICollection<int> UserIds { get; set; }

        [Required]
        [Display(Name = "Deadline Strategy")]
        public DeadlineStrategy DeadlineStrategy { get; set; }

        [Display(Name = "Finish Time")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> FinishTime { get; set; }

        [Display(Name ="Number of Participants")]
        public int? NumberOfParticipants { get; set; }
    }
}
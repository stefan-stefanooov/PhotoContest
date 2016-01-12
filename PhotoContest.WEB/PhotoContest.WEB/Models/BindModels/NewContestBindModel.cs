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
        public RewardStrategy RewardStrategy { get; set; }

        public int? NumberOfWinners { get; set; }

        [Required]
        public VotingStrategy VotingStrategy { get; set; }

        [Required]
        public DeadlineStrategy DeadlineStrategy { get; set; }
    }
}
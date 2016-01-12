namespace PhotoContest.Models.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum DeadlineStrategy
    {
        [Display(Name = "By Time")]
        ByTime,

        [Display(Name = "By Number")]
        ByNumber
    }
}

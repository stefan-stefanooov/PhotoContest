namespace PhotoContest.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using PhotoContest.Models;

    public class PhotoContestDBContext : IdentityDbContext<User>
    {
        public PhotoContestDBContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static PhotoContestDBContext Create()
        {
            return new PhotoContestDBContext();
        }
    }
}

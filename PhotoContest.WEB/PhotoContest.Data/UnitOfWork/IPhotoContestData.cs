using PhotoContest.Data.Repositories;
using PhotoContest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoContest.Data.UnitOfWork
{
    public interface IPhotoContestData
    {
        IRepository<User> Users { get; }

        IRepository<Contest> Contests { get; }

        IRepository<File> Files { get; }

        IRepository<Photo> Photos { get; }

        void SaveChanges();
    }
}

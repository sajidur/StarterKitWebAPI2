using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL.Repository
{
    public interface INewsContentRepository
    {
        ICollection<NewsContent> GetAll(string type);
        int Save(NewsContent rules);
    }
}

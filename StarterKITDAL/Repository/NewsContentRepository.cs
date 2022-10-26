using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL.Repository
{
    public class NewsContentRepository : INewsContentRepository
    {
        ApplicationDbContext _context;
        public NewsContentRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public int Save(NewsContent newsContent)
        {
            _context.NewsContents.Add(newsContent);
           return _context.SaveChanges();
        }

        ICollection<NewsContent> INewsContentRepository.GetAll(string type)
        {
           return _context.NewsContents.Where(a => a.Type == type).ToList();
        }
    }
}

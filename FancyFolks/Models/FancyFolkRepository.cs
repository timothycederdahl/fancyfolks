using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FancyFolks.Models
{
    public class FancyFolkRepository : IRepository
    {
        private FancyFolkDbContext context = new FancyFolkDbContext();

        public IEnumerable<FancyFolk> FancyFolks
        {
            get { return context.FancyFolks.OrderBy(x => x.LastName); }
        }
    }
}
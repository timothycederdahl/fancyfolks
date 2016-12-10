using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FancyFolks.Models
{
    public interface IRepository
    {
        IEnumerable<FancyFolk> FancyFolks {get;}
    }
}
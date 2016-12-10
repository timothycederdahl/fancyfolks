using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FancyFolks.Models
{
    public class FancyFolk
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthLocation { get; set; }
        public string Bio { get; set; }
    }
}
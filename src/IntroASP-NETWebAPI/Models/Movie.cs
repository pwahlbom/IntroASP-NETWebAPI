using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroASP_NETWebAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public int RunTime { get; set; }
    }
}
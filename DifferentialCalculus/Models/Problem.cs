using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Models
{
    public class Problem
    {
        public int Number { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public List<string> Images { get; set; }
        public bool VerifiedCorrect { get; set; }
        public List<string> Tags { get; set; }
    }
}

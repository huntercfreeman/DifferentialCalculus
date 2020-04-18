using DifferentialCalculus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Interfaces
{
    public interface IProblemRepository
    {
        public List<Problem> GetProblems(string book, string sectionTitle);
    }
}

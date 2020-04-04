﻿using DifferentialCalculus.Interfaces;
using DifferentialCalculus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Repositories
{
    public class ProblemRepository : IProblemRepository
    {
        private Dictionary<string, List<Problem>> _sectionTitleProblems = new Dictionary<string, List<Problem>>();

        public ProblemRepository()
        {
            _sectionTitleProblems.Add("1.1", new List<Problem>
            {
                new Problem { Number = 1 },
                new Problem { Number = 2 },
                new Problem { Number = 3 },
                new Problem { Number = 4 },
                new Problem { Number = 5 },
                new Problem { Number = 6 },
                new Problem { Number = 7 },
                new Problem { Number = 8 },
                new Problem { Number = 9 },
                new Problem { Number = 10 },
                new Problem { Number = 11 },
                new Problem { Number = 12 },
                new Problem { Number = 13 },
                new Problem { Number = 14 },
                new Problem { Number = 15 },
                new Problem { Number = 16 },
                new Problem { Number = 17 },
                new Problem { Number = 18 },
                new Problem { Number = 19 },
                new Problem { Number = 20 },
                new Problem { Number = 21 },
                new Problem { Number = 22 },
                new Problem { Number = 23 },
                new Problem { Number = 24 },
                new Problem { Number = 25 },
                new Problem { Number = 26 },
                new Problem { Number = 27 },
                new Problem { Number = 28 },
                new Problem { Number = 29 },
                new Problem { Number = 30 },
                new Problem { Number = 31 },
                new Problem { Number = 32 },
                new Problem { Number = 33 },
                new Problem { Number = 34 },
                new Problem { Number = 35 },
                new Problem { Number = 36 },
                new Problem { Number = 37 },
                new Problem { Number = 38 },
                new Problem { Number = 39 },
                new Problem { Number = 40 },
                new Problem { Number = 41 },
                new Problem { Number = 42 },
                new Problem { Number = 43 },
                new Problem { Number = 44 },
                new Problem { Number = 45 },
                new Problem { Number = 46 },
                new Problem { Number = 47 },
                new Problem { Number = 48 },
                new Problem { Number = 49 },
                new Problem { Number = 50 },
                new Problem { Number = 51 },
                new Problem { Number = 52 },
                new Problem { Number = 53 },
                new Problem { Number = 54 },
                new Problem { Number = 55 },
                new Problem { Number = 56 },
                new Problem { Number = 57 },
                new Problem { Number = 58 },
                new Problem { Number = 59 },
                new Problem { Number = 60 },
                new Problem { Number = 61 },
                new Problem { Number = 62 },
                new Problem { Number = 63 },
                new Problem { Number = 64 },
                new Problem { Number = 65 },
                new Problem { Number = 66 },
                new Problem { Number = 67 },
                new Problem { Number = 68 },
                new Problem { Number = 69 },
                new Problem { Number = 70 },
                new Problem { Number = 71 },
                new Problem { Number = 72 },
                new Problem { Number = 73 },
                new Problem { Number = 74 }
            });
            _sectionTitleProblems.Add("1.2", new List<Problem> 
            {
                new Problem { Number = 1 },
                new Problem { Number = 2 },
                new Problem { Number = 3 },
                new Problem { Number = 4 },
                new Problem { Number = 5 },
                new Problem { Number = 6 },
                new Problem { Number = 7 },
                new Problem { Number = 8 },
                new Problem { Number = 9 },
                new Problem { Number = 10 },
                new Problem { Number = 11 },
                new Problem { Number = 12 },
                new Problem { Number = 13 },
                new Problem { Number = 14 },
                new Problem { Number = 15 },
                new Problem { Number = 16 },
                new Problem { Number = 17 },
                new Problem { Number = 18 },
                new Problem { Number = 19 },
                new Problem { Number = 20 },
                new Problem { Number = 21 },
                new Problem { Number = 22 },
                new Problem { Number = 23 },
                new Problem { Number = 24 },
                new Problem { Number = 25 },
                new Problem { Number = 26 }
            });
            _sectionTitleProblems.Add("1.3", new List<Problem>
            {
                new Problem { Number = 1 },
                new Problem { Number = 2 },
                new Problem { Number = 3 },
                new Problem { Number = 4 },
                new Problem { Number = 5 },
                new Problem { Number = 6 },
                new Problem { Number = 7 },
                new Problem { Number = 8 },
                new Problem { Number = 9 },
                new Problem { Number = 10 },
                new Problem { Number = 11 },
                new Problem { Number = 12 },
                new Problem { Number = 13 },
                new Problem { Number = 14 },
                new Problem { Number = 15 },
                new Problem { Number = 16 },
                new Problem { Number = 17 },
                new Problem { Number = 18 },
                new Problem { Number = 19 },
                new Problem { Number = 20 },
                new Problem { Number = 21 },
                new Problem { Number = 22 },
                new Problem { Number = 23 },
                new Problem { Number = 24 },
                new Problem { Number = 25 },
                new Problem { Number = 26 },
                new Problem { Number = 27 },
                new Problem { Number = 28 },
                new Problem { Number = 29 },
                new Problem { Number = 30 },
                new Problem { Number = 31 },
                new Problem { Number = 32 },
                new Problem { Number = 33 },
                new Problem { Number = 34 },
                new Problem { Number = 35 },
                new Problem { Number = 36 },
                new Problem { Number = 37 },
                new Problem { Number = 38 },
                new Problem { Number = 39 },
                new Problem { Number = 40 },
                new Problem { Number = 41 },
                new Problem { Number = 42 },
                new Problem { Number = 43 },
                new Problem { Number = 44 },
                new Problem { Number = 45 },
                new Problem { Number = 46 },
                new Problem { Number = 47 },
                new Problem { Number = 48 },
                new Problem { Number = 49 },
                new Problem { Number = 50 },
                new Problem { Number = 51 },
                new Problem { Number = 52 },
                new Problem { Number = 53 },
                new Problem { Number = 54 },
                new Problem { Number = 55 },
                new Problem { Number = 56 },
                new Problem { Number = 57 },
                new Problem { Number = 58 },
                new Problem { Number = 59 },
                new Problem { Number = 60 },
                new Problem { Number = 61 },
                new Problem { Number = 62 },
                new Problem { Number = 63 },
                new Problem { Number = 64 }
            });
            _sectionTitleProblems.Add("1.4", new List<Problem>
            {
                new Problem { Number = 1 },
                new Problem { Number = 2 },
                new Problem { Number = 3 },
                new Problem { Number = 4 },
                new Problem { Number = 5 },
                new Problem { Number = 6 },
                new Problem { Number = 7 },
                new Problem { Number = 8 },
                new Problem { Number = 9 },
                new Problem { Number = 10 },
                new Problem { Number = 11 },
                new Problem { Number = 12 },
                new Problem { Number = 13 },
                new Problem { Number = 14 },
                new Problem { Number = 15 },
                new Problem { Number = 16 },
                new Problem { Number = 17 },
                new Problem { Number = 18 },
                new Problem { Number = 19 },
                new Problem { Number = 20 },
                new Problem { Number = 21 },
                new Problem { Number = 22 },
                new Problem { Number = 23 },
                new Problem { Number = 24 },
                new Problem { Number = 25 },
                new Problem { Number = 26 },
                new Problem { Number = 27 },
                new Problem { Number = 28 },
                new Problem { Number = 29 },
                new Problem { Number = 30 },
                new Problem { Number = 31 },
                new Problem { Number = 32 },
                new Problem { Number = 33 },
                new Problem { Number = 34 },
                new Problem { Number = 35 },
                new Problem { Number = 36 },
                new Problem { Number = 37 },
                new Problem { Number = 38 }
            });
            _sectionTitleProblems.Add("1.5", new List<Problem> 
            {
                new Problem { Number = 1 },
                new Problem { Number = 2 },
                new Problem { Number = 3 },
                new Problem { Number = 4 },
                new Problem { Number = 5 },
                new Problem { Number = 6 },
                new Problem { Number = 7 },
                new Problem { Number = 8 },
                new Problem { Number = 9 },
                new Problem { Number = 10 },
                new Problem { Number = 11 },
                new Problem { Number = 12 },
                new Problem { Number = 13 },
                new Problem { Number = 14 },
                new Problem { Number = 15 },
                new Problem { Number = 16 },
                new Problem { Number = 17 },
                new Problem { Number = 18 },
                new Problem { Number = 19 },
                new Problem { Number = 20 },
                new Problem { Number = 21 },
                new Problem { Number = 22 },
                new Problem { Number = 23 },
                new Problem { Number = 24 },
                new Problem { Number = 25 },
                new Problem { Number = 26 },
                new Problem { Number = 27 },
                new Problem { Number = 28 },
                new Problem { Number = 29 },
                new Problem { Number = 30 },
                new Problem { Number = 31 },
                new Problem { Number = 32 },
                new Problem { Number = 33 },
                new Problem { Number = 34 },
                new Problem { Number = 35 },
                new Problem { Number = 36 }
            });
            _sectionTitleProblems.Add("1.6", new List<Problem>
            {
                new Problem { Number = 1 }
            });
        }


        public List<Problem> GetProblems(string sectionTitle)
        {
            try
            {
                return _sectionTitleProblems[sectionTitle];
            }
            catch(Exception)
            {
                return new List<Problem>();
            }
        }
    }
}

using DifferentialCalculus.Interfaces;
using DifferentialCalculus.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Shared
{
    public partial class NextQuestion : ComponentBase
    {
        [Inject]
        public SiteState SiteState { get; set; }
        [Inject]
        public IProblemRepository ProblemRepository { get; set; }


        public void GetNextQuestion()
        {
            List<Problem> problems = ProblemRepository.GetProblems(SiteState.CurrentBook, SiteState.CurrentSectionTitle);

            if (problems.Count > SiteState.CurrentProblem.Number)
                SiteState.CurrentProblem = problems[SiteState.CurrentProblem.Number];
        }
    }
}

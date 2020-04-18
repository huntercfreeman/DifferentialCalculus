using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Shared
{
    public partial class BookItem : ComponentBase
    {
        [Parameter]
        public string BookTitle { get; set; }
        [Parameter]
        public string InternalBookTitle { get; set; }
        [Parameter]
        public string ImageURL { get; set; }
    }
}

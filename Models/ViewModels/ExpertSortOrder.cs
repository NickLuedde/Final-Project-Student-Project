using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GAG_101.Models.ViewModels
{
    public enum ExpertSortOrder
    {
     
        [Display(Name = "Best Ranking")]
        bestReviews,
        [Display(Name = "Fair Pricing Score")]
        fairPriceRanking,
        [Display(Name = "Quality Work Score")]
        qualityRanking,
        [Display(Name = "Timely Completion Score")]
        timeleyCompletioneRanking


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GAG_101.Models
{
    public partial class UserReviews1
    {

        public double AverageRating
        {
            get { return (Quality_Rating + FairPrice_Rating + CompletionTime_Rating) / 3.0; }

        }

        public double FairPriceRating
        {
            get { return (FairPrice_Rating); }

        }

        public double QualityRating
        {
            get { return (Quality_Rating); }
        }

        public double CompletionTime
        {
            get
            {
                return (CompletionTime_Rating);

            }



        }
        public double bestReviews
        {
            get { return (Quality_Rating + FairPrice_Rating + CompletionTime_Rating) / 3.0; }

        }


    }
}
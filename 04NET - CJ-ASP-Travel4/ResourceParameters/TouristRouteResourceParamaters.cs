using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04NET___CJ_ASP_Travel4.ResourceParameters
{
    public class TouristRouteResourceParamaters
    {

/*        //分页----------------------
        private int _pageNumber = 1;
        public int PageNumber
        {
            get
            {
                return _pageNumber;
            }
            set
            {
                if (value >= 1)
                {
                    _pageNumber = value;
                }
            }
        }
        private int _pageSize = 10;
        const int maxPageSize = 50;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                if (value >= 1)
                {
                    _pageSize = (value > maxPageSize) ? maxPageSize : value;
                }
            }
        }
        //分页----------------------*/

        public string Keyword { get; set; }
        public string RatingOperator { get; set; }
        public int? RatingValue { get; set; }
        private string _rating;
        public string Rating {
            get { return _rating; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Regex regex = new Regex(@"([A-Za-z0-9\-]+)(\d+)");
                    Match match = regex.Match(value);
                    if (match.Success)
                    {
                        RatingOperator = match.Groups[1].Value;
                        RatingValue = Int32.Parse(match.Groups[2].Value);
                    }
                }
                _rating = value;
            } 
        }
    }
}

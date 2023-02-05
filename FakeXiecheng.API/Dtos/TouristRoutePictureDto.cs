using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03NET___CJ_ASP_Travel3.Dtos
{
    public class TouristRoutePictureDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public Guid TouristRouteId { get; set; }
    }
}

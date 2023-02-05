using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _04NET___CJ_ASP_Travel4.Dtos;

namespace _04NET___CJ_ASP_Travel4.API.Dtos
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public ICollection<LineItemDto> OrderItems { get; set; }
        public string State { get; set; }
        public DateTime CreateDateUTC { get; set; }
        public string TransactionMetadata { get; set; }
    }
}

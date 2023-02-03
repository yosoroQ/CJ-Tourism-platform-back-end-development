using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using _01NET___CJ_ASP_Travel.Controllers;

namespace _01NET___CJ_ASP_Travel.Models
{
    public class TouristRoute
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        //路线简介
        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }

        //原价
        [Column(TypeName = "decimal(18, 2)")]
        public decimal OriginalPrice { get; set; }

        /*        ？可控类型*//*折扣*/
        [Range(0.0, 1.0)]
        public double? DiscountPresent { get; set; }

        //线路发布时间
        public DateTime CreateTime { get; set; }

        //线路更新时间
        public DateTime UpdateTime { get; set; }

        //出发时间
        public DateTime? DepartureTime { get; set; }

        //说明
        [MaxLength]
        public string Features { get; set; }

        //费用说明
        [MaxLength]
        public string Fees { get; set; }

        [MaxLength]
        public string Notes { get; set; }

        //建立相应的外键关系TouristRoutePicture.cs
        public ICollection<TouristRoutePicture> TouristRoutePictures { get; set; }
            = new List<TouristRoutePicture>();

        //评分
        public double? Rating { get; set; }

        //旅行天数
        public TravelDays TravelDays { get; set; }

        //旅游类型
        public TripType? TripType { get; set; }

        //出发地
        public DepartureCity? DepartureCity { get; set; }

    }
}

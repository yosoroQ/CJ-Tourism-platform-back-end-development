using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _01NET___CJ_ASP_Travel.Models
{
    public class TouristRoutePicture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //照片属性
        [MaxLength(100)]
        public string Url { get; set; }

        //与旅游路线相关的外键关系
        [ForeignKey("TouristRouteId")]
        public Guid TouristRouteId { get; set; }

        //连接关系
        public TouristRoute TouristRoute { get; set; }
    }
}

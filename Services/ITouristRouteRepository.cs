using _01NET___CJ_ASP_Travel.Models;

namespace _01NET___CJ_ASP_Travel.Services
{
    public interface ITouristRouteRepository
    {
        //返回一组旅游路线
        IEnumerable<TouristRoute> GetTouristRoutes();

        //返回单独的旅游路线
        TouristRoute GetTouristRoute(Guid touristRouteId);

        //
        bool TouristRouteExists(Guid touristRouteId);
        IEnumerable<TouristRoutePicture> GetPicturesByTouristRouteId(Guid touristRouteId);
        TouristRoutePicture GetPicture(int pictureId);
    }
}

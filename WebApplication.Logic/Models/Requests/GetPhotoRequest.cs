using WebApplication.Logic.Interfaces;

namespace WebApplication.Logic.Models.Requests
{
    public class GetPhotoRequest : ITypeCodeRequest
    {
        public GetPhotoRequest(int albumId)
        {
            AlbumId = albumId;     
        }
        public int AlbumId { get; set; }

        public string GetRequestsParams()
        {
            string result = "photos";
            if (AlbumId > 0)
            {
                result += $"?albumId={AlbumId}";
            }
            return result;
        }
    }
}

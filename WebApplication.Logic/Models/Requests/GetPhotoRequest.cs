using WebApplication2.Logic.Interfaces;

namespace WebApplication2.Logic.Models.Requests
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

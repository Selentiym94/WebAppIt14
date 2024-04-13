using WebApplication2.Logic.Interfaces;

namespace WebApplication2.Logic.Models.Requests
{
    public class GetAlbuRequest : ITypeCodeRequest
    {
        public GetAlbuRequest(int userId)
        {
                UserId = userId;
        }
        public int UserId { get; set; }

        public string GetRequestsParams()
        {
            string result = "albums";
            if (UserId > 0)
            {
                result += $"?userId={UserId}";
            }
            return result;
        }
    }
}

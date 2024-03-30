using WebApplication.Logic.Interfaces;

namespace WebApplication.Logic.Models.Requests
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
            if (UsertId > 0)
            {
                result += $"?userId={UsertId}";
            }
            return result;
        }
    }
}

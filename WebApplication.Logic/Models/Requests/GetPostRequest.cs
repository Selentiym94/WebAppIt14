using WebApplication2.Logic.Interfaces;

namespace WebApplication2.Logic.Models.Requests
{
    public class GetPostRequest : ITypeCodeRequest
    {
        public GetPostRequest(int userId)
        {
                UsertId = userId;
        }
        public int UsertId { get; set; }
        public string GetRequestsParams()
        {
            string result = "post";
            if (UsertId > 0)
            {
                result += $"?userId={UsertId}";
            }
            return result;
        }
    }
}

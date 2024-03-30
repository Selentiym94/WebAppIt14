using WebApplication.Logic.Interfaces;

namespace WebApplication.Logic.Models.Requests
{
    public class GetCommentRequest : ITypeCodeRequest
    {
        public GetCommentRequest(int postId)
        {
                PostId = postId;
        }
        public int PostId { get; set; }

        public string GetRequestsParams()
        {
            string result = "comments";
            if (PostId > 0)
            {
                result += $"?postId={PostId}";
            }
            return result;
        }
    }
}

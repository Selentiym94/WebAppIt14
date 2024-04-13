using WebApplication2.Logic.Interfaces;

namespace WebApplication2.Logic.Models.Requests
{
    public class GetUserRequest : ITypeCodeRequest
    {
        public GetUserRequest(string name) 
        { 
            Name = name;
        } 
        public string Name { get; set; }
        public string GetRequestsParams()
        {
            string result = "users";
            if (!string.IsNullOrEmpty(Name))
            {
                result += $"?name={Name}";
            }
            return result;
        }
    }
}

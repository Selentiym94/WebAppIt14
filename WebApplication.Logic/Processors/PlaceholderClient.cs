using Miha.Models;
using System.Text.Json;
using WebApplication.Logic.Interfaces;
using WebApplication.Logic.Models.Requests;

namespace WebApplication.Logic.Processors
{
    public class PlaceholderClient : IPlaceholderClient
    {
        private readonly string _baseUrl;

        public PlaceholderClient(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public async Task<List<Photo>> GetPhotos(int? postId)
        {
            ITypeCodeRequest request = new GetPhotoRequest(postId.GetValueOrDefault());
            return await GetData<Photo>(request);
        }


        public async Task<List<Comment>> GetComments(int? postId)
        {
            ITypeCodeRequest request = new GetCommentRequest(postId.GetValueOrDefault());
            return await GetData<Comment>(request);
        }

        public async Task<List<Album>> GetAlbums(int? userId)
        {
            ITypeCodeRequest request = new GetAlbuRequest(userId.GetValueOrDefault());
            return await GetData<Album>(request);
        }

        public async Task<List<Post>> GetPosts(int? userId)
        {
            ITypeCodeRequest request = new GetPostRequest(userId.GetValueOrDefault());
            return await GetData<Post>(request);
        }

        public async Task<List<Todos>> GetTodos(int? userId)
        {
            ITypeCodeRequest request = new GetTodoRequest(userId.GetValueOrDefault());
            return await GetData<Todos>(request);
        }

        public async Task<List<User>> GetUser(string name)
        {
            ITypeCodeRequest request = new GetUserRequest(name);
            return await GetData<User>(request);
        }

        private async Task<List<TData>> GetData<TData>(ITypeCodeRequest request)
        {
            using (HttpClient client = new HttpClient())
            {
                string path = request.GetRequestsParams();
                HttpRequestMessage message = new HttpRequestMessage();
                message.RequestUri = new Uri($"{_baseUrl}/{path}");
                message.Method = HttpMethod.Get;

                HttpResponseMessage response = await client.SendAsync(message);
                if (response.IsSuccessStatusCode)
                {
                    string dataString = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<List<TData>>(dataString);
                }
                return new List<TData>();
            }
        }
    }
}

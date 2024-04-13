using Miha.Models;
using WebApplication2.Logic.Interfaces;
using WebApplication2.Logic.Models;

namespace WebApplication2.Logic.Processors
{
    public class PlaceholderDataProcessor
    {
        private readonly IPlaceholderClient _client;

        public PlaceholderDataProcessor(IPlaceholderClient client)
        {
            _client = client;
        }

        public async Task<PlaceholderResult> GetData(string userName)
        {
            User user = (await _client.GetUser(userName))?.FirstOrDefault();
            PlaceholderResult result = new PlaceholderResult(user);
            if (user == null)
            {
                return result;
            }
            result.Todos = await _client.GetTodos(user.Id);
            result.PostDatas = await GetPostData(user.Id);
            result.AlbumDatas = await GetAlbumData(user.Id);
            return result;
        }

        private async Task<List<PostData>> GetPostData(int userId)
        {
            List<PostData> postDatas = new List<PostData>();
            List<Post> posts = await _client.GetPosts(userId);
            foreach (Post post in posts??new List<Post>())
            {
                List<Comment> comments = await _client.GetComments(post.Id);
                PostData postData = new PostData(post, comments);
                postDatas.Add(postData); 
            }
            return postDatas;
        }

        private async Task<List<AlbumData>> GetAlbumData(int userId)
        {
            List<AlbumData> albumsDatas = new List<AlbumData>();
            List<Album> albums = await _client.GetAlbums(userId);
            foreach (Album album in albums ?? new List<Album>())
            {
                List<Photo> photos = await _client.GetPhotos(album.Id);
                AlbumData albumData = new AlbumData(album, photos);
                albumsDatas.Add(albumData);
            }
            return albumsDatas;
        }
    }
}

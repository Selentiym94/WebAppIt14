using Miha.Models;

namespace WebApplication2.Logic.Models
{
    public class PlaceholderResult
    {
        public PlaceholderResult(User user )
        {
            User = user;
        }
        public User User { get; set; }
        public List<Todos> Todos { get; set; }
        public List<AlbumData> AlbumDatas { get; set; }
        public List<PostData> PostDatas { get; set; }
    }
}

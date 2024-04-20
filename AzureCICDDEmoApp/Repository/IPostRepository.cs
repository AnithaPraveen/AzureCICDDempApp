using AzureCICDDEmoApp.Models;

namespace AzureCICDDEmoApp.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();

        //void AddPosts();
    }
}

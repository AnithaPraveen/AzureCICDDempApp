using AzureCICDDEmoApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AzureCICDDEmoApp.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;

        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public IActionResult Index()
        {
            var postdata = _postRepository.GetPosts();

            return View(postdata);
        }

    }
}

using AzureCICDDEmoApp.Controllers;
using AzureCICDDEmoApp.Models;
using AzureCICDDEmoApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AzureCICDDemoTestAPP
{
    public class UnitTest1
    {
        private PostRepository postRepository;
        public UnitTest1()
        {
            postRepository = new PostRepository();
        }
        [Fact]
        public void Test_Index_View_Result()
        {
            //Arrange
            var postcontroller=new PostController(this.postRepository);

            //Act
            var result = postcontroller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        public void Test_Index_Return_Result()
        { 
         //Arramge
         var postcontroller=new PostController(this.postRepository);

            //Act
            var result=postcontroller.Index();

            //Assert
            Assert.NotNull(result);        
        }
        public void Test_Return_PostData()
        {

            //Arrange

            var postcontroller = new PostController(this.postRepository);

            //Act

            var result = postcontroller.Index();
            //Assert
            var postsresult = Assert.IsType<ViewResult>(result);

            var postmodel=Assert.IsAssignableFrom<List<PostViewModel>>(postsresult.ViewData.Model);

            Assert.Equal(3, postmodel.Count);
            Assert.Equal(101, postmodel[0].PostId);
            Assert.Equal("DevOps Demo Title 1", postmodel[0].Title);
        }
    }
}
using BethanysPieShop.Controlers;
using BethanysPieShop.ViewModels;
using BethanysPieShopTests.Mocks;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShopTests.Controllers
{
    public class PieControllerTests
    {
        [Fact]
        public void List_EmptyCategory_ReturnsAllPies()
        {
            // arrange
            var pieController = new PieController(
                RepositoryMocks.GetPieRepository().Object, 
                RepositoryMocks.GetCategoryRepository().Object);

            // act
            var result = pieController.List(null);

            // assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var pieListViewModel = Assert.IsAssignableFrom<PieListViewModel>(viewResult.ViewData.Model);
            Assert.Equal(10, pieListViewModel.Pies.Count());
        }
    }
}
using LuxeStep.Models;

namespace LuxeStep.ViewModels
{
    public class ShoeListViewModel
    {
        public IEnumerable<Shoe> Shoes { get; }
        public string? CurrentCategory { get; }

        public ShoeListViewModel(IEnumerable<Shoe> shoes, string? currentCategory)
        {
            Shoes = shoes;
            CurrentCategory = currentCategory;
        }
    }
}

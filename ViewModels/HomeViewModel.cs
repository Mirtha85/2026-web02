using LuxeStep.Models;

namespace LuxeStep.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Shoe> ShoesOfTheWeek { get; set; } = new List<Shoe>();
        public IEnumerable<Shoe> AllShoes { get; set; } = new List<Shoe>();
    }
}
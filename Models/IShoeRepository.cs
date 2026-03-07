namespace LuxeStep.Models
{
    public interface IShoeRepository
    {
        IEnumerable<Shoe> AllShoes { get; }
        IEnumerable<Shoe> ShoesOfTheWeek { get; }
        Shoe? GetShoeById(int shoeId);
        IEnumerable<Shoe> SearchShoes(string searchQuery);
    }
}

using BookStore.Domain.Entities;

namespace BookStore.BL.Dto
{
    public class GetBookDto
    {
        public Ulid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal? RentPricePerDay { get; set; }
        public decimal? FinePricePerDay { get; set; }
        public int PageCount { get; set; }
        public string ISBN { get; set; }
        public DateOnly PublishDate { get; set; }
        public string Publisher { get; set; }
    }
}

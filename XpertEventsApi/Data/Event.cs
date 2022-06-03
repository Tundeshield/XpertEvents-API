using System.ComponentModel.DataAnnotations.Schema;

namespace XpertEventsApi.Data
{
    public class Event
    {
        public int Id { get; set; }
        public string EventTitle { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public string Description { get; set; }
    }
}

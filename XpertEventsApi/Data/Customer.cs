namespace XpertEventsApi.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string password { get; set; }

        public virtual IList<Event> Events { get; set; }
    }
}
namespace XpertEventsApi.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }    

        public virtual IList<Event> Events { get; set; }
    }
}
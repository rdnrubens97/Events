namespace Events.Api.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventPlace { get; set; }
        public string EventDate { get; set; }
        public string EventTheme { get; set; }
        public int NumberOfPeople { get; set; }
        public string Batch { get; set; }
        public string UrlImage { get; set; }

        public Event()
        {
        }
    }
}

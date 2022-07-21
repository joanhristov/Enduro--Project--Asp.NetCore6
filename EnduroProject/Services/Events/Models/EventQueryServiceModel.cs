namespace EnduroProject.Services.Events.Models
{
    public class EventQueryServiceModel
    {
        public int CurrentPage { get; init; }

        public int EventsPerPage { get; init; }

        public int TotalEvents { get; init; }

        public IEnumerable<EventServiceModel> Pets { get; init; }
    }
}

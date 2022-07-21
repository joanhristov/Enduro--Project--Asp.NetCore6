namespace EnduroProject.Services.Events
{
    using EnduroProject.Models;
    using EnduroProject.Services.Events.Models;

    public class IEventService
    {
        EventQueryServiceModel All(
            string category = null,
            string searchTerm = null,
            EventSorting sorting = EventSorting.DateCreated,
            int currentPage = 1,
            int eventsPerPage = int.MaxValue,
            bool publicOnly = true);
    }
}

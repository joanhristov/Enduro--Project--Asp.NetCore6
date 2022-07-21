namespace EnduroProject.Services.Events.Models
{
    using System;

    public class EventServiceModel : IEventModel
    {
        public string Id { get; init; }

        public string Name { get; init; }

        public DateTime Date { get; init; }

        public string Duration { get; init; }

        public DateTime DateCreated { get; init; }

        public string Location { get; init; }

        public int PeopleCapacity { get; init; }

        public string ContactInfo { get; init; }

        public string Image { get; init; }

        public string CategoryName { get; init; }

        public bool IsPublic { get; init; }
    }
}

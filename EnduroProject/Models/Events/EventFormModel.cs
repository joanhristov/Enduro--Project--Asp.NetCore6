namespace EnduroProject.Models.Events
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using EnduroProject.Services.Events.Models;

    using static Data.DataConstants.Event;

    public class EventFormModel : IEventModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; init; }

        [Required]
        public DateTime Date { get; init; }

        [Required]
        public string Duration { get; init; }

        public DateTime DateCreated { get; init; }

        [Required]
        [StringLength(LocationMaxLength, 
            MinimumLength = LocationMinLength,
            ErrorMessage = "The location must be at least 5 characters long.")]
        public string Location { get; init; }

        [Required]
        public int PeopleCapacity { get; init; }

        [Required]
        [StringLength(ContactInfoMaxLength, 
            MinimumLength = ContactInfoMinLength, 
            ErrorMessage = "The field Contact Info must be at least 5 to 15 characters long.")]
        public string ContactInfo { get; set; }

        [Required]
        [StringLength(
            int.MaxValue, 
            MinimumLength = DescriptionMinLenght, 
            ErrorMessage = "The field Description must be a string with a minimum length of {2}.")]
        public string Description { get; set; }

        public string Image { get; init; }
        
        public int CategoryId { get; set; }

        public IEnumerable<EventCategoryServiceModel> Categories { get; set; }
    }
}

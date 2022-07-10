namespace EnduroProject.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.Event;

    public class Event
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Duration { get; set; }

        public DateTime DateCreated { get; init; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int PeopleCapacity { get; set; }

        [Required]
        [MaxLength(ContactInfoMaxLength)]
        public string ContactInfo { get; set; }

        [Required]
        public string Description { get; set; }

        public string Image { get; init; }

        public int CategoryId { get; set; }

        public Category Category { get; init; }

        public int UserId { get; set; }

        public User User { get; init; }
    }
}

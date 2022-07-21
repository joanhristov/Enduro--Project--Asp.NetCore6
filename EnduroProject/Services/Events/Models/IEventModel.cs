namespace EnduroProject.Services.Events.Models
{
    public interface IEventModel
    {
        string Name { get; }

        DateTime Date { get; }

        string Location { get; }
    }
}

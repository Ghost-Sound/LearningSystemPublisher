namespace LearningSystem.Publisher.Events
{
    public record UserCreatedEvent
    {
        public string Id { get; set; }
        public DateTime Created { get; set; }
    }
}

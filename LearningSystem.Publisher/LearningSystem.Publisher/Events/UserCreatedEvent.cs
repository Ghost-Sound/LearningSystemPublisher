namespace LearningSystem.Publisher.Events
{
    public record UserCreatedEvent
    {
        public Ulid Id { get; set; }
        public DateTime Created { get; set; }
    }
}

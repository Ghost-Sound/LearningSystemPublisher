using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Publisher.Events
{
    public record DepartmentCreatedEvent
    {
        public string Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }
    }
}

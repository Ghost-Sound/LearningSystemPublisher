namespace LearningSystem.Publisher.Events
{
    public record DeleteDepartmentEvent
    {
        public string DepartmentId { get; set; }
    }
}

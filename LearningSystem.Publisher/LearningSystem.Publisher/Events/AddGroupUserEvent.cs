namespace LearningSystem.Publisher.Events
{
    public record AddGroupUserEvent
    {
        public string GroupId { get; set; }
        public string DepartmentId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

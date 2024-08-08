namespace LearningSystem.Publisher.Events
{
    public record AddGroupDepartmentEvent
    {
        public string GroupId { get; set; }
        public string DepartmentId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

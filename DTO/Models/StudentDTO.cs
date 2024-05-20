namespace DTO.Models
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string? StudentId { get; set; }
        public string? FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? MajorName { get; set; }
    }
}

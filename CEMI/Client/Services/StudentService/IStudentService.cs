namespace CEMI.Client.Services.StudentService
{
    public interface IStudentService
    {
        List<StudentModel> Students { get; set; }
        Task GetStudents();
        Task<StudentModel> GetSingleStudent(int id);
        Task CreateStudent(StudentModel student);
        Task UpdateStudent(StudentModel student);
        Task DeleteStudent(int id);
    }
}

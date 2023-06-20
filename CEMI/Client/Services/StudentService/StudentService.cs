using Microsoft.AspNetCore.Components;

namespace CEMI.Client.Services.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly NavigationManager _navigationManager;
        private readonly Supabase.Client _supabase;

        public StudentService(NavigationManager navigationManager, Supabase.Client client)
        {
            _navigationManager = navigationManager;
            _supabase = client;
        }

        public List<StudentModel> Students { get; set; } = new List<StudentModel>();

        // GET
        public async Task GetStudents()
        {
            var result = await _supabase.From<StudentModel>().Get();
            var students = result.Models;

            if (result != null)
                Students = students;
        }

        public async Task<StudentModel> GetSingleStudent(int id)
        {
            var result = await _supabase.From<StudentModel>().Where(x => x.Id == id).Single();   

            if (result != null)
                return result;

            throw new Exception("Geen student gevonden.");
        }

        // POST
        public async Task CreateStudent(StudentModel student)
        {
            // IMPORTANT to store dates in UTC-format!
            var newStudent = new CreateStudent
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthDate = student.BirthDate!.Value.ToUniversalTime(),
                ClassLevel = student.ClassLevel,
                Enrolled = true,
                OldStudent = student.OldStudent,
                Graduated = student.Graduated,
                Phone_1 = student.Phone_1,
                Phone_2 = student.Phone_2,
                Email1 = student.Email1,
                Email2 = student.Email2,
                Street = student.Street,
                District = student.District,
                PostalCode = student.PostalCode,
                HouseNumber = student.HouseNumber,
                HomeAlone = student.HomeAlone,
                Remarks = student.Remarks
            };

            await _supabase.From<CreateStudent>().Insert(newStudent);
            NavigateToOverview();
        }

        // PUT
        public async Task UpdateStudent(StudentModel student)
        {
            var model = await _supabase
                .From<StudentModel>()
                .Where(x => x.Id == student.Id)
                .Single() ?? throw new Exception("Geen student gevonden.");

            model.FirstName = student.FirstName;
            model.LastName = student.LastName;
            model.ClassLevel = student.ClassLevel;
            model.BirthDate = student.BirthDate;
            model.Phone_1 = student.Phone_1;
            model.Phone_2 = student.Phone_2;
            model.Email1 = student.Email1;
            model.Email2 = student.Email2;
            model.HomeAlone = student.HomeAlone;
            model.Remarks = student.Remarks;
            model.Enrolled = true;
            model.Graduated = student.Graduated;
            model.Street = student.Street;
            model.HouseNumber = student.HouseNumber;
            model.PostalCode = student.PostalCode;
            model.District = student.District;

            await model.Update<StudentModel>();
            NavigateToOverview();
        }

        // DELETE
        public async Task DeleteStudent(int id)
        {
            await _supabase.From<StudentModel>().Where(x => x.Id == id).Delete();

            NavigateToOverview();
        }

        private void NavigateToOverview()
        {
            _navigationManager.NavigateTo("/students", true);
        }
    }
}

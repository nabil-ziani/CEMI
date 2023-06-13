using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace CEMI.Client.Services.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient _httpClient;
        private readonly NavigationManager _navigationManager;

        public StudentService(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
        }

        public List<StudentModel> Students { get; set; } = new List<StudentModel>();

        // GET
        public async Task GetStudents()
        {
            var result = await _httpClient.GetFromJsonAsync<List<StudentModel>>("api/student");

            if (result != null)
                Students = result;
        }

        public async Task<StudentModel> GetSingleStudent(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<StudentModel>($"api/student/{id}");

            if (result != null)
                return result;

            throw new Exception("Student niet gevonden!");
        }

        // POST
        public async Task CreateStudent(StudentModel student)
        {
            var result = await _httpClient.PostAsJsonAsync("api/student", student);
            await SetStudents(result);
        }

        // PUT
        public async Task UpdateStudent(StudentModel student)
        {
            var result = await _httpClient.PutAsJsonAsync($"api/student/{student.Id}", student);
            await SetStudents(result);
        }

        // DELETE
        public async Task DeleteStudent(int id)
        {
            var result = await _httpClient.DeleteAsync($"api/student/{id}");
            await SetStudents(result);
        }

        private async Task SetStudents(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<StudentModel>>();
            Students = response;
            _navigationManager.NavigateTo("students");
        }
    }
}

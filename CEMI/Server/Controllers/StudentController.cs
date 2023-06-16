using CEMI.Server.Data;
using Microsoft.AspNetCore.Mvc;

namespace CEMI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public StudentController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<StudentModel>>> GetStudents()
        {
            var students = await _dataContext.Students.ToListAsync();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentModel>> GetSingleStudent(int id)
        {
            var student = await _dataContext.Students.FirstOrDefaultAsync(student => student.Id == id);
            if (student == null)
            {
                return NotFound("Geen leerling gevonden.");
            }

            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<List<StudentModel>>> CreateStudent(StudentModel student)
        {
            student.Enrolled = true;

            _dataContext.Students.Add(student);
            
            await _dataContext.SaveChangesAsync();

            return Ok(await GetDbStudents());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<StudentModel>>> UpdateStudent(StudentModel student, int id)
        {
            var dbStudent = await _dataContext.Students.FirstOrDefaultAsync(student => student.Id == id);

            if (dbStudent == null)
            {
                return NotFound("Geen student gevonden.");
            }

            dbStudent.FirstName = student.FirstName;
            dbStudent.LastName = student.LastName;
            dbStudent.BirthDate = student.BirthDate;
            dbStudent.ClassLevel = student.ClassLevel;
            dbStudent.Phone_1 = student.Phone_1;
            dbStudent.Phone_2 = student.Phone_2;
            dbStudent.Email1 = student.Email1;
            dbStudent.Email2 = student.Email2;
            dbStudent.HomeAlone = student.HomeAlone;
            dbStudent.Remarks = student.Remarks;
            dbStudent.Street1 = student.Street1;
            dbStudent.HouseNumber1 = student.HouseNumber1;
            dbStudent.PostalCode1 = student.PostalCode1;
            dbStudent.District1 = student.District1;

            await _dataContext.SaveChangesAsync();

            return Ok(await GetDbStudents());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<StudentModel>>> DeleteStudent( int id)
        {
            var dbStudent = await _dataContext.Students.FirstOrDefaultAsync(student => student.Id == id);

            if (dbStudent == null)
            {
                return NotFound("Geen student gevonden.");
            }

            _dataContext.Students.Remove(dbStudent);
            await _dataContext.SaveChangesAsync();

            return Ok(await GetDbStudents());
        }


        private async Task<List<StudentModel>> GetDbStudents()
        {
            return await _dataContext.Students.ToListAsync();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using ArangaliITELEC1C.Models;

namespace ArangaliITELEC1C.Controllers;

    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>()
        {
            new Instructor()

            {   Id = 1,
                InstructorFirstName = "Jasper Lindell",
                InstructorLastName = "Arangali",
                DateHired = DateTime.Now,
                InstructorIsTenured = true,
                Rank = Rank.Instructor
            },
            new Instructor()
            {
                Id = 2,
                InstructorFirstName = "Gabriel",
                InstructorLastName = "Montano",
                DateHired = DateTime.Parse("02/09/2019"),
                InstructorIsTenured = true,
                Rank = Rank.AssociateProfessor
            },
            new Instructor()
            {
                Id = 3,
                InstructorFirstName = "Marcus Andre",
                InstructorLastName = "Caronongan",
                DateHired = DateTime.Parse("09/20/2003"),
                InstructorIsTenured = false,
                Rank = Rank.Professor
            }
        };
        public IActionResult Index()
        {
            return View(InstructorList);
        }

    public IActionResult ShowDetail(int id)
    {
        //Search for the student whose id matches the given id
        Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

        if (instructor != null)//was an instructor found?
            return View(instructor);

        return NotFound();
    }
}

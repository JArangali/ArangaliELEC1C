using Microsoft.AspNetCore.Mvc;
using ArangaliITELEC1C.Models;

namespace ArangaliITELEC1C.Controllers;

public class StudentController : Controller
{

    public IActionResult Index()
    {
        Student st = new Student();
        st.StudentId = 1;
        st.StudentName = "Jasper Lindell Arangali";
        st.DateEnrolled = DateTime.Parse("8/30/2023");
        st.Course = Course.BSIT;
        st.Email = "jasperlindell.arangali.cics@ust.edu.ph";

        ViewBag.student = st;

        return View();
    }

    public IActionResult Error()
    {
        return View();
    }
}


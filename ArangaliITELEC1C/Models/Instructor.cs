using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace ArangaliITELEC1C.Models;

public enum Rank
{ 
    Instructor, AsstistantProfessor, Professor, AssociateProfessor,
}

public class Instructor
{
    public int Id { get; set; }

    [Required(ErrorMessage = "No First Name")]
    [Display(Name = "First Name")]
    public string InstructorFirstName { get; set; }

    [Required(ErrorMessage = "No Last Name")]
    [Display(Name = "Last Name")]
    public string InstructorLastName { get; set; }

    [Display(Name = "Tenured")]
    public bool InstructorIsTenured { get; set; }

    [Display(Name = "Date Hired")]
    [DataType(DataType.Date)]
    public DateTime DateHired { get; set; }

    [Display(Name = "Academic Rank")]
    public Rank Rank { get; set; }
}


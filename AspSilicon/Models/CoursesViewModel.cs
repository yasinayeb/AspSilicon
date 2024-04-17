using Infrastructure.Models;

namespace AspSilicon.Models;

public class CoursesViewModel
{
    public IEnumerable<Category>? Categories { get; set; }
    public IEnumerable<Course>? Courses { get; set; }
    
}

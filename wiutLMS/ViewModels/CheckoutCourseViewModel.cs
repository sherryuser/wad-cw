using Microsoft.AspNetCore.Mvc;

namespace wiutLMS.ViewModels
{
    public class CheckoutCourseViewModel
    {
        [HiddenInput] public bool Sure { get; set; } = true;
        [HiddenInput] public int CourseId { get; set; }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace wiutLMS.ViewModels
{
    public class UpdateLectureViewModel
    {
        [HiddenInput] public int LectureId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public IFormFile Attachment { get; set; }
        public string AttachmentDesc { get; set; }
        [HiddenInput] public int CourseId { get; set; }
    }
}
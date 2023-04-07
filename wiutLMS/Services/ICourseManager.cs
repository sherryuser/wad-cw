using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using wiutLMS.Models;
using wiutLMS.ViewModels;

namespace wiutLMS.Services
{
    public interface ICourseManager
    {
        List<Course> GetCourses(int skip = 0, int count = 10, bool includes = false);
        List<Course> GetTeacherCourses(string userid);
        List<StudentCourse> GetStudentCourses(string userid);
        Course GetCourse(int id);
        List<Lecture> GetLectures(Course course);
        Lecture GetLecture(int lecId);
        int CreateCourse(CourseViewModel course, Person teacher);
        int CreateLecture(LectureViewModel lecture);
        int CreateLecture(LectureViewModel lecture, Course course);
        void UpdateLecture(UpdateLectureViewModel updatedlecture);

        string SaveFile(IFormFile file);

        void RemoveFile(string path);
        void RemoveLecture(Lecture lec);
        void RemoveCourse(Course course);
        void CheckoutCourse(int courseId, Person student);
        void CheckoutCourse(Course c, Person student);
    }
}
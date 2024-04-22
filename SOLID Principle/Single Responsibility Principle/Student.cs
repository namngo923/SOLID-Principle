using System.Text.Json;
using System.Text.Json.Serialization;

namespace SOLID_Principle.Entity
{
    public class StudentBefore
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Format class này dưới dạng text, html, json để in ra
        public string GetStudentInfoText()
        {
            return "Name: " + Name + ". Age: " + Age;
        }
        public string GetStudentInfoHTML()
        {
            return "<span>" + Name + " " + Age + "</span>";
        }
        public string GetStudentInfoJson()
        {
            return JsonSerializer.Serialize(this);
        }
        // Lưu trữ xuống database, xuống file
        public void SaveToDatabase()
        {
            //dbContext.Save(this);
        }
        public void SaveToFile()
        {
            //Files.Save(this, "fileName.txt");
        }
    }
    //SRP After Single Responsibility Principle

    //class khai báo thuộc tính riêng
    public class StudentAfter
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    // clas riêng để hàm fomat
    public class Formatter
    {
        public string FormatStudentText(StudentAfter std)
        {
            return "Name: " + std.Name + ". Age: " + std.Age;
        }
        public string FormatStudentHtml(StudentAfter std)
        {
            return "<span>" + std.Name + " " + std.Age + "</span>";
        }
        public string FormatStudentJson(StudentAfter std)
        {
            return JsonSerializer.Serialize(std);
        }
    }

    // Class này chỉ lo việc lưu trữ
    public class Store
    {
        public void SaveToDatabase(StudentAfter std)
        {
            //dbContext.Save(std);
        }
        public void SaveToFile(StudentAfter std)
        {
            //Files.Save(std, "fileName.txt");
        }
    }
}

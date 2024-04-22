﻿using System.Text.Json;
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

    public class StudentAfter
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Formatter
    {
        public string FormatStudentText
    }
}

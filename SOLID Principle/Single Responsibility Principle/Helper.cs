using System.Data.Common;

namespace SOLID_Principle.SRP
{
    //Before Single Responsibility Principle
    public class Helper
    {
        public string GetUser()
        {
            return "Name";
        }

        public DateTime GetTime()
        {
            return DateTime.Now;
        }
        public string GetCurrentLocation()
        {
            return "Location";
        }
        //public DbConnection GetDatabaseConnection();
    }


    //After Single Responsibility Principle

    // Tách helper thành các helper nhỏ hơn
    public class UserHelper
    {
    }
    public class TimeLocationHelper
    {
    }
    public class DatabaseHelper
    {
    }
}

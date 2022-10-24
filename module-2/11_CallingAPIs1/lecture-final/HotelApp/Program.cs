namespace HotelApp
{
    public class Program
    {
        public static void Main()
        {
            string apiUrl = "http://localhost:3000/";
            HotelApp app = new HotelApp(apiUrl);

            app.Run();
        }
    }
}

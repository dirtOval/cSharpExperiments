namespace ThirdCoreWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            string resultString = "default very interesting string";

            ConfigurationManager configuration = builder.Configuration;
            resultString = configuration["AVeryImportantKey"];

            if (app.Environment.IsDevelopment())
            {
                Console.WriteLine("im gay");
            }

            if (Environment.GetEnvironmentVariable("POTATO_EXISTS") == "PotatoExists")
            {
                Console.WriteLine("oh my god you guys potato exists oh fuck oh shit");
                Console.WriteLine("fuckkkkkk");
            }

            app.MapGet("/", () => resultString);
            app.MapGet("/potato", () => "i hate myself lol");

            app.Run();
        }
    }
}
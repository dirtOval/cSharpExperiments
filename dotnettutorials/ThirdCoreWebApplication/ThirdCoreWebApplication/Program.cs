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
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync(resultString);
            //    });
            //    endpoints.MapGet("/potato", async context =>
            //    {
            //        await context.Response.WriteAsync("potatopotatopotatopotato");
            //    });
            //    endpoints.Map("/imdying", async context =>
            //    {
            //        Console.WriteLine("im literally dying rn");
            //        await context.Response.WriteAsync("as you can see from the console, i am dying rn");
            //    });
            //});

            if (Environment.GetEnvironmentVariable("POTATO_EXISTS") == "PotatoExists")
            {
                Console.WriteLine("oh my god you guys potato exists oh fuck oh shit");
                Console.WriteLine("fuckkkkkk");
            }

            //app.MapGet("/", () => resultString);
            //app.MapGet("/potato", () => "i hate myself lol");

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Here is the response from the first middleware!\n");
                await next();
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Here is the response from the second middleware");
            });

            app.Run();
        }
    }
}
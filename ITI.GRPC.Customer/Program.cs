namespace ITI.GRPC.Customer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();               
                app.UseSwaggerUI(c =>  {     
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");   
                    c.RoutePrefix = string.Empty;                 
                });            
            }            
            else            
            {                 
                app.UseExceptionHandler("/Home/Error");               
                app.UseHsts();          
            }

            // Configure the HTTP request pipeline.

            //app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();


            //app.MapControllers();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Product}/{action=Index}/{id?}"
            );

            app.Run();
        }
    }
}
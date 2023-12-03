
using Panaroma.Bussiness.Abstract;
using Panaroma.Bussiness.Concrete;
using Panaroma.DataAccess.Abstract;
using Panaroma.DataAccess.Concrete.EntityFramewok;

namespace Panaroma.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IImageDal, EfImageDal>();
            builder.Services.AddScoped<IImageService, ImageManager>();

            builder.Services.AddScoped<ICorporationDal, EfCorporationDal>();
            builder.Services.AddScoped<ICorporationService, CorporationManager>();

            builder.Services.AddScoped<IPlaceDal, EfPlaceDal>();
            builder.Services.AddScoped<IPlaceService, PlaceManager>();

            builder.Services.AddScoped<ITeacherDal, EfTeacherDal>();
            builder.Services.AddScoped<ITeacherService, TeacherManager>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
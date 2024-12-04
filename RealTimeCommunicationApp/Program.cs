using Microsoft.EntityFrameworkCore;
using RealTimeCommunicationApp.DAL.DbContexts;
using RealTimeCommunicationApp.DAL.Entities;
using RealTimeCommunicationApp.Services.Implementations;
using RealTimeCommunicationApp.Services.Interfaces;
using System.Xml;

namespace RealTimeCommunicationApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            //setting up the DB
            builder.Services.AddDbContext<ApDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Defaultconnection")));

            //adding DI services 
            builder.Services.AddScoped<IUnitOfWork<User>, UnitOfWork<User>>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();
            app.UseHttpsRedirection();

            app.Run();
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DockerComposeAPI.Models
{
    public static class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
          using (var serviceScope = app.ApplicationServices.CreateScope())
          {
            SeedData(serviceScope.ServiceProvider.GetService<ColorContext>());
          }
        }
        public static void SeedData(ColorContext context)
        {
          System.Console.WriteLine("Appling Migrations ...");
          context.Database.Migrate();
          if (!context.ColorItems.Any())
          {
            System.Console.WriteLine("Adding data - seending ...");
            context.ColorItems.AddRange(
              new Color() {colorName = "Red"},
              new Color() {colorName = "Black"},
              new Color() {colorName = "White"},
              new Color() {colorName = "Blue"},
              new Color() {colorName = "Gray"}
            );
          }
          else
          {
            System.Console.WriteLine("Already have data - not seending ...");
          }
        }
    }
}
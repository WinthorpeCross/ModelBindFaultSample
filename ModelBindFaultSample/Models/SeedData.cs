using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ModelBindFaultSample.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ModelBindFaultSampleContext(
                serviceProvider.GetRequiredService<DbContextOptions<ModelBindFaultSampleContext>>()))
            {
               
                if (context.Bird.Any())
                {
                    return;
                }

                var birds = new Bird[]
                {
                    new Bird { EnglishName="SampleName1",CreationDate=DateTime.Now},
                    new Bird { EnglishName="SampleName2",CreationDate=DateTime.Now},
                    new Bird { EnglishName="SampleName3",CreationDate=DateTime.Now},
                    new Bird { EnglishName="SampleName4",CreationDate=DateTime.Now},
                    new Bird { EnglishName="SampleName5",CreationDate=DateTime.Now},
                    new Bird { EnglishName="SampleName6",CreationDate=DateTime.Now},
                    new Bird { EnglishName="SampleName7",CreationDate=DateTime.Now},
                    new Bird { EnglishName="SampleName8",CreationDate=DateTime.Now},
                    new Bird { EnglishName="SampleName9",CreationDate=DateTime.Now},
                    new Bird { EnglishName="SampleName10",CreationDate=DateTime.Now}
                };

                foreach (Bird b in birds)
                {
                    context.Bird.Add(b);
                }
                context.SaveChanges();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshEF6DbFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            var dbContext = new VidzyDbContext();
            var releaseDateTime = new DateTime(2020, 6, 27);
            dbContext.AddVideo("Video81", releaseDateTime.AddDays(1), 1, (byte) Classification.Platinum);
            Console.WriteLine("Done.");
            Console.ReadKey();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AsNoTrackingTest
{
    class Program
    {
		public async void Main(string[] args)
        {
            var dbContext = new ApplicationContext();
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            var result = await dbContext.Satislar.ToListAsync();
            foreach (var item in result)
            {
                Console.WriteLine($"{item.SatisID}-{item.SevkAdresi}");
            }
            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;
            Console.WriteLine($"Total Süre: {timeSpan.TotalMilliseconds}");
        }
    }
}
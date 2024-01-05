using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

// ReSharper disable UseFormatSpecifierInInterpolation

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvPath = @"/Users/przemyslawkrepski/development/dotnet/udemy/FirstProject/googleplaystore1.csv";
            var googleApps = LoadGoogleAps(csvPath);

            // Display(googleApps);
            // GetData(googleApps);
            // ProjectData(googleApps);
            DivideData(googleApps);
        }
// divide data
        static void DivideData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where(e => e.Rating > 4.6 && e.Category == Category.BEAUTY);
            var firstFiveHighRatedBeautyApps = highRatedBeautyApps.TakeWhile( app => app.Reviews > 1000 );

            var skippedResults = highRatedBeautyApps.Skip(5);
            
            Display(firstFiveHighRatedBeautyApps);
        }

        // project datas

        static void ProjectData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where(e => e.Rating > 4.6 && e.Category == Category.BEAUTY);
            var highRatedBeautyAppsNames = highRatedBeautyApps.Select(app => app.Name);
           
             var dtos = highRatedBeautyApps.Select(app => new GoogleAppDto()
            {
                Reviews = app.Reviews,
                Name = app.Name
            });
             
            var anonymousDtos = highRatedBeautyApps.Select(app => new 
            {
                Reviews = app.Reviews,
                Name = app.Name
            });

            foreach (var dto in anonymousDtos)
            {
                Console.WriteLine($"{dto.Name} : {dto.Reviews}");    
            }

            // var genres = highRatedBeautyApps.SelectMany(app => app.Genres);
            // Console.WriteLine(string.Join(": ", genres));


            // Console.WriteLine(string.Join(", ", highRatedBeautyAppsNames));
        }
        
        // downloading/fetching datas
        static void GetData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where(e => e.Rating > 4.6 && e.Category == Category.BEAUTY);
            Display(highRatedBeautyApps);
            var firstHighRatedBeautyApp = highRatedBeautyApps.FirstOrDefault(e => e.Reviews == 900);
            var singleHighRatedBeautyApp = highRatedBeautyApps.SingleOrDefault(e => e.Reviews == 900); // throw exception where is more than one element
            var lastHighRatedBeautyApp = highRatedBeautyApps.LastOrDefault(e => e.Reviews == 900); // throw exception where is more than one element
            Console.WriteLine("first- from First");
            Console.WriteLine(firstHighRatedBeautyApp);
        }

        static void Display(IEnumerable<GoogleApp> googleApps)
        {
            foreach (var googleApp in googleApps)
            {
                Console.WriteLine(googleApp);
            }
        }

        static void Display(GoogleApp googleApp)
        {
            Console.WriteLine(googleApp);
        }

        static List<GoogleApp> LoadGoogleAps(string csvPath)
        {
            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<GoogleAppMap>();
                var records = csv.GetRecords<GoogleApp>().ToList();
                return records;
            }
        }
    }
}
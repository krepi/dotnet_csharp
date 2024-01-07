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
            // DivideData(googleApps);
            // OrderData(googleApps);
            // DataSetOperation(googleApps);
            // DataVerification(googleApps);
            GroupData(googleApps);
        }
        
        //gruping data
        static void GroupData(IEnumerable<GoogleApp> googleApps)
        {
            var categoryGroup = googleApps.GroupBy(a => new {a.Category, a.Type});
            // var artAndDesignGroup = categoryGroup.First(g => g.Key == Category.ART_AND_DESIGN);
            // var apps = artAndDesignGroup.ToList();
            foreach (var group in categoryGroup)
            {
                var apps = group.ToList();
                Console.WriteLine($"Displaying elements for group {group.Key.Category} , {group.Key.Type}");
                Display(apps);
            }
            
        }
        
        //data verification

        static void DataVerification(IEnumerable<GoogleApp> googleApps)
        {
            var allOperationResult = googleApps.Where(a => a.Category == Category.WEATHER)
                .All(a=> a.Reviews >10); // True, for a.Reviews > 20 - False
            var anyOperationresulet =
                googleApps.Where(a => a.Category == Category.WEATHER).Any(a => a.Reviews > 2000000); //true

        }
        
        //Data set operation
        static void DataSetOperation(IEnumerable<GoogleApp> googleApps)
        {
            var paidAppsCategories = googleApps.Where(a => a.Type == Type.Paid)
                .Select(a => a.Category).Distinct();
            
            // Console.WriteLine($"Paid apps categories; {string.Join(", ", paidAppsCategories)} ");
            var setA = googleApps.Where(a => a.Rating > 4.7 && a.Type == Type.Paid && a.Reviews > 1000);
            var setB = googleApps.Where(a => a.Name.Contains("Pro") && a.Rating > 4.6 && a.Reviews > 10000);
            
            // Console.WriteLine("================");
            // Display(setA);
            // Console.WriteLine("================");
            // Display(setB);

            var appsUnion = setA.Union(setB);
            Console.WriteLine("========apps Union=======");
            Display(appsUnion); 
            var appsIntersect = setA.Intersect(setB);
            Console.WriteLine("======apps Intersect========");
            Display(appsIntersect);   
            var appsExcept = setA.Except(setB);
            Console.WriteLine("======apps Except========");
            Display(appsExcept);
        }
        
        
        // sort data
        static void OrderData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where(e => e.Rating > 4.4 && e.Category == Category.BEAUTY);
            // var sortedResults = highRatedBeautyApps.OrderBy(app => app.Rating);
            var sortedResults = highRatedBeautyApps
                .OrderByDescending(app => app.Rating)
                .ThenBy(app => app.Name)
                .Take(5);

            Display(sortedResults);
        }
        
        
        
        // divide data
        static void DivideData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where(e => e.Rating > 4.4 && e.Category == Category.BEAUTY);
            var firstFiveHighRatedBeautyApps = highRatedBeautyApps.TakeWhile(app => app.Reviews > 1000);

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
            var singleHighRatedBeautyApp =
                highRatedBeautyApps.SingleOrDefault(e =>
                    e.Reviews == 900); // throw exception where is more than one element
            var lastHighRatedBeautyApp =
                highRatedBeautyApps.LastOrDefault(e =>
                    e.Reviews == 900); // throw exception where is more than one element
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
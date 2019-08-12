using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using LostPeople.DataAccess;
using LostPeople.DataAccess.Entities;
using System.Net;
using static System.Net.WebRequestMethods;

namespace LostPeople.JsonSerializer
{
    

    class Program
    {
        static void Main(string[] args)
        {

            //using (var wc = new WebClient())
            //{
            //    string Lost = "https://data.gov.ua/dataset/8851831d-b5ce-4ca8-8685-eafbc3f57eca/resource/6cfff17e-84ac-4141-b0fd-89abb68e9f31/download/mvswantedbezvesti_1.json";
            //    string fileLost = "lost.json";

            //    wc.DownloadFile(Lost, fileLost);

            //    string LostPhoto = "https://data.gov.ua/dataset/8851831d-b5ce-4ca8-8685-eafbc3f57eca/resource/af43a159-f139-4e0e-bc72-39270416667c/download/mvswantedbezvesti_photo.json";
            //    string filePhoto = "lost_photo.json";

            //    wc.DownloadFile(LostPhoto, filePhoto);

            //}

            

            //using (var db = new LostContext())
            //{
                
            //    var LostData = JsonConvert.DeserializeObject<List<LostPerson>>(System.IO.File.ReadAllText(@"C:\Users\User\source\repos\JsonSerializer\JsonSerializer\bin\Debug\lost.json")); 
            //    var losts = db.Lost.AddRange(LostData);

            //    foreach (var data in losts)
            //    {


            //        Console.WriteLine($"Пропавший № {data.Id}");
            //        Console.WriteLine($"{data.LAST_NAME} - {data.FIRST_NAME} - {data.MIDDLE_NAME} ");
            //        Console.WriteLine($"Дата рождения:{data.BIRTH_DATE}, Пол:{data.SEX}, Район:{data.OVD}");
            //        Console.WriteLine($"Дата исчезновения:{data.LOST_DATE}, Место исчезновения:{data.OVD} ");
            //        Console.WriteLine(" ");

            //        db.SaveChanges();
            //    }
            //}

            using (var db = new LostContext())
            {
                var LostDataPhoto = JsonConvert.DeserializeObject<List<LostPersonPhoto>>(System.IO.File.ReadAllText(@"C:\Users\User\source\repos\JsonSerializer\JsonSerializer\bin\Debug\lost_photo.json"));

                var losts = db.Photos.AddRange(LostDataPhoto);

                foreach (var data in losts)
                {
                    Console.WriteLine($"photo:{data.PhotoId}");
                    db.SaveChanges();
                }

            }






            Console.ReadLine();
        }
    }
}

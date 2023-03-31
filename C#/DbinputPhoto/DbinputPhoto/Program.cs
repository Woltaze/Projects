using System;
using DbinputPhoto.Entities;

namespace DbinputPhoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory() + "\\moto\\";  
        
            string[] files = Directory.GetFiles(path);

            using (Db db = new Db())
            {
                foreach (var motorcycle in db.Motorcycles)
                {
                    string pathofmotorcycle = files.First(x => x.Contains(motorcycle.ModelName));  
                    var byteImage = File.ReadAllBytes(pathofmotorcycle);

                    motorcycle.Image = byteImage;
                }
                db.SaveChanges();
            }
        }
    }
}
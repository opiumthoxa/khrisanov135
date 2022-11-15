using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SerializeBasic
{

    public class Uvolnenie
    {
        public int NomerZayavlenia { get; set; }
        public string Prichina { get; set; }

        public Sotrudniks Id { get; set; }

        public Uvolnenie() { }

        public Uvolnenie(int nomerZayavlenia, string prichina, Sotrudniks id)
        {
            Id = id;
            NomerZayavlenia = nomerZayavlenia;
            Prichina = prichina;
        }
    }
    public class Sotrudniks
    {
        public int SotrudnikId { get; set; }
        public string FIO { get; set; }
        public string Doljnost { get; set; }
        public string Age { get; set; }

        public Sotrudniks() { }

        public Sotrudniks(int sotrudnikId, string fio, string doljnost, string age)
        {
            SotrudnikId = sotrudnikId;
            FIO = fio;
            Doljnost = doljnost;
            Age = age;
        }
    }
    public class JsonHandler<T> where T : class
    {
        private string fileName;
        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };


        public JsonHandler() { }

        public JsonHandler(string fileName)
        {
            this.fileName = fileName;
        }


        public void SetFileName(string fileName)
        {
            this.fileName = fileName;
        }

        public void Write(List<T> list)
        {
            string jsonString = JsonSerializer.Serialize(list, options);

            if (new FileInfo(fileName).Length == 0)
            {
                File.WriteAllText(fileName, jsonString);
            }
            else
            {
                Console.WriteLine("Specified path file is not empty");
            }
        }

        public void Delete()
        {
            File.WriteAllText(fileName, string.Empty);
        }

        public void Rewrite(List<T> list)
        {
            string jsonString = JsonSerializer.Serialize(list, options);

            File.WriteAllText(fileName, jsonString);
        }

        public void Read(ref List<T> list)
        {
            if (File.Exists(fileName))
            {
                if (new FileInfo(fileName).Length != 0)
                {
                    string jsonString = File.ReadAllText(fileName);
                    list = JsonSerializer.Deserialize<List<T>>(jsonString);
                }
                else
                {
                    Console.WriteLine("Specified path file is empty");
                }
            }
        }

        public void OutputJsonContents()
        {
            string jsonString = File.ReadAllText(fileName);

            Console.WriteLine(jsonString);
        }

        public void OutputSerializedList(List<T> list)
        {
            Console.WriteLine(JsonSerializer.Serialize(list, options));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Uvolnenie> partsList = new List<Uvolnenie>();

            JsonHandler<Uvolnenie> partsHandler = new JsonHandler<Uvolnenie>("partsFile.json");

            partsList.Add(new Uvolnenie(111, "Opozdanie", new Sotrudniks(1, "Krivosheev Mihail", "Uborshik", "45")));
            partsList.Add(new Uvolnenie(222, "SmenaRaboti", new Sotrudniks(2, "Kirsanov Nikita", "Buhgalter", "24")));
            partsList.Add(new Uvolnenie(333, "SostoyanieZdorovya", new Sotrudniks(3,"Veselov Alexey", "Sekretar", "30")));
            partsList.Remove(new Uvolnenie(222, "SmenaRaboti", new Sotrudniks(2, "Kirsanov Nikita", "Buhgalter", "24")));
           

            partsHandler.Rewrite(partsList);
            partsHandler.OutputJsonContents();
        }
       
        }

}


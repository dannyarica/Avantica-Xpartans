using Newtonsoft.Json;
using System;

namespace JsonSerializableDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var triangle = new Triangle();
            var jsonSettings = new JsonSerializerSettings() { ContractResolver = new DrxpendableContractResolver() };
            var jsonTriangle = JsonConvert.SerializeObject(triangle, jsonSettings);
            Console.WriteLine("Triangle => " + jsonTriangle);

            var rectangle = new Rectangle();
            rectangle.Pesantito = new Jaime() { JuegaPixanga = false, JuegaVoley = true };
            var jsonRectangle = JsonConvert.SerializeObject(rectangle, jsonSettings);
            Console.WriteLine("Rectangle => " + jsonRectangle);

            Console.ReadKey();
        }
    }
}
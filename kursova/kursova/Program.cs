using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace kursova
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
    public class User__data
    {
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
    };
    public static class CurrentSession
    {
        public static User__data CurrentUser { get; set; }
    }
    public class Estate__data
    {
        public string Seller__Name { get; set; }
        public string Seller__Surname { get; set; }
        public string Type_estate { get; set; }
        public string Rent_sell { get; set; }
        public string Distric { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }
        public double Area { get; set; }
        public int Rooms { get; set; }


    }
    public class data__manager
    {
        public static void user__save(List<User__data> list)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(list, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText("user.json", json);
        }
        public static List<User__data> user__load()
        {
            if (!System.IO.File.Exists("user.json")) return new List<User__data>();
            string json = System.IO.File.ReadAllText("user.json");
            return System.Text.Json.JsonSerializer.Deserialize<List<User__data>>(json) ?? new List<User__data>();
        }

        public static void estate__save(List<Estate__data> list)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(list, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText("estate.json", json);
        }

        public static List<Estate__data> estate__load()
        {
            if (!System.IO.File.Exists("estate.json")) return new List<Estate__data>();
            string json = System.IO.File.ReadAllText("estate.json");
            return System.Text.Json.JsonSerializer.Deserialize<List<Estate__data>>(json) ?? new List<Estate__data>();
        }
    }
}
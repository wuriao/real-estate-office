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
    public class Real_estate
    {
        public double Price { get; set; }
        public int Rooms { get; set; }
        public double Area { get; set; }
    }
    public class User
    {
        public string Surname { get; set; }
        public string userName { get; set; }
        public string Role { get; set; }
    }
}
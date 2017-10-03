namespace _02.ValidateURL
{
    using System;
    using System.Net;

    public class Program
    {
        public static void Main()
        {
            var url = Console.ReadLine();
            var decodedUrl = WebUtility.UrlDecode(url);
            
            var pasedUrl = new Uri(decodedUrl);

            if ((pasedUrl.Scheme=="http" && pasedUrl.Port!= 443) ||
                (pasedUrl.Scheme == "https" && pasedUrl.Port != 80))
            {
                Console.WriteLine($"Protocol: {pasedUrl.Scheme}");
                Console.WriteLine($"Host: {pasedUrl.Host}");
                Console.WriteLine($"Port: {pasedUrl.Port}");
                Console.WriteLine($"Path: {pasedUrl.AbsolutePath}");
                if (pasedUrl.Query != "")
                {
                    Console.WriteLine($"Query: {pasedUrl.Query}");
                }
                if (pasedUrl.Fragment != "")
                {
                    Console.WriteLine($"Fragment: {pasedUrl.Fragment}");
                }
            }
            else
            {

                Console.WriteLine("Invalid URL");
            }
           
            
            
        }
    }
}

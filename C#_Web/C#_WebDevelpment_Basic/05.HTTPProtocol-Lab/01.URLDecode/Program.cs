using System;
using System.Net;

namespace _01.URLDecode
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var decodedUrl = WebUtility.UrlDecode(input);
            Console.WriteLine(decodedUrl);
        }
    }
}

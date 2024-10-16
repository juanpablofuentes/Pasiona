﻿using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Enlaces
{
    class Program
    {
        static void Main(string[] args)
        {
            String site = "https://elpais.com/";
            String folder = @"C:\Users\incid\OneDrive\Imágenes\descargas\";
            using (WebClient client = new WebClient())
            {
                string s = client.DownloadString(site);
                Regex r = new Regex(@"<img.*?src=(""|')(?<imagen>.*?)(""|').*?>");
        //      Regex r = new Regex(@"<a.*?href=(""|')(?<href>.*?)(""|').*?>(?<value>.*?)</a>");

                foreach (Match match in r.Matches(s))
                {
                   // Console.WriteLine(match.Groups["href"].Value+" | "+match.Groups["value"].Value);
                    Console.WriteLine(match.Groups["imagen"].Value);
                    try { 
                    client.DownloadFile(match.Groups["imagen"].Value, folder + Path.GetFileName(match.Groups["imagen"].Value));
                    } catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message+" | "+ match.Groups["imagen"].Value);
                    }
                }
                    
            }
        }
    }
}

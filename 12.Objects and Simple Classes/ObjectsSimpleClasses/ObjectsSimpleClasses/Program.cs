using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsSimpleClasses
{
    class Program
    {
        public static void Main()
        {
            var goshoBirthday = new DateTime(1999, 11, 30);
            var anothrDate = new DateTime(1995, 4, 3);
            var diff = goshoBirthday - anothrDate;


            var nowDateTime = DateTime.Now;
            // c# datetime format msdn
            Console.WriteLine(nowDateTime.ToString("dd-MM-yyyy"));
            Console.WriteLine("{0:yyyy}",nowDateTime);

            var webClient = new WebClient();
            //webClient.DownloadFile("https://softuni.bg/downloads/svn/soft-tech/Jan-2017/Programming-Fundamentals-Extended-Jan-2017/12.%20Programming-Fundamentals-Objects-and-Simple-Classes/12.%20Programming-Fundamentals-Objects-and-Simple-Classes.pptx"
                //, "presentation.pptx");
            Process.Start("C:/Users/Svetlin/AppData/Roaming/Spotify/Spotify.exe");
        }
    }
}

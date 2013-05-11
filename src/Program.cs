using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesLib;

namespace iTunes_Tag_Manager
{
    class Program
    {
        public static string AppName { get { return "iTTManager"; } }
        
        static void Main(string[] args)
        {
            IiTunes app = new iTunesAppClass();

            IITTrack track = app.CurrentTrack;

            Console.WriteLine(
                string.Format("Current Track: {0} - {1}", 
                    track.Name,
                    track.Artist));

            Console.WriteLine(string.Format("Comments:\n{0}", track.Comment));

            //track.Comment += "\r\nTEST";

            Console.ReadKey();
        }
    }
}

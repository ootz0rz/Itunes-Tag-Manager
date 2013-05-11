using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunes_Tag_Manager
{
    public class CommentParser
    {
        public static int ParserVersion { get { return 1; } }

        public static string CommentDataPre { get { return dataPre; } }
        public static string CommentDataPost { get { return dataPost; } }

        protected static string dataPre = "//DO NOT EDIT THIS LINE OR BELOW\r\n[[start]]";
        protected static string dataPost = "[[end]]\r\n//DO NOT EDIT THIS LINE OR ABOVE";

        public CommentData CommentData { get; set; }

        public CommentParser(string comment)
        {
            // take the comment, find the json data if any, and create an
            // instance of CommentData for it
        }

        /// <summary>
        /// Save any changes made to CommentData back to the song
        /// </summary>
        public void Save()
        {
            
        }
    }
}

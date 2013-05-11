using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunes_Tag_Manager
{
    class CommentParser
    {
        public static int ParserVersion { get { return 1; } }
        public CommentData CommentData { get; set; }

        protected string dataPre = "[[start]]";
        protected string dataPost = "[[end]]";

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

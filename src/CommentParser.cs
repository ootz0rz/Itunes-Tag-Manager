using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace iTunes_Tag_Manager
{
    public class CommentParser
    {
        public static int ParserVersion { get { return 1; } }

        /// <summary>
        /// The string of text before the main data
        /// </summary>
        public static string CommentDataPreKeyString { get { return dataPre; } }

        /// <summary>
        /// The string of text after the main data
        /// </summary>
        public static string CommentDataPostKeyString { get { return dataPost; } }

        /// <summary>
        /// The string of text before the main data
        /// </summary>
        protected static string dataPre = "//DO NOT EDIT THIS LINE OR BELOW\r\n[[start]]";

        /// <summary>
        /// The string of text after the main data
        /// </summary>
        protected static string dataPost = "[[end]]\r\n//DO NOT EDIT THIS LINE OR ABOVE";

        /// <summary>
        /// Processed comment data
        /// </summary>
        public CommentData CommentData { get { return _commentData; } set { _commentData = value; } }

        /// <summary>
        /// Processed comment data
        /// </summary>
        protected CommentData _commentData = null;

        /// <summary>
        /// The string of text before CommentDataPreKeyString
        /// </summary>
        public string PreData { get { return _preData; } }

        /// <summary>
        /// The string of text before CommentDataPostKeyString
        /// </summary>
        public string PostData { get { return _postData; } }

        /// <summary>
        /// The string of JSON text found, if any
        /// </summary>
        public string JsonString { get { return _jsonString; } }

        /// <summary>
        /// Comment string before dataPre, if any
        /// </summary>
        protected string _preData = "";

        /// <summary>
        /// Comment string after dataPost, if any
        /// </summary>
        protected string _postData = "";

        /// <summary>
        /// The actual JSON string found
        /// </summary>
        protected string _jsonString = "";

        /// <summary>
        /// take the comment, find the json data if any, and create an instance
        /// of CommentData for it
        /// </summary>
        /// <param name="comment"></param>
        public CommentParser(string comment)
        {
            if (comment.Length == 0)
            {
                _commentData = new CommentData();
            }
            else
            {
                int startPre = comment.IndexOf(CommentDataPreKeyString);
                int startPost = comment.IndexOf(CommentDataPostKeyString);

                if (startPre == -1 || startPost == -1)
                {
                    _preData = comment;
                    _commentData = new CommentData();
                }
                else
                {
                    _preData = comment.Substring(0, startPre);
                    _postData = comment.Substring(startPost + CommentDataPostKeyString.Length);
                    _jsonString = comment.Substring(
                        startPre + CommentDataPreKeyString.Length
                        , startPost - (startPre + CommentDataPreKeyString.Length)
                    );

                    _commentData = JsonConvert.DeserializeObject<CommentData>(_jsonString);
                }
            }
        }

        /// <summary>
        /// Save any changes made to CommentData back to the song
        /// </summary>
        public void Save()
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunes_Tag_Manager
{
    public class CommentData
    {
        /// <summary>
        /// Range from [0, 100] inclusive
        /// </summary>
        public int Rating = -1;

        /// <summary>
        /// Tags for this comment
        /// </summary>
        public IEnumerable<string> Tags = new List<string>();
    }
}

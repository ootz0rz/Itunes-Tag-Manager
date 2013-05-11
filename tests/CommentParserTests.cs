using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using iTunes_Tag_Manager;
using Newtonsoft.Json;

namespace tests
{
    [TestClass]
    public class CommentParserTests
    {
        [TestMethod]
        public void Comment_With_Existing_Valid_Data()
        {
            CommentData cd = new CommentData()
            {
                Rating = 100
            };

            string json = JsonConvert.SerializeObject(cd);

            string testComment = string.Format(
                "stuff before\n{0}{1}{2}\nstuff after"
                , CommentParser.CommentDataPre
                , json
                , CommentParser.CommentDataPost
            );

            CommentParser cp = new CommentParser(testComment);

            Assert.Equals(cp.CommentData.Rating, cd.Rating);
        }
    }
}

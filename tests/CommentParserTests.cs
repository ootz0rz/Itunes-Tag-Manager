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

            string pre = "stuff before\n";
            string post = "\nstuff after";

            string testComment = string.Format("{0}{1}{2}{3}{4}", pre, CommentParser.CommentDataPreKeyString, json, CommentParser.CommentDataPostKeyString, post);

            Console.WriteLine("TEST DATA:");
            Console.WriteLine(string.Format("JSON:" + Environment.NewLine + "{0}", json));
            Console.WriteLine(string.Format("PRE: {0}", pre));
            Console.WriteLine(string.Format("POST: {0}", post));

            CommentParser cp = new CommentParser(testComment);

            Assert.AreEqual(cd.Rating, cp.CommentData.Rating);
            Assert.AreEqual(pre, cp.PreData);
            Assert.AreEqual(post, cp.PostData);
            Assert.AreEqual(json, cp.JsonString);
            Assert.AreEqual(pre + CommentParser.CommentDataPreKeyString + json + CommentParser.CommentDataPostKeyString + post, cp.ToString());

            Console.WriteLine(Environment.NewLine + Environment.NewLine + "ACTUAL DATA:");
            Console.WriteLine(string.Format("JSON:" + Environment.NewLine + "{0}", cp.JsonString));
            Console.WriteLine(string.Format("PRE: {0}", cp.PreData));
            Console.WriteLine(string.Format("POST: {0}", cp.PostData));
        }

        [TestMethod]
        public void Comment_With_Existing_Valid_Data_No_Pre()
        {
            CommentData cd = new CommentData()
            {
                Rating = 100
            };

            string json = JsonConvert.SerializeObject(cd);

            string pre = "";
            string post = "\nstuff after";

            string testComment = string.Format("{0}{1}{2}{3}{4}", pre, CommentParser.CommentDataPreKeyString, json, CommentParser.CommentDataPostKeyString, post);

            Console.WriteLine("TEST DATA:");
            Console.WriteLine(string.Format("JSON:" + Environment.NewLine + "{0}", json));
            Console.WriteLine(string.Format("PRE: {0}", pre));
            Console.WriteLine(string.Format("POST: {0}", post));

            CommentParser cp = new CommentParser(testComment);

            Assert.AreEqual(cd.Rating, cp.CommentData.Rating);
            Assert.AreEqual(pre, cp.PreData);
            Assert.AreEqual(post, cp.PostData);
            Assert.AreEqual(json, cp.JsonString);
            Assert.AreEqual(pre + CommentParser.CommentDataPreKeyString + json + CommentParser.CommentDataPostKeyString + post, cp.ToString());

            Console.WriteLine(Environment.NewLine + Environment.NewLine + "ACTUAL DATA:");
            Console.WriteLine(string.Format("JSON:" + Environment.NewLine + "{0}", cp.JsonString));
            Console.WriteLine(string.Format("PRE: {0}", cp.PreData));
            Console.WriteLine(string.Format("POST: {0}", cp.PostData));
        }

        [TestMethod]
        public void Comment_With_Existing_Valid_Data_No_Post()
        {
            CommentData cd = new CommentData()
            {
                Rating = 100
            };

            string json = JsonConvert.SerializeObject(cd);

            string pre = "stuff before\n";
            string post = "";

            string testComment = string.Format("{0}{1}{2}{3}{4}", pre, CommentParser.CommentDataPreKeyString, json, CommentParser.CommentDataPostKeyString, post);

            Console.WriteLine("TEST DATA:");
            Console.WriteLine(string.Format("JSON:" + Environment.NewLine + "{0}", json));
            Console.WriteLine(string.Format("PRE: {0}", pre));
            Console.WriteLine(string.Format("POST: {0}", post));

            CommentParser cp = new CommentParser(testComment);

            Assert.AreEqual(cd.Rating, cp.CommentData.Rating);
            Assert.AreEqual(pre, cp.PreData);
            Assert.AreEqual(post, cp.PostData);
            Assert.AreEqual(json, cp.JsonString);
            Assert.AreEqual(pre + CommentParser.CommentDataPreKeyString + json + CommentParser.CommentDataPostKeyString + post, cp.ToString());

            Console.WriteLine(Environment.NewLine + Environment.NewLine + "ACTUAL DATA:");
            Console.WriteLine(string.Format("JSON:" + Environment.NewLine + "{0}", cp.JsonString));
            Console.WriteLine(string.Format("PRE: {0}", cp.PreData));
            Console.WriteLine(string.Format("POST: {0}", cp.PostData));
        }

        [TestMethod]
        public void Comment_With_Existing_Valid_Data_No_PrePost()
        {
            CommentData cd = new CommentData()
            {
                Rating = 100
            };

            string json = JsonConvert.SerializeObject(cd);

            string pre = "";
            string post = "";

            string testComment = string.Format("{0}{1}{2}{3}{4}", pre, CommentParser.CommentDataPreKeyString, json, CommentParser.CommentDataPostKeyString, post);

            Console.WriteLine("TEST DATA:");
            Console.WriteLine(string.Format("JSON:" + Environment.NewLine + "{0}", json));
            Console.WriteLine(string.Format("PRE: {0}", pre));
            Console.WriteLine(string.Format("POST: {0}", post));

            CommentParser cp = new CommentParser(testComment);

            Assert.AreEqual(cd.Rating, cp.CommentData.Rating);
            Assert.AreEqual(pre, cp.PreData);
            Assert.AreEqual(post, cp.PostData);
            Assert.AreEqual(json, cp.JsonString);
            Assert.AreEqual(pre + CommentParser.CommentDataPreKeyString + json + CommentParser.CommentDataPostKeyString + post, cp.ToString());

            Console.WriteLine(Environment.NewLine + Environment.NewLine + "ACTUAL DATA:");
            Console.WriteLine(string.Format("JSON:" + Environment.NewLine + "{0}", cp.JsonString));
            Console.WriteLine(string.Format("PRE: {0}", cp.PreData));
            Console.WriteLine(string.Format("POST: {0}", cp.PostData));
        }

        [TestMethod]
        public void Comment_Empty()
        {
            CommentData cd = new CommentData();
            CommentParser cp = new CommentParser("");

            string json = JsonConvert.SerializeObject(cd);
            string pre = "";
            string post = "";

            Assert.AreEqual(cd.Rating, cp.CommentData.Rating);
            Assert.AreEqual(pre, cp.PreData);
            Assert.AreEqual(post, cp.PostData);
            Assert.AreEqual("", cp.JsonString);
            Assert.AreEqual(pre + CommentParser.CommentDataPreKeyString + json + CommentParser.CommentDataPostKeyString + post, cp.ToString());
            Assert.AreEqual(json, cp.JsonString);

            Console.WriteLine(Environment.NewLine + Environment.NewLine + "ACTUAL DATA:");
            Console.WriteLine(string.Format("JSON:" + Environment.NewLine + "{0}", cp.JsonString));
            Console.WriteLine(string.Format("PRE: {0}", cp.PreData));
            Console.WriteLine(string.Format("POST: {0}", cp.PostData));
            Console.WriteLine(string.Format("FINAL COMMENT OUT:" + Environment.NewLine + "{0}", cp.ToString()));
        }

        [TestMethod]
        public void Comment_With_No_JSON_Data()
        {
            string pre = "stuff before\n" + "\nstuff after";
            string post = "";

            string testComment = string.Format("{0}{1}", pre, post);

            Console.WriteLine("TEST DATA:");
            Console.WriteLine(string.Format("PRE: {0}", pre));
            Console.WriteLine(string.Format("POST: {0}", post));

            CommentData cd = new CommentData();
            CommentParser cp = new CommentParser(testComment);

            string json = JsonConvert.SerializeObject(cd);

            Assert.AreEqual(cd.Rating, cp.CommentData.Rating);
            Assert.AreEqual(pre, cp.PreData);
            Assert.AreEqual(post, cp.PostData);
            Assert.AreEqual("", cp.JsonString);
            Assert.AreEqual(pre + CommentParser.CommentDataPreKeyString + json + CommentParser.CommentDataPostKeyString + post, cp.ToString());
            Assert.AreEqual(json, cp.JsonString);

            Console.WriteLine(Environment.NewLine + Environment.NewLine + "ACTUAL DATA:");
            Console.WriteLine(string.Format("JSON:" + Environment.NewLine + "{0}", cp.JsonString));
            Console.WriteLine(string.Format("PRE: {0}", cp.PreData));
            Console.WriteLine(string.Format("POST: {0}", cp.PostData));
            Console.WriteLine(string.Format("FINAL COMMENT OUT:" + Environment.NewLine + "{0}", cp.ToString()));
        }
    }
}

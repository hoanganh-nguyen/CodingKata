//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using FluentAssertions;
//using NUnit.Framework;

//namespace AlgoKatas.Tests.String
//{
//    [TestFixture]
//    public class Bolo
//    {
//        [Test]
//        public void DoTest()
//        {
//            ReverseDateFormat reserver = new ReverseDateFormat();
//            //string dateFormat = "07/25/2013.";
//            //bool tmp = dateFormat.Contains('/');
//            //tmp.Should().BeTrue();

//            //var collection = dateFormat.Split('/');
//            //collection.Length.Should().Be(3);

//            //string reversedDateFormat = System.String.Format("{0}/{1}/{2}",collection[1],collection[0],collection[2]);
//            //reversedDateFormat.Should().Be("25/07/2013");
//            //reserver.IsNumber("Abc").Should().BeFalse();
//            //reserver.IsNumber("123").Should().BeTrue();
//            //reserver.Reverse("07/25/2013").Should().BeEquivalentTo("25/07/2013");
//            //reserver.Reverse("abc").Should().BeEquivalentTo("abc");
//            reserver.Reverse("07/25/2013.").Should().BeEquivalentTo("25/07/2013.");
//            reserver.ChangeDateFormat("Hello world from 07/25/2013.").Should().BeEquivalentTo("Hello world from 25/07/2013.");

//        }

//        public class DateFormatHelper
//        {

//            public string ChangeDateFormat(string paragraph)
//            {
//                var list = paragraph.Split(' ');
//                var result = new List<string>();
//                foreach (var word in list)
//                {
//                    result.Add(Reverse(word));
//                }
//                return System.String.Join(" ", result);
//            }
//            public string Reverse(string original)
//            {
//                if (!original.Contains('/'))
//                    return original;
//                var collections = original.Split('/');
//                if (collections.Length != 3)
//                    return original;
//                if (!IsNumber(collections[0]) || !IsNumber(collections[1]))
//                    return original;
//                if (IsNumber(collections[2]))
//                    return System.String.Format("{0}/{1}/{2}", collections[1], collections[0], collections[2]);
//                if (!collections.Contains("."))
//                    return System.String.Format("{0}/{1}/{2}", collections[1], collections[0], collections[2]);
//                return !IsNumber(collections[2].Remove(collections[2].Length - 1)) ? original : System.String.Format("{0}/{1}/{2}", collections[1], collections[0], collections[2]);
//            }

//            public bool IsNumber(string sNumber)
//            {
//                int n;
//                bool isNumeric = int.TryParse(sNumber, out n);

//                return isNumeric;
//            }
//        }

//    }
//}

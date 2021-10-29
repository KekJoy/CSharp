using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TableParser
{
    [TestFixture]
    public class QuotedFieldTaskTests
    {
        [TestCase("''", 0, "", 2)]
        [TestCase("'a'", 0, "a", 3)]
        public void Test(string line, int startIndex, string expectedValue, int expectedLength)
        {
            var actualToken = QuotedFieldTask.ReadQuotedField(line, startIndex);
            Assert.AreEqual(new Token(expectedValue, startIndex, expectedLength), actualToken);
        }
    }

    class QuotedFieldTask
    {
        public static Token ReadQuotedField(string line, int startIndex)
        {
            string value = null;
            int lenght = 0;
            if (line[startIndex] == line[line.Length - 1])
            {
                value = line.Substring(startIndex + 1, line.Length - 2);
                lenght = value.Length + 2;
            }
            else
            {
                for (int i = startIndex + 1; i < line.Length; i++)
                {
                  if (line[i] == line[startIndex] && line[i-1] != '\\')
                        value = line.Substring(startIndex+1, i - 1);
                  else if (line[i] == line.Length -1)
                        value = line.Substring(startIndex + 1, line[i]);
                }
                lenght = value.Length + 2;
            }
            return new Token(value, startIndex, lenght);
        }
    }
}

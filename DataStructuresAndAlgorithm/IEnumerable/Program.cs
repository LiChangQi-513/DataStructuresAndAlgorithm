using System;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyString = "人工智能";
            //TestReadingFile(keyString);
            Console.WriteLine("---");
            TestStreamReaderEnumerable(keyString);

            Console.ReadLine();
        }

        public static void TestStreamReaderEnumerable(string keyString)
        {
            var menmoryBefore = GC.GetTotalMemory(true);
            IEquatable<String> stringsFound;
            try
            {
                stringsFound =
                    from line in new StreamReaderEnumerable(@"");
            }
            catch
            {

            }
        }
    }
}

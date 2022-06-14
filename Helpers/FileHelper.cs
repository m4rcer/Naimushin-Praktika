using Naimushin.Models;
using Naimushin.Students;
using System.Collections.Generic;

namespace Naimushin.Helpers
{
    public static class FileHelper
    {
        public static IEnumerable<Student> ReadStudentsFromFile(string path)
        {
            var reader = new StudentsReader(path);
            return reader.ReadStudentsFromFile();
        }

        public static void WriteStudentsToFile(string path, IEnumerable<Student> students)
        {
            var writer = new StudentsWriter(path);
            writer.WriteStudentsToFile(students);
        }
    }
}

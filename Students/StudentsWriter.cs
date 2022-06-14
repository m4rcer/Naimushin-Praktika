using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using Naimushin.Models;

namespace Naimushin.Students
{
    public class StudentsWriter
    {
        private readonly StreamWriter _writer;

        public StudentsWriter(string path)
        {
            _writer = new StreamWriter(path, false);
        }

        public void WriteStudentsToFile(IEnumerable<Student> students)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            _writer.WriteLine(JsonSerializer.Serialize(students, options));
            _writer.Close();
        }
    }
}

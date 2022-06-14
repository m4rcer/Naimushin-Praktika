using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Naimushin.Models;

namespace Naimushin.Students
{
    public class StudentsReader
    {
        private readonly StreamReader _reader;

        public StudentsReader(string path)
        {
            _reader = new StreamReader(path);
        }

        public IEnumerable<Student> ReadStudentsFromFile()
        {
            var json = _reader.ReadToEnd();
            IEnumerable<Student> students = JsonSerializer.Deserialize<IEnumerable<Student>>(json);
            _reader.Close();
            return students;
        }
    }
}

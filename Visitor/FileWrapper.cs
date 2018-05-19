using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Visitor
{
    public class FileWrapper
    {
        List<Record> records;
        public FileWrapper(String csvFileName)
        {
            this.records = new List<Record>();
            File.ReadAllLines(csvFileName).ToList().ForEach(line => records.Add(Record.createFromCsvLine(line)));
        }

        public List<Record> Records { get { return records;  } }
    }
}
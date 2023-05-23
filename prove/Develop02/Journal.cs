using System.Collections.Generic;
using System.IO;
using System;

namespace Develop02
{
    ///<summary>
    ///The responsibility of a Journal is to store entries.
    ///<summary>
    
    public class Journal
    {
        public List<Entry> entries;
        public string fileName;

        public Journal()
        {
            entries = new List<Entry>();
        }
        public void AddEntry(Entry entry)
        {
            if (!entries.Contains(entry))
            {
                entries.Add(entry);
            }
        }
        public List<Entry> GetAllEntries()
        {
            return this.entries;
        }
    }
}
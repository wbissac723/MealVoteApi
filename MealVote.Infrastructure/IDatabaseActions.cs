using System;
using System.Collections.Generic;
using System.Text;

namespace MealVote.Infrastructure
{
    public interface IDatabaseActions
    {
        public void InsertRecord<T>(string table, T record);

        public List<T> LoadRecords<T>(string table);

        public T LoadRecordById<T>(string table, Guid id);

        public void InsertOrUpdateRecord<T>(string table, Guid id, T record);

        public void DeleteRecord<T>(string table, Guid id);
    }
}

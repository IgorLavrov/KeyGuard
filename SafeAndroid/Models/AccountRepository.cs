using SafeAndroid.Models;
using SQLite;
using System.Collections.Generic;

namespace SafeAndroid
{
    public class AccountRepository
    {

        SQLiteConnection database;

        public AccountRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Account>();
        }

        public IEnumerable<Account> GetItems()
        {
            return database.Table<Account>().ToList();
        }

        public Account GetItem(int id)
        {
            return database.Get<Account>(id);
        }

        public int Delete(int id)
        {
            return database.Delete<Account>(id);
        }

        public int SaveItem(Account item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
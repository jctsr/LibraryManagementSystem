﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
    public class DataAddBooks
    {
        private string __connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vincenzo Cassano\Documents\Library.mdf;Integrated Security=True;Connect Timeout=30";

        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Author { get; set; }

        public string? Published_Date { get; set; }

        public string? Status { get; set; }

        public string? Image { get; set; }

        public List<DataAddBooks> AddBooksData()
        {
            List<DataAddBooks> ListData = new List<DataAddBooks>();

            using SqlConnection Connect = new(__connect);

            try
            {
                Connect.Open();

                string SelectData = "SELECT * FROM books WHERE date_delete IS NULL";

                using SqlCommand CMD = new(SelectData, Connect);

                SqlDataReader Reader = CMD.ExecuteReader();

                while (Reader.Read())
                {
                    DataAddBooks DataAddBooks = new()
                    {
                        Id = (int)Reader["id"],
                        Title = Reader["title"].ToString(),
                        Author = Reader["author"].ToString(),
                        Published_Date = Reader["published_date"].ToString(),
                        Status = Reader["book_status"].ToString(),
                        Image = Reader["image_path"].ToString(),
                    };

                    ListData.Add(DataAddBooks);
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to Database: " + ex);
            }
            finally
            {
                Connect.Close();
            }

            return ListData;
        }

    }
}

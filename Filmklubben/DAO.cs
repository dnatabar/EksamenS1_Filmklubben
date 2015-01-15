﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Filmklubben
{

    public class DAO
    {
        static Random r = new Random();
        private MySqlConnection connection;
        private string server;
        private string port;
        private string database;
        private string uid;
        private string password;

        //Constructor

        public DAO()
        {
            this.Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            port = "3306";
            database = "filmklubben";
            uid = "root";
            password = "Pa$$w0rd";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Number + ": " + ex.Message);
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Number + ": " + ex.Message);
                return false;
            }
        }

        public List<Member> GetMembers()
        {
            string query = "SELECT * FROM member;";

            List<Member> members = new List<Member>();
            List<List<string>> memberData = this.ExecuteReader(query);

            for (int i = 0; i < memberData[0].Count(); i++)
            {
                members.Add(new Member(Convert.ToInt32(memberData[0][i]), memberData[1][i], memberData[2][i], memberData[3][i], Convert.ToInt32(memberData[4][i]), Convert.ToInt32(memberData[5][i]), memberData[6][i]));
            }

            return members;
        }

        public Member GetMember(int id)
        {
            string query = "SELECT * FROM member WHERE member_id=" + id + ";";

            
            List<List<string>> memberData = this.ExecuteReader(query);

            Member member = new Member(Convert.ToInt32(memberData[0][0]), memberData[1][0], memberData[2][0], memberData[3][0], Convert.ToInt32(memberData[4][0]), Convert.ToInt32(memberData[5][0]), memberData[6][0]);
            

            return member;
        }

        public List<Movie> GetMovies()
        {
            string query = "SELECT * FROM movie;";
            List<List<string>> movieData = this.ExecuteReader(query);
            List<Movie> movies = new List<Movie>();

            for (int i=0;i<movieData[0].Count(); i++)
            {
                movies.Add(new Movie(Convert.ToInt32(movieData[0][i]), movieData[1][i], DateTime.Parse(movieData[2][i]), movieData[3][i], movieData[4][i]));
            }
            return movies;
        }

        public bool UpdateMember(Member m)
        {
            string query = "UPDATE member SET fname='" + m.FName + "', lname='" + m.LName + "', street='" + m.Steet + "', email='" + m.Email + "', postal=" + m.Postal + ", phone=" + m.Phone + " WHERE member_id=" + m.Id + ";";

            if (this.ExecuteNonQuery(query) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateMovie(Movie m)
        {
            string query = "UPDATE movie SET title='" + m.Title + "', description='" + m.Description + "', releasedate='" + m.ReleaseDate.ToString("yyyy-MM-dd") + "', coverurl='"+m.CoverURL+"' WHERE movie_id=" + m.Id + ";";
            if (this.ExecuteNonQuery(query) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteMember(int id)
        {
            string query = "DELETE FROM member WHERE member_id=" + id + ";";

            if (this.ExecuteNonQuery(query) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteMember(Member m)
        {
            return this.DeleteMember(m.Id);
        }

        public bool DeleteMovie(int id)
        {
            string query = "DELETE FROM movie WHERE movie_id=" + id + ";";

            if (this.ExecuteNonQuery(query) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteMovie(Movie m)
        {
            return this.DeleteMovie(m.Id);
        }

        public bool AddMember(Member m)
        {
            string query = "INSERT INTO member(fname, lname, street, postal, phone, email) VALUES('" + m.FName + "', '" + m.LName + "', '" + m.Steet + "', " + m.Postal + ", " + m.Phone + ", '" + m.Email + "');";

            if (this.ExecuteNonQuery(query) > 0)
            {
                return true;
            }
            return false;
        }

        public bool AddMovie(Movie m)
        {
            string query = "INSERT INTO movie(title, releasedate, description, coverurl) VALUES('" + m.Title + "', '" + m.ReleaseDate.ToString("yyyy-MM-dd") + "', '" + m.Description + "', '"+m.CoverURL+"');";

            if (this.ExecuteNonQuery(query) > 0)
            {
                return true;
            }
            return false;
        }

        public List<Entry> GetEntries(int memberId)
        {
            string query = "SELECT * FROM registration WHERE member_id=" + memberId + ";";

            List<Entry> entries = new List<Entry>();
            List<List<string>> entryData = this.ExecuteReader(query);

            for (int i = 0; i < entryData[0].Count(); i++)
            {
                entries.Add(new Entry(Convert.ToInt32(entryData[0][i]), Convert.ToInt32(entryData[1][i]), Convert.ToInt16(entryData[3][i]), Convert.ToInt16(entryData[2][i])));
            }
            

            return entries;
        }

        public List<Entry> GetEntries(Member m)
        {
            return this.GetEntries(m.Id);
        }

        public bool DeleteEntry(Entry e)
        {
            string query = "DELETE FROM registration WHERE movie_id=" + e.MovieId + " AND member_id=" + e.MemberId + ";";

            if (this.ExecuteNonQuery(query) > 0)
            {
                return true;
            }
            return false;
        }

        public bool AddEntry (Entry e)
        {
            string query = "INSERT INTO registration VALUES(" + e.MovieId + ", " + e.MemberId + ", " + e.Priority + ", " + e.Rating + ");";

            if (this.ExecuteNonQuery(query) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateEntry(Entry e)
        {
            string query = "UPDATE registration SET rating=" + e.Rating + ", priority=" + e.Priority + " WHERE movie_id=" + e.MovieId + " AND member_id=" + e.MemberId + ";";
            
            if (this.ExecuteNonQuery(query) > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Executes a MySQL Non Query with error handling
        /// </summary>
        /// <param name="sql">The SQL command to execute.</param>
        /// <returns>int of how many rows there were affected</returns>
        private int ExecuteNonQuery(string sql)
        {
            int rowsAffected = -1;
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                this.CloseConnection();
            }
            return rowsAffected;

        }

        /// <summary>
        /// Executes a MySQL Reader command
        /// </summary>
        /// <param name="sql">The SQL command to execute.</param>
        /// <returns>a List object containing Lists of strings where the first List contains the data for the first row."</returns>
        private List<List<String>> ExecuteReader(string sql)
        {
            List<List<String>> tmplist = new List<List<String>>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    tmplist.Add(new List<String>());
                }
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        tmplist[i].Add(reader[i].ToString());
                    }
                }
                this.CloseConnection();
            }
            return tmplist;
        }

    }
}

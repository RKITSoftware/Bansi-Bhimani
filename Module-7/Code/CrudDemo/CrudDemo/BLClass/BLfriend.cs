using System;
using System.Collections.Generic;
using CrudDemo.Models;
using MySql.Data.MySqlClient;

namespace CrudDemo.BLClass
{/// <summary>
/// This is BL class of Friend controller
/// </summary>
    public class BLfriend
    {
        public static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString;

        /// <summary>
        /// This is selectAll Method
        /// </summary>
        /// <returns>List<Friend></returns>
        public List<Friend> selectAll()
        {
            List<Friend> friends = new List<Friend>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    //open connection
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from friend", conn);

                    //read data
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            friends.Add(new Friend()
                            {
                                id = Convert.ToInt32(reader["id"]),
                                firstname = reader["firstname"].ToString(),
                                lastname = reader["lastname"].ToString(),
                                location = reader["location"].ToString(),
                                salary = Convert.ToInt32(reader["salary"]),
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Can not open connection !");

                }

            }
            return friends;
        }

        /// <summary>
        /// getFriendById Method
        /// </summary>
        /// <param name="id">Id of friend</param>
        /// <returns>Friend</returns>
        public Friend getFriendById(int id)
        {
            Friend friends = new Friend();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    //open connection
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from friend where id = " + id + ";", conn);

                    //read data
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            friends.id = Convert.ToInt32(reader["id"]);
                            friends.firstname = reader["firstname"].ToString();
                            friends.lastname = reader["lastname"].ToString();
                            friends.location = reader["location"].ToString();
                            friends.salary = Convert.ToInt32(reader["salary"]);
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Can not open connection !");

                }
                finally
                {
                    conn.Close();
                }

            }
            return friends;
        }

        /// <summary>
        /// addFriend Method
        /// </summary>
        /// <returns>string</returns>
        public string addFriend(Friend objFriend)
        {
            List<Friend> friends = new List<Friend>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("insert into friend (id,firstname,lastname,location,salary) values('" + objFriend.id + "','" + objFriend.firstname + "','" + objFriend.lastname + "','" + objFriend.location + "','" + objFriend.salary + "';", conn);


                    int effect = cmd.ExecuteNonQuery();
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";


                }
                catch (Exception ex)
                {
                    return "Cannot open connection with error - " + ex.Message;
                }
                finally
                {
                    conn.Close();
                }

            }
        }

        /// <summary>
        /// deleteFriend Method
        /// </summary>
        /// <param name="id">id of friend</param>
        /// <returns>string</returns>
        public string deleteFriend(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("delete from friend where id = " + id, conn);

                    int effect = cmd.ExecuteNonQuery();
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";


                }
                catch (Exception ex)
                {
                    return "Cannot open connection with error - " + ex.Message;
                }
                finally
                {
                    conn.Close();
                }

            }
        }

        //update data
        public string updateFriend(Friend objFriend)
        {
            List<Friend> friends = new List<Friend>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("update countries set firstname = '" + objFriend.firstname + "',lastname = '" + objFriend.lastname + "',location = '" + objFriend.location + "',salary = '" + objFriend.salary + "';", conn);


                    int effect = cmd.ExecuteNonQuery();
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";


                }
                catch (Exception ex)
                {
                    return "Cannot open connection with error - " + ex.Message;
                }
                finally
                {
                    conn.Close();
                }

            }
        }
    }
}
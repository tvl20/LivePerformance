using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.DAL
{
    class BestellingMSSQLrepo : IBestellingRepo
    {
        private string conn = "Data Source=DESKTOP-9K8HK1F;Initial Catalog=LivePerformance;Integrated Security=True";
        private IItemRepo itemRepo;

        public BestellingMSSQLrepo(IItemRepo itemRepo)
        {
            this.itemRepo = itemRepo;
        }
        public void AddKlant(string naam, string adres)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Klanten (Naam, Adres) VALUES (@naam, @adres)", connection))
                {
                    cmd.Connection = connection;
                    cmd.Parameters.Add("@naam", SqlDbType.VarChar).Value = naam;
                    cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = adres;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Klant> GetKlanten()
        {
            List<Klant> returnList = new List<Klant>();

            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Naam, Adres, KlantID FROM Klanten", connection))
                {
                    cmd.Connection = connection;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            returnList.Add(new Klant(reader.GetString(0), reader.GetString(1), reader.GetInt32(2)));
                        }
                    }
                }
            }

            return returnList;
        }

        public List<Bestelling> GetBestellingen()
        {
            List<Bestelling> returnList = new List<Bestelling>();

            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT b.BestellingID, k.Adres, k.Naam, b.KlantID FROM Bestellingen b LEFT JOIN Klanten k ON b.KlantID = k.KlantID", connection))
                {
                    cmd.Connection = connection;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(2))
                            {
                                returnList.Add(new Bestelling()
                                {
                                    ID = reader.GetInt32(0),
                                    Klant = new Klant(reader.GetString(2), reader.GetString(1), reader.GetInt32(3))
                                });
                            }
                            else
                            {
                                returnList.Add(new Bestelling()
                                {
                                    ID = reader.GetInt32(0)
                                });
                            }
                        }
                    }
                }
            }

            foreach (Bestelling bestelling in returnList)
            {
                List<int> pizzaIDs = new List<int>();
                List<int> saladeIDs = new List<int>();
                List<int> drankenIDs = new List<int>();

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT PizzaID FROM PizzaItems WHERE BestellingID = @bestellingID", connection))
                    {
                        cmd.Connection = connection;
                        cmd.Parameters.Add("@bestellingID", SqlDbType.Int).Value = bestelling.ID;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                pizzaIDs.Add(reader.GetInt32(0));
                            }
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT SaladeID FROM SaladeItems WHERE BestellingID = @bestellingID", connection))
                    {
                        cmd.Connection = connection;
                        cmd.Parameters.Add("@bestellingID", SqlDbType.Int).Value = bestelling.ID;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                saladeIDs.Add(reader.GetInt32(0));
                            }
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT DrankID FROM DrankItems WHERE BestellingID = @bestellingID", connection))
                    {
                        cmd.Connection = connection;
                        cmd.Parameters.Add("@bestellingID", SqlDbType.Int).Value = bestelling.ID;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                drankenIDs.Add(reader.GetInt32(0));
                            }
                        }
                    }
                }

                foreach (int id in pizzaIDs)
                {
                    Pizza temp = itemRepo.GetPizzaByID(id);
                    if (temp != null)
                    {
                        bestelling.Items.Add(temp);
                    }
                }

                foreach (int id in saladeIDs)
                {
                    Salade temp = itemRepo.GetSaladeByID(id);
                    if (temp != null)
                    {
                        bestelling.Items.Add(temp);
                    }
                }

                foreach (int id in drankenIDs)
                {
                    Drank temp = itemRepo.GetDrankByID(id);
                    if (temp != null)
                    {
                        bestelling.Items.Add(temp);
                    }
                }
            }

            return returnList;
        }

        public void NewBestelling(Klant klant = null)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Bestellingen (KlantID) VALUES (@klantID)", connection))
                {
                    cmd.Connection = connection;
                    if (klant != null)
                    {
                        cmd.Parameters.Add("klantID", SqlDbType.Int).Value = klant.ID;
                    }
                    else
                    {
                        cmd.Parameters.Add("klantID", SqlDbType.Int).Value = DBNull.Value;
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

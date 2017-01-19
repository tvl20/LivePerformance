using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformance.DAL
{
    public class ItemMSSQLrepo : IItemRepo
    {
        private string conn = "Data Source=DESKTOP-9K8HK1F;Initial Catalog=LivePerformance;Integrated Security=True";
        public List<Ingredient> GetIngredienten()
        {
            List<Ingredient> returnList = new List<Ingredient>();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Naam, IngredientID FROM Ingredienten", connection))
                {
                    cmd.Connection = connection;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            returnList.Add(new Ingredient(reader.GetString(0), reader.GetInt32(1)));
                        }
                    }
                }
            }
            return returnList;
        }

        public List<Pizza> GetPizzas()
        {
            List<Pizza> returnList = new List<Pizza>();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT PizzaID, Oppervlakte FROM Pizzas", connection))
                {
                    cmd.Connection = connection;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            returnList.Add(new Pizza(reader.GetInt32(0), reader.GetInt32(1)));
                        }
                    }
                }
            }

            foreach (Pizza pizza in returnList)
            {
                pizza.Ingredienten = new List<Ingredient>();
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string query = @"SELECT i.Naam, i.InkoopPrijs, i.VerkoopPrijs, i.IngredientID 
                                        FROM Ingredienten i
                                            INNER JOIN PizzaIngredienten p_i ON p_i.IngredientID = i.IngredientID 
                                                WHERE p_i.PizzaID = @pizzaID;";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Connection = connection;
                        cmd.Parameters.Add("@pizzaID", SqlDbType.Int).Value = pizza.ID;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                pizza.Ingredienten.Add(new Ingredient(reader.GetString(0), reader.GetInt32(3)));
                                pizza.InkoopPrijs += reader.GetInt32(1) * pizza.Oppervlakte;
                                pizza.VerkoopPrijs += reader.GetInt32(2) * pizza.Oppervlakte;
                            }
                        }
                    }
                }
            }
            return returnList;
        }

        public List<Salade> GetSalades()
        {
            List<Salade> returnList = new List<Salade>();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT s.Naam, s.InkoopPrijs, s.VerkoopPrijs, s.SaladeID FROM Salades s", connection))
                {
                    cmd.Connection = connection;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            returnList.Add(new Salade(reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3)));
                        }
                    }
                }
            }
            return returnList;
        }

        public List<Drank> GetDranken()
        {
            List<Drank> returnList = new List<Drank>();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT d.Naam, d.InkoopPrijs, d.VerkoopPrijs, d.Alcohol, d.DrankID FROM Dranken d", connection))
                {
                    cmd.Connection = connection;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetInt32(3) == 0)
                            {
                                returnList.Add(new Drank(reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2), false, reader.GetInt32(4)));
                            }
                            else
                            {
                                returnList.Add(new Drank(reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2), true, reader.GetInt32(4)));
                            }
                        }
                    }
                }
            }
            return returnList;
        }

        public Pizza GetPizzaByID(int id)
        {
            List<Pizza> tempList = this.GetPizzas();
            foreach (Pizza pizza in tempList)
            {
                if (pizza.ID == id)
                {
                    return pizza;
                }
            }
            return null;
        }

        public Drank GetDrankByID(int id)
        {
            List<Drank> tempList = this.GetDranken();
            foreach (Drank drank in tempList)
            {
                if (drank.ID == id)
                {
                    return drank;
                }
            }
            return null;
        }

        public Salade GetSaladeByID(int id)
        {
            List<Salade> tempList = this.GetSalades();
            foreach (Salade salade in tempList)
            {
                if (salade.ID == id)
                {
                    return salade;
                }
            }
            return null;
        }
    }
}

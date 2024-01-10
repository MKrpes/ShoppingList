using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingList
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BLogin(object sender, EventArgs e)
        {
            string connStr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["AdoNetConnectionString"].ConnectionString;
            //dodati using System.Data.SqlClient; da bi mogli pristupiti
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand comm = new SqlCommand("SELECT password, fullname FROM Users WHERE username = @username", conn);
            comm.Parameters.AddWithValue("username", TBUsername.Text);
            try
            {
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    //Ponovi hashiranje i vidi da li se lozinke podudaraju
                    string SavedPswrd = dr["password"].ToString();
                    string hashPswrd = Utility.Hash(TBUsername.Text);
                    if (SavedPswrd == hashPswrd)
                    {
                        Session["ime"] = dr["fullname"].ToString();
                        Response.Redirect("MainPage.aspx");
                    }
                    else
                    {
                        label_error.Text = "User not found";
                    }

                }
                else
                {
                    label_error.Text = "User not found";
                }
            }
            catch (Exception ex)
            {
                //log
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
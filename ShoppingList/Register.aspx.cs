using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ShoppingList
{
    public partial class Register : System.Web.UI.Page
    {
        private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AdoNetConnectionString"].ToString());
        private SqlCommand _command;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (!TBUsername.Text.IsNullOrWhiteSpace() && !TBFN.Text.IsNullOrWhiteSpace() && !TBPsw.Text.IsNullOrWhiteSpace() && TBPsw==TBCPsw)
            {
                _connection.Open();
                string hashPassword = Utility.Hash(TBPsw.Text);
                _command = new SqlCommand("INSERT INTO Users(UserName, FullName, Password)VALUES(@UserName, @FullName, @Password)", _connection);
                _command.Parameters.AddWithValue("@UserName", TBUsername.Text);
                _command.Parameters.AddWithValue("@FullName", TBFN.Text);
                _command.Parameters.AddWithValue("@Password", hashPassword);
                _command.ExecuteNonQuery(); // ništa ne vraća
                _connection.Close();
                Response.Redirect("Login.aspx");
            }
        }
    }
}
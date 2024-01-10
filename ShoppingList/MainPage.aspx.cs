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
    public partial class MainPage : System.Web.UI.Page
    {
        private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AdoNetConnectionString"].ToString());
        private SqlCommand _command;
        private SqlDataReader _dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            Display();
        }



        private void Display()
        {
            _connection.Open();
            _command = new SqlCommand("SELECT * FROM Products", _connection);
            _dr = _command.ExecuteReader();
            GVShopList.DataSource = _dr;
            GVShopList.DataBind();
            _dr.Close();
            _connection.Close();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            _connection.Open();
            _command = new SqlCommand("INSERT INTO Products(Name, Description)VALUES(@name, @desc)", _connection);
            _command.Parameters.AddWithValue("@name", TBName.Text);
            _command.Parameters.AddWithValue("@desc", TBDesc.Text);
            _command.ExecuteNonQuery();
            _connection.Close();
            Display();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            _connection.Open();
            _command = new SqlCommand("DELETE FROM Products where Id=@id", _connection);
            _command.Parameters.AddWithValue("@id", TBID.Text);
            _command.ExecuteNonQuery();
            _connection.Close();
            Display();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            _connection.Open();
            _command = new SqlCommand("SELECT * FROM Products WHERE Id=@id", _connection);
            _command.Parameters.AddWithValue("@id", TBID.Text);
            _dr = _command.ExecuteReader();
            GVShopList.DataSource = _dr;
            GVShopList.DataBind();
            _dr.Close();
            _connection.Close();
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            Display();
        }

        protected void btnTotal_Click(object sender, EventArgs e)
        {
            _connection.Open();
            _command = new SqlCommand("SELECT COUNT(*) FROM Products", _connection);
            int total = (int)_command.ExecuteScalar(); 
            lblTotal.Text = "Total Record:--> " + total.ToString();
            _connection.Close();
        }
    }
}
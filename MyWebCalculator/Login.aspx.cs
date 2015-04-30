using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void loginControl_Authenticate(object sender, AuthenticateEventArgs e)
    {
        string userName = loginControl.UserName;
        string password = loginControl.Password;

        StringBuilder sql = new StringBuilder();

        sql.AppendLine("SELECT UserID FROM UserPassword ");
        sql.AppendLine("WHERE UserName = @Name AND UserPassword = @Pass ");

        using (SqlConnection conn = new SqlConnection(UserPasswordConnectionString))
        {
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar);
            cmd.Parameters["@name"].Value = userName;

            cmd.Parameters.Add("@Pass", SqlDbType.NVarChar);
            cmd.Parameters["@pass"].Value = password;

            try
            {
                conn.Open();
                int userId = (Int32)cmd.ExecuteScalar();
                if (userId != null && userId > 0)
                {
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    loginControl.FailureText = "Unable to authenticate the user";
                }

            }
            catch (Exception ex)
            {
                loginControl.FailureText = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }


    }


    private static string _UserPasswordConnectionString;
    public static string UserPasswordConnectionString
    {
        get
        {
            if (ConfigurationManager.ConnectionStrings["UserPasswordConnectionString"] != null)
            {
                _UserPasswordConnectionString = ConfigurationManager.ConnectionStrings["UserPasswordConnectionString"].ConnectionString;
            }
            return _UserPasswordConnectionString;
        }
    }
}
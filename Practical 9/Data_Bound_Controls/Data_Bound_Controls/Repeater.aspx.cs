using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Data_Bound_Controls
{
    public partial class Repeater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Projects\MCA-Advanced-Web-Technology-Lab\Practical 9\Data_Bound_Controls\Data_Bound_Controls\App_Data\Student.mdf"";Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student", conn);
                conn.Open();
                Repeater1.DataSource = cmd.ExecuteReader();
                Repeater1.DataBind();
                conn.Close();
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            
        }
    }
}
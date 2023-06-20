using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Disconnected_Architecture
{
    public partial class Student : System.Web.UI.Page
    {

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\MCA-Advanced-Web-Technology-Lab\Practical 8\Disconnected_Architecture\Disconnected_Architecture\App_Data\Disconnected_Architecture.mdf"";Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Student", connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Student");
            dataSet.Tables["Student"].PrimaryKey = new DataColumn[] {
                dataSet.Tables["Student"].Columns["Id"]
            };
            Cache.Insert("DATASET", dataSet, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);

            GridView1.DataSource = dataSet;
            GridView1.DataBind();

            Label1.Text = "Data Loaded from Database";
        }

        private void GetDataFromCache()
        {
            if (Cache["DATASET"] != null)
            {
                GridView1.DataSource = (DataSet)Cache["DATASET"];
                GridView1.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Cache["DATASET"] != null)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                
                string selectQuery = "SELECT * FROM Student";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);

                string stringUpdateCommand = "UPDATE Student SET Name=@Name, Gender=@Gender,Total_Mark=@Total_Mark WHERE Id = @Id";
                SqlCommand updateCommand = new SqlCommand(stringUpdateCommand, connection);
                updateCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
                updateCommand.Parameters.Add("@Gender", SqlDbType.NVarChar, 2, "Gender");
                updateCommand.Parameters.Add("@Total_Marks", SqlDbType.Int, 0, "Total_Marks");
                updateCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");

                dataAdapter.UpdateCommand = updateCommand;

                string stringDeleteCommand = "DELETE FROM Student WHERE Id=@Id";
                SqlCommand deleteCommand = new SqlCommand(stringDeleteCommand, connection);
                deleteCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");

                dataAdapter.DeleteCommand = deleteCommand;

                dataAdapter.Update((DataSet)Cache["DATASET"], "Student");
                Label1.Text = "Database Synced";
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdatedEventArgs e)
        {
            DataSet dataSet = (DataSet)Cache["DATASET"];
            DataRow dataRow = dataSet.Tables["Student"].Rows.Find(e.Keys["Id"]);
            dataRow["Name"] = e.NewValues["Name"];
            dataRow["Gender"] = e.NewValues["Gender"];
            dataRow["Total_Marks"] = e.NewValues["Total_Marks"];
            Cache.Insert("DATASET", dataSet, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);
            GridView1.EditIndex = -1;
            GetDataFromCache();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GetDataFromCache();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataSet dataSet = (DataSet)Cache["DATASET"];
            dataSet.Tables["Student"].Rows.Find(e.Keys["Id"]).Delete();
            Cache.Insert("DATASET", dataSet, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);
            GetDataFromCache();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
        }
    }
}
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public class DataAccessLayer
{
    string constr;
    SqlConnection mydbCon;
    SqlDataAdapter da;
    DataSet ds;

    public DataAccessLayer()
    {
        constr = System.Configuration.ConfigurationManager.ConnectionStrings["cs"].ToString();
    }

    protected SqlConnection OpenDBCon()
    {
        mydbCon = new SqlConnection(constr);
        mydbCon.Open();
        return mydbCon;
    }

    public DataSet FillDS(string query)
    {
        da = new SqlDataAdapter(query, OpenDBCon());
        ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public void FillDG(GridView g, string query)
    {
        g.DataSource = FillDS(query).Tables[0];
        g.DataBind();
    }

    public void FillDD(DropDownList dd, string query)
    {
        ds = FillDS(query);
        dd.DataSource = ds.Tables[0];
        dd.DataValueField = ds.Tables[0].Columns[0].ToString();
        dd.DataTextField = ds.Tables[0].Columns[1].ToString();
        dd.DataBind();
        dd.Items.Insert(0, new ListItem("<-----Select----->", "0"));
    }
}

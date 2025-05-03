using System;
using System.Web.UI.WebControls;

public partial class CascadingDropDown : System.Web.UI.Page
{
    DataAccessLayer dal = new DataAccessLayer();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dal.FillDD(ddCountry, "SELECT CountrySID, CountryName FROM tblCountry");
        }
    }

    protected void ddCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        string query = "SELECT StateSID, StateName FROM tblState WHERE CountrySID=" + Convert.ToInt16(ddCountry.SelectedValue);
        dal.FillDD(ddState, query);

        ddCity.Items.Clear();
        ddCity.Items.Insert(0, new ListItem("<-----Select----->", "0"));
    }

    protected void ddState_SelectedIndexChanged(object sender, EventArgs e)
    {
        string query = "SELECT CitySID, CityName FROM tblCity WHERE StateSID=" + Convert.ToInt16(ddState.SelectedValue);
        dal.FillDD(ddCity, query);
    }
}

using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;

public partial class users_Booking : System.Web.UI.Page
{
    //Acces Veritabanı Connection Stringi
    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\......mdb"); 
    OleDbCommand cmd;
    string str;



   //Acces Veri TAbanına Bağlanmak
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();

        int id2 = 0;
        string str1 = "select max(BID) as BID from BOOKINGTAB";
        OleDbDataAdapter da = new OleDbDataAdapter(str1, con);
        DataSet ds = new DataSet();
        da.Fill(ds);

        id2=int.Parse(ds.Tables[0].Rows[0]["BID"].ToString());
        id2=1;

        if(id2 > 1)
        {
            id2++;
        }
        else
        {
            id2=1;
        }

        lblbid.Text=id2.ToString();
    }
    protected void Bt_submit_Click(object sender, EventArgs e)
    // Veri Ekleme 
    {
        try
        {
            str = "insert into BOOKINGTAB values("+lblbid.Text+",'" + DropDownList1.SelectedValue.ToString() + "','" + DropDownList2.SelectedValue.ToString() + "','" + DropDownList3.SelectedValue.ToString() + "','" + datepicker1.Text + "','" + datepicker2.Text + "','" + RadioButtonList1.SelectedValue.ToString() + "','"+txt_fulname.Text+"')";
            cmd = new OleDbCommand(str, con);
            cmd.ExecuteNonQuery();

            Response.Write("<script>alert('Gönder')</script>");
            Console.WriteLine("Bilgileriniz Gönderildi En Kısa Zamanda Mail Olarak Oda Bilgileriniz ve Fotoraflar Atılacaktır");
            con.Close();
        }
        catch (Exception ex)
        {
            Response.Write(ex.ToString());
        }
    }
    protected void LinkButton_Logout_Click(object sender, EventArgs e)
    //Tekrar homgepage Dönme 
    {
        Response.Redirect("../users/homepage.aspx");
    }
}

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

public partial class RLfile_Registration : System.Web.UI.Page
{

    //Veritabanı Connection String
    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\........OHB.mdb");
    OleDbCommand cmd;
    string str;
    OleDbDataAdapter da = new OleDbDataAdapter();
    DataSet ds = new DataSet();


    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();

        int id1 = 0;

        str = "select max(ID) as ID from RGTBL";
        da = new OleDbDataAdapter(str, con);
        da.Fill(ds);

        id1 = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
        id1 = 1;

        if (id1 > 0)
        {
            id1++;
        }
        else
        {
            id1 = 1;
        }

        lblid.Text = id1.ToString();


    }

    // Veritabanı Kullanıcı KAyıt EKleme
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        try
        {
            string str1 = "insert into RGTBL values("+lblid.Text+",'"+txt_username.Text+"',"+txt_mobile.Text+",'"+txt_email.Text+"','"+txt_password.Text+"')";
            cmd = new OleDbCommand(str1, con);
            cmd.ExecuteNonQuery();

            Response.Write("<script>alert('Kayıt Başarılı')</script>");
            con.Close();
        }
        catch(Exception ex)
        {
            Response.Write("<script>alert('Lütfen Tüm Alannları Eksiksiz Doldurun')</script>");
            Response.Write(ex.ToString());
        }
    }
}

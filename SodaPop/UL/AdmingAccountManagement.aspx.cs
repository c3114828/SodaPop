using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SodaPop.BL;

namespace SodaPop.UL
{
    public partial class AdmingAccountManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsSecureConnection)
            {
                string url =
                    ConfigurationManager.AppSettings["SecurePath"] +
                    "UL/AdmingAccountManagement.aspx";
                Response.Redirect(url);
            }
        }
        protected void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(UserIDTxtBx.Text);
                string email = EmailTxtBx.Text;
                string password = PasswordTxtBx.Text;
                string first = FirstNameTxtBx.Text;
                string last = LastNameTxtBx.Text;
                int phone = Convert.ToInt32(PhoneNumberTxtBX.Text);
                string address = AddressTxtBx.Text;
                BL.insertUserAccount(id, email, password, first, last, phone, address);
                Response.Redirect(ConfigurationManager.AppSettings["securePath"] + "UL/AdminAccountManagement.aspx");
            }
            catch (Exception ex)
            {
                errorlbl.Text = "Error Inserting Please check for correct data types : " + ex.Message;
            }
        }
    }
}
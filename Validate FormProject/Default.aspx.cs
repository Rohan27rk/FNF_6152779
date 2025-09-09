using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidateFormProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheck_click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string pin = txtPin.Text.Trim();
            string state = ddlState.SelectedValue;
            bool validatePin = CheckValidate.Checked;
            string message = "";

            if(username.Length<6 || username.Length>8)
            {
                message += "Username must be between 6 and 8 characters.";
            }
            if (validatePin)
            {
                if(!Regex.IsMatch(pin,"^[a-z A-Z 0-9]+$"))
                {
                    message += "PIN must be alphanumeric.";
                }
            }

            if(string.IsNullOrEmpty(state))
            {
                message += "Please select a state.";
            }

            if(!(rbMilk.Checked || rbCheese.Checked || rbButter.Checked))
            {
                message += "Please select Food Options.";
            }
            if(message=="")
            {
                lblResult.Text = "Validation Successful!";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResult.Text = message;
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
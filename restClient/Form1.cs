using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #region UI Event Handlers
        private void cmdGO_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            rClient.endPoint = txtURL.Text; //text from input box
            //rClient.authTech = authenticationTechnique.RollYourOwn;
            rClient.authType = authenticationType.Basic;
            rClient.userName = txtUserName.Text;
            rClient.userPassword = txtPassword.Text;

            if (txtURL.Text.Equals(""))
            {
                debugOutput("Please enter URL.");
            }
            else
            {

                debugOutput("REST Client Created");

                string strResponse = string.Empty;

                strResponse = rClient.makeRequest();

                debugOutput(strResponse);
                //Enter http://dry-cliffs-19849.herokuapp.com/users.json for test purpose
            }


        }
        #endregion

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch(Exception exc)
            {
                System.Diagnostics.Debug.Write(exc.Message, ToString() + Environment.NewLine);
            }
        }
    }
}

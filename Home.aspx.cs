using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace PraticaS3L1
{
    public partial class Home : System.Web.UI.Page
    {
        protected void btnShowCandidate_Click(object sender, EventArgs e)
        {
            string candidateName = ConfigurationManager.AppSettings["Nome"];
            string candidateSurname = ConfigurationManager.AppSettings["Cognome"];
            lblCandidateInfo.Text = $"Nome e Cognome del candidato: {candidateName} {candidateSurname}";
        }
    }
}
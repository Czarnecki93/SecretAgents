using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TopSecretAgents
{
    public partial class Index : System.Web.UI.Page
    {
        static ArrayList agentArrayList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                agentArrayList = new ArrayList();
            }
        }

        protected void Button_CreateAgent_Click(object sender, EventArgs e)
        {
            string[] enteredLanguages = { TextBoxFirstLang.Text, TextBoxSecondLang.Text };
            Agent a = new Agent(Convert.ToInt32(TextBoxID.Text), TextBoxRealName.Text, TextBoxCodeName.Text, enteredLanguages);
            agentArrayList.Add(a);
        }

        protected void Button_ShowAgents_Click(object sender, EventArgs e)
        {
            ListBoxResults.Items.Clear();
            for (int i = 0; i < agentArrayList.Count; i++)
            {
                ListBoxResults.Items.Add(agentArrayList[i].ToString());
            }
        }
    }
}
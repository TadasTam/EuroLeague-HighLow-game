using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HighLowBasketball
{
    public partial class Form : System.Web.UI.Page
    {
        public string fileName = HttpContext.Current.Server.MapPath("Data/TextFile1.csv");

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((List<Code.Player>)Session["players"] == null)
            {
                List<Code.Player> Players = Code.InOutUtils.ReadExcel(fileName);
                Session["players"] = Players;
            }

            

            Label1.ForeColor = Color.Black;
            if ((int?)Session["score"] != null)
                Label1.Text = "Your score: " + (int)Session["score"];
            else
                Label1.Text = "Start a new game!";

            Button1.Visible = DropDownList1.Visible = (bool)(Session["BeginVisible"] ?? true);
            Button5.Visible = (bool)(Session["NextVisible"] ?? false);
            Button2.Visible = Button3.Visible = Button4.Visible = (bool)(Session["ChoiceVisible"] ?? false);
            Label2.Visible = (bool)(Session["Label2Visible"] ?? false);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Code.Player> Players = (List<Code.Player>)Session["players"];
            int index = DropDownList1.SelectedIndex;
            string indexName = DropDownList1.SelectedValue;

            Random rnd = new Random();

            int randomNumber = rnd.Next(1, 297);
            Code.Player player1 = Players[randomNumber];

            randomNumber = rnd.Next(1, 297);
            Code.Player player2 = Players[randomNumber];

            Code.InOutUtils.FillTable(Table1, player1, "?", false, false);
            Code.InOutUtils.FillTable(Table2, player2, "?", false, false);

            Session["player1"] = player1;
            Session["player2"] = player2;
            Session["index"] = index;
            Session["indexName"] = indexName;

            Session["score"] = 0;
            Label1.Text = "Your score: " + 0;
            Label2.Text = indexName;

            Session["BeginVisible"] = Button1.Visible = DropDownList1.Visible = false;
            Session["NextVisible"] = Button5.Visible = false;
            Session["ChoiceVisible"] = Button2.Visible = Button3.Visible = Button4.Visible = true;
            Session["Label2Visible"] = Label2.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Code.Player player1 = (Code.Player)Session["player1"];
            Code.Player player2 = (Code.Player)Session["player2"];
            int index = (int)Session["index"];

            Code.InOutUtils.FillTable(Table1, player1, player1.Stats[index].ToString(), player1.Stats[index] > player2.Stats[index], player1.Stats[index] == player2.Stats[index]);
            Code.InOutUtils.FillTable(Table2, player2, player2.Stats[index].ToString(), player1.Stats[index] < player2.Stats[index], player1.Stats[index] == player2.Stats[index]);

            if (player1.Stats[index] > player2.Stats[index])
            {
                int score = (int)Session["score"];
                Session["score"] = score + 1;

                Label1.Text = "Your score: " + (score + 1).ToString();
                Label1.ForeColor = Color.Green;

                Session["NextVisible"] = Button5.Visible = true;
            }
            else
            {
                int score = (int)Session["score"];
                Session["score"] = 0;
                Label1.Text = "Game over! Your score: " + score.ToString();
                Label1.ForeColor = Color.Red;

                Session["BeginVisible"] = Button1.Visible = DropDownList1.Visible = true;
                Session["NextVisible"] = Button5.Visible = false;
            }

            Session["ChoiceVisible"] = Button2.Visible = Button3.Visible = Button4.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Code.Player player1 = (Code.Player)Session["player1"];
            Code.Player player2 = (Code.Player)Session["player2"];
            int index = (int)Session["index"];

            Code.InOutUtils.FillTable(Table1, player1, player1.Stats[index].ToString(), player1.Stats[index] > player2.Stats[index], player1.Stats[index] == player2.Stats[index]);
            Code.InOutUtils.FillTable(Table2, player2, player2.Stats[index].ToString(), player1.Stats[index] < player2.Stats[index], player1.Stats[index] == player2.Stats[index]);

            if (player1.Stats[index] == player2.Stats[index])
            {
                int score = (int)Session["score"];
                Session["score"] = score + 1;

                Label1.Text = "Your score: " + (score + 1).ToString();
                Label1.ForeColor = Color.Green;

                Session["NextVisible"] = Button5.Visible = true;
            }
            else
            {
                int score = (int)Session["score"];
                Session["score"] = 0;
                Label1.Text = "Game over! Your score: " + score.ToString();
                Label1.ForeColor = Color.Red;

                Session["BeginVisible"] = Button1.Visible = DropDownList1.Visible = true;
                Session["NextVisible"] = Button5.Visible = false;
            }

            Session["ChoiceVisible"] = Button2.Visible = Button3.Visible = Button4.Visible = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Code.Player player1 = (Code.Player)Session["player1"];
            Code.Player player2 = (Code.Player)Session["player2"];
            int index = (int)Session["index"];

            Code.InOutUtils.FillTable(Table1, player1, player1.Stats[index].ToString(), player1.Stats[index] > player2.Stats[index], player1.Stats[index] == player2.Stats[index]);
            Code.InOutUtils.FillTable(Table2, player2, player2.Stats[index].ToString(), player1.Stats[index] < player2.Stats[index], player1.Stats[index] == player2.Stats[index]);

            if (player1.Stats[index] < player2.Stats[index])
            {
                int score = (int)Session["score"];
                Session["score"] = score + 1;

                Label1.Text = "Your score: " + (score + 1).ToString();
                Label1.ForeColor = Color.Green;

                Session["NextVisible"] = Button5.Visible = true;
            }
            else
            {
                int score = (int)Session["score"];
                Session["score"] = 0;
                Label1.Text = "Game over! Your score: " + score.ToString();
                Label1.ForeColor = Color.Red;

                Session["BeginVisible"] = Button1.Visible = DropDownList1.Visible = true;
                Session["NextVisible"] = Button5.Visible = false;
            }

            Session["ChoiceVisible"] = Button2.Visible = Button3.Visible = Button4.Visible = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            List<Code.Player> Players = (List<Code.Player>)Session["players"];

            Code.Player player1 = (Code.Player)Session["player2"];

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 297);
            Code.Player player2 = Players[randomNumber];

            Code.InOutUtils.FillTable(Table1, player1, "?", false, false);
            Code.InOutUtils.FillTable(Table2, player2, "?", false, false);

            Session["player1"] = player1;
            Session["player2"] = player2;
            
            Session["NextVisible"] = Button5.Visible = false;
            Session["ChoiceVisible"] = Button2.Visible = Button3.Visible = Button4.Visible = true;
        }
    }
}
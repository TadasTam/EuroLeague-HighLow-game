using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace HighLowBasketball.Code
{
    public class InOutUtils
    {
        public static List<Player> ReadExcel(string fn)
        {
            List<Player> ReadList = new List<Player>();

            using (StreamReader reader = new StreamReader(fn))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    double[] stats = { double.Parse(parts[5]), double.Parse(parts[6]), double.Parse(parts[7]), double.Parse(parts[8].Trim('%').Replace('-','0')), double.Parse(parts[9]), double.Parse(parts[10]), double.Parse(parts[11]), double.Parse(parts[12]), double.Parse(parts[13].Trim('%').Replace('-', '0')), double.Parse(parts[14]), double.Parse(parts[15]), double.Parse(parts[16].Trim('%').Replace('-', '0')), double.Parse(parts[17]), double.Parse(parts[18]), double.Parse(parts[19].Trim('%').Replace('-', '0')), double.Parse(parts[20]), double.Parse(parts[21]), double.Parse(parts[22].Trim('%').Replace('-', '0')), double.Parse(parts[23]), double.Parse(parts[24]), double.Parse(parts[25]), double.Parse(parts[26]), double.Parse(parts[27]), double.Parse(parts[28]), double.Parse(parts[29]), double.Parse(parts[30]), double.Parse(parts[31]), double.Parse(parts[32]), double.Parse(parts[33]) };

                    Player player = new Player(parts[0].Trim(' ').Trim('"'), parts[1].Trim(' ').Trim('"'), parts[2], parts[3], parts[4], stats);
                    ReadList.Add(player);
                }
            }

            return ReadList;
        }

        public static void FillTable(Table table, Player player, string value, bool higher, bool equal)
        {
            TableRow row1 = new TableRow();
            TableCell cell1 = new TableCell();
            cell1.Text = player.Name + " " + player.LastName;
            cell1.HorizontalAlign = HorizontalAlign.Center;
            cell1.BackColor = Color.LightGreen;
            row1.Cells.Add(cell1);
            table.Rows.Add(row1);

            TableRow row3 = new TableRow();
            TableCell cell3 = new TableCell();
            cell3.Text = player.Position;
            cell3.HorizontalAlign = HorizontalAlign.Center;
            cell3.BackColor = Color.LightYellow;
            row3.Cells.Add(cell3);
            table.Rows.Add(row3);

            TableRow row4 = new TableRow();
            TableCell cell4 = new TableCell();
            cell4.Text = player.Team;
            cell4.HorizontalAlign = HorizontalAlign.Center;
            cell4.BackColor = Color.LightYellow;
            row4.Cells.Add(cell4);
            table.Rows.Add(row4);

            TableRow row5 = new TableRow();
            TableCell cell5 = new TableCell();
            cell5.Text = player.Nationality;
            cell5.HorizontalAlign = HorizontalAlign.Center;
            cell5.BackColor = Color.LightYellow;
            row5.Cells.Add(cell5);
            table.Rows.Add(row5);

            TableRow row6 = new TableRow();
            TableCell cell6 = new TableCell();
            cell6.Text = value;
            cell6.HorizontalAlign = HorizontalAlign.Center;

            if (value == "?")
                cell6.BackColor = Color.LightPink;
            else if (equal)
                cell6.BackColor = Color.Yellow;
            else if (higher)
                cell6.BackColor = Color.Green;
            else
                cell6.BackColor = Color.Red;
            
            row6.Cells.Add(cell6);

            table.BorderStyle = BorderStyle.Solid;
            table.BorderColor = Color.Purple;
            table.BorderWidth = 5;

            table.Rows.Add(row6);
        }
    }
}
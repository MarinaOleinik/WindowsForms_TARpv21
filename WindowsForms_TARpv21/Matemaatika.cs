using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_TARpv21
{
    public class Matemaatika : Form
    {
        TableLayoutPanel tableLayoutPanel;
        Label timeLabel, sumleftLabel,sumrightLabel;
        NumericUpDown sum;
        string[,] l_nimed;
        string[] tehed = new string[4] { "+", "-", "/", "*" };
        string text;
        
        public Matemaatika()
        {
            this.Size = new Size(660, 400);
            tableLayoutPanel = new TableLayoutPanel
            {
                AutoSize = true,
                ColumnCount = 5,
                RowCount = 4,
                Location = new System.Drawing.Point(50, 0),
                BackColor = System.Drawing.Color.LightBlue
            };
            timeLabel = new Label
            {
                Text = "Aega veel",
                AutoSize = false,
                BorderStyle = BorderStyle.FixedSingle,
                Size = new System.Drawing.Size(200, 30),
                Font = new Font("Arial", 24, FontStyle.Bold)
            };
            l_nimed = new string[5, 4];
            for (int i = 0; i < 4; i++)
            {
                tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
                for (int j = 0; j < 5; j++)
                {
                    tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
                    var l_nimi = "L" + j.ToString() + i.ToString();
                    l_nimed[j, i] = l_nimi;
                    if (j==1)
                    {
                        text=tehed[i];//tehed = new string[4] { "+", "-", "/", "*" };
                    }
                    else if (j == 3)
                    {
                        text = "=";
                    }
                    else if (j==4)
                    {
                        text = "vastus";
                    }
                    else
                    {
                        text = l_nimi;
                    }
                    Label l = new Label { Text = text };
                    tableLayoutPanel.Controls.Add(l,j,i);  
                }
            }    

            
            //sumleftLabel = new Label
            //{
            //    Text = "?",
            //    AutoSize = false,
            //    BorderStyle = BorderStyle.FixedSingle,
            //    //Size = new System.Drawing.Size(50, 50),
            //    Font = new Font("Arial", 18),
            //    TextAlign=ContentAlignment.MiddleLeft,
            //    Location=new Point(50,75)
            //};
            //sumrightLabel = new Label
            //{
            //    Text = "?",
            //    AutoSize = false,
            //    BorderStyle = BorderStyle.FixedSingle,
            //    Font = new Font("Arial", 18),
            //    TextAlign = ContentAlignment.MiddleLeft,
            //    Location = new Point(50, 75)
            //};
            //sum = new NumericUpDown
            //{
            //    Font = new Font("Arial", 18),
            //    Width=100,

            //};
            //tableLayoutPanel.Controls.Add(sumleftLabel, 0, 0);
            //tableLayoutPanel.Controls.Add(new Label { Text="+", Font = new Font("Arial", 18) }, 1, 0); 
            //tableLayoutPanel.Controls.Add(sumrightLabel, 2, 0);
            //tableLayoutPanel.Controls.Add(new Label { Text = "=" , Font = new Font("Arial", 18) }, 3, 0);
            //tableLayoutPanel.Controls.Add(sum, 4, 0);
            this.Controls.Add(tableLayoutPanel);
        }
    }
}

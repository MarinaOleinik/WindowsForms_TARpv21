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
        public Matemaatika()
        {
            this.Size = new Size(700, 400);
            tableLayoutPanel = new TableLayoutPanel
            {
                AutoSize = true,
                ColumnCount = 5,
                RowCount = 4,
                Location = new System.Drawing.Point(50, 0),
                BackColor = System.Drawing.Color.GreenYellow,
            };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
                }
                tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            }
            
            

            timeLabel = new Label
            {
                Text = "Aega veel",
                AutoSize = false,
                BorderStyle = BorderStyle.FixedSingle,  
                Size=new System.Drawing.Size(200,30),
                Font= new Font("Arial", 24, FontStyle.Bold)
            };
            sumleftLabel = new Label
            {
                Text = "?",
                AutoSize = false,
                BorderStyle = BorderStyle.FixedSingle,
                //Size = new System.Drawing.Size(50, 50),
                Font = new Font("Arial", 18),
                TextAlign=ContentAlignment.MiddleLeft,
                Location=new Point(50,75)
            };
            sumrightLabel = new Label
            {
                Text = "?",
                AutoSize = false,
                BorderStyle = BorderStyle.FixedSingle,
                //Size = new System.Drawing.Size(50, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(50, 75)
            };
            sum = new NumericUpDown
            {
                Font = new Font("Arial", 18),
                Width=100,

            };
            tableLayoutPanel.Controls.Add(sumleftLabel, 0, 0);
            tableLayoutPanel.Controls.Add(new Label { Text="+"}, 1, 0); 
            tableLayoutPanel.Controls.Add(sumrightLabel, 2, 0);
            tableLayoutPanel.Controls.Add(new Label { Text = "=" }, 3, 0);
            tableLayoutPanel.Controls.Add(sum, 4, 0);
            this.Controls.Add(tableLayoutPanel);
        }
    }
}

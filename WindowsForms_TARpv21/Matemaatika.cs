﻿using System;
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
        Label timeLabel;
        NumericUpDown[] vastused=new NumericUpDown[4];
        string[,] l_nimed;
        string[] tehed = new string[4] { "+", "-", "/", "*" };
        string text;
        Random random = new Random();
        Timer timer=new Timer { Interval=1000};
        int[] num1=new int[4];
        int[] num2=new int[4];
        public Matemaatika()
        {
            
            this.Size = new Size(680, 400);
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
            timer.Enabled = true;
            this.DoubleClick += Matemaatika_DoubleClick;
            timer.Tick += Timer_Tick;
            for (int i = 0; i < 4; i++)
            {
                tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
                for (int j = 0; j < 5; j++)
                {
                    tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
                    var l_nimi = "L" + j.ToString() + i.ToString();
                    l_nimed[j, i] = l_nimi;
                    if (j==1){text=tehed[i]; }//tehed = new string[4] { "+", "-", "/", "*" };
                    else if (j == 3){text = "=";}
                    else if(j==0)
                    {
                        int a = random.Next(20);
                        text = a.ToString();
                        num1[i]=a;
                    }
                    else if (j == 2)
                    {
                        int a = random.Next(10);
                        text = a.ToString();
                        num2[i] = a;
                    } 
                    if (j==4)
                    {
                        vastused[i] = new NumericUpDown 
                        { 
                            Name = tehed[i],
                            DecimalPlaces = 2,  
                            Minimum = -100
                        };
                        tableLayoutPanel.Controls.Add(vastused[i], j, i);
                    }
                    else
                    {
                        Label l = new Label { Text = text };
                        tableLayoutPanel.Controls.Add(l, j, i);
                    }
                }
            }               
            this.Controls.Add(tableLayoutPanel);
        }
        int tik = 0;
        private void Matemaatika_DoubleClick(object sender, EventArgs e)
        {
            timer.Start();
            timeLabel.Text = tik.ToString();
            timeLabel.Location = new Point(300, 300);
            this.Controls.Add(timeLabel);
        }
        private bool Kontroll()
        {
            if (num1[0] + num2[0] == vastused[0].Value && num1[1] - num2[1] == vastused[1].Value && num1[2] / num2[2] == vastused[2].Value && num1[3] * num2[3] == vastused[3].Value)
            {
                return true;
            }
            else{return false;}
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            tik++;
            timeLabel.Text = tik.ToString();
            if (Kontroll())
            {
                timer.Stop();
                MessageBox.Show("Palju õnne!", "Õiged vastused!");
            }
        }
    }
}

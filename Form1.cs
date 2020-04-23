﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrevoForms
{
    public partial class Form1 : Form
    {

        btree bt = new btree();
        Graphics g;
        Pen p = new Pen(Brushes.Green);
        int h = 0;
        int w = 1;

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            if (textBox1.Text != "")
                bt.Insert(Convert.ToInt32(textBox1.Text));
            textBox1.Text = "";


            h = 0;
            w = 1;

            foreach (var i in bt.Print1())
            {
                h++;
                w = 1;
                foreach (var j in i)
                {
                    w++;
                    if (j >= 0)
                    {
                        g.DrawEllipse(p, w * 20, h * 32, 30, 30);
                        g.DrawString(Convert.ToString(j), DefaultFont, Brushes.Black,(w * 20) + 9, (h * 32) + 9);
                    }
                }
            }

        }
    }
}

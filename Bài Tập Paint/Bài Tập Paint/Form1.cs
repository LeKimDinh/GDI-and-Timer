﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_Tập_Paint
{
    public partial class Form1 : Form
    {
        Graphics gp;

        bool bLine = false;
        bool bFEllipse = false;
        bool bEllipse = false;
        bool bRectangle = false;
        bool bFRectangle = false;

        bool isPress = false;
        List<clsDrawObject> lstObject = new List<clsDrawObject>();

        public Form1()
        {
            InitializeComponent();
            gp = pnlMain.CreateGraphics();
            DoubleBuffered = true;
        }

        #region Events for button
        private void btnDuongThang_Click(object sender, EventArgs e)
        {
            bLine = true;
            bFEllipse = false;
            bEllipse = false;
            bRectangle = false;
            bFRectangle = false;
        }

        private void btnKhungHCN_Click(object sender, EventArgs e)
        {
            bFRectangle = true;
            bLine = false;
            bFEllipse = false;
            bEllipse = false;
            bRectangle = false;
        }

        private void btnHCN_Click(object sender, EventArgs e)
        {
            bRectangle = true;
            bLine = false;
            bFEllipse = false;
            bEllipse = false;
            bFRectangle = false;
        }

        private void btnKhungEllipse_Click(object sender, EventArgs e)
        {
            bFEllipse = true;
            bLine = false;
            bEllipse = false;
            bRectangle = false;
            bFRectangle = false;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            bEllipse = true;
            bLine = false;
            bFEllipse = false;
            bRectangle = false;
            bFRectangle = false;
        }
        #endregion

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            isPress = true;

            if (bLine == true)
            {
                clsDrawObject myObj = new clsLine();
                myObj.p1 = e.Location;
                myObj.p2 = e.Location;

                lstObject.Add(myObj);
            }
            else
            {
                if (bRectangle == true)
                {
                    clsDrawObject myObj = new clsRectangle();
                    myObj.p1 = e.Location;
                    myObj.p2 = e.Location;

                    lstObject.Add(myObj);
                }
                else
                {
                    if (bFRectangle == true)
                    {
                        clsDrawObject myObj = new clsFRectangle();
                        myObj.p1 = e.Location;
                        myObj.p2 = e.Location;

                        lstObject.Add(myObj);
                    }
                    else
                    {
                        if (bEllipse == true)
                        {
                            clsDrawObject myObj = new clsEllipse();
                            myObj.p1 = e.Location;
                            myObj.p2 = e.Location;

                            lstObject.Add(myObj);
                        }
                        else
                        {

                            clsDrawObject myObj = new clsFEllipse();
                            myObj.p1 = e.Location;
                            myObj.p2 = e.Location;
                            lstObject.Add(myObj);
                        }
                    }
                }
            }
        }

        private void pnlMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPress == true)
            {
                this.lstObject[lstObject.Count - 1].p2 = e.Location;
                pnlMain.Refresh();
            }
        }

        private void pnlMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (isPress == true)
            {
                this.lstObject[lstObject.Count - 1].p2 = e.Location;
                pnlMain.Refresh();
            }

            isPress = false;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            foreach (var i in lstObject)
            {
                i.Draw(gp);
            }
        }
    }

    public abstract class clsDrawObject
    {
        public Point p1;
        public Point p2;

        public Color mausac;
        public SolidBrush sBrush;
        public Pen myPen;

        public int doday;

        public clsDrawObject()
        {
            mausac = Color.Blue;
            doday = 4;
            myPen = new Pen(mausac, doday);
            sBrush = new SolidBrush(mausac);
        }

        protected Rectangle CreateRectangle()
        {
            Point p = new Point();
            if (this.p1.X < this.p2.X && this.p1.Y < this.p2.Y)
            {
                p = this.p1;
            }
            else
            {
                if (this.p1.X > this.p2.X && this.p1.Y > this.p2.Y)
                {
                    p = this.p2;
                }
                else
                {
                    if (this.p1.X > this.p2.X && this.p1.Y < this.p2.Y)
                    {
                        p.X = this.p2.X;
                        p.Y = this.p1.Y;
                    }
                    else
                    {
                        p.X = this.p1.X;
                        p.Y = this.p2.Y;
                    }
                }
            }
            return new Rectangle(p, new Size(Math.Abs(this.p1.X - this.p2.X), Math.Abs(this.p1.Y - this.p2.Y)));
        }

        public abstract void Draw(Graphics g);
    }

    public class clsLine : clsDrawObject
    {
        public override void Draw(Graphics g)
        {
            g.DrawLine(this.myPen, this.p1, this.p2);
        }
    }

    public class clsRectangle : clsDrawObject
    {
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(this.myPen, CreateRectangle());
        }
    }

    public class clsFRectangle : clsDrawObject
    {
        public override void Draw(Graphics g)
        {
            g.FillRectangle(this.sBrush, CreateRectangle());
        }
    }

    public class clsEllipse : clsDrawObject
    {
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(this.myPen, CreateRectangle());
        }
    }

    public class clsFEllipse : clsDrawObject
    {
        public override void Draw(Graphics g)
        {
            g.FillEllipse(this.sBrush, CreateRectangle());
        }
    }




}

using System;
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

        System.Drawing.Drawing2D.DashStyle dashStyle;

        bool bLine = false;
        bool bFEllipse = false;
        bool bEllipse = false;
        bool bRectangle = false;
        bool bFRectangle = false;
        bool bArc = false;
        bool bSquare = false;

        bool isPress = false;
        List<clsDrawObject> lstObject = new List<clsDrawObject>();

        public Form1()
        {
            InitializeComponent();
            gp = pnlMain.CreateGraphics();
            DoubleBuffered = true;

            cbKieuVe.SelectedIndex = 0;

            btnColorPen.BackColor = colorDialog1.Color;
            btnColorBrush.BackColor = colorDialog1.Color;
        }

        #region Events for button
        private void btnDuongThang_Click(object sender, EventArgs e)
        {
            bLine = true;
            bFEllipse = false;
            bEllipse = false;
            bRectangle = false;
            bFRectangle = false;
            bArc = false;
            bSquare = false;
        }

        private void btnKhungHCN_Click(object sender, EventArgs e)
        {
            bFRectangle = true;
            bLine = false;
            bFEllipse = false;
            bEllipse = false;
            bRectangle = false;
            bArc = false;
            bSquare = false;
        }

        private void btnHCN_Click(object sender, EventArgs e)
        {
            bRectangle = true;
            bLine = false;
            bFEllipse = false;
            bEllipse = false;
            bFRectangle = false;
            bArc = false;
            bSquare = false;
        }

        private void btnKhungEllipse_Click(object sender, EventArgs e)
        {
            bFEllipse = true;
            bLine = false;
            bEllipse = false;
            bRectangle = false;
            bFRectangle = false;
            bArc = false;
            bSquare = false;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            bEllipse = true;
            bLine = false;
            bFEllipse = false;
            bRectangle = false;
            bFRectangle = false;
            bArc = false;
            bSquare = false;
        }

        private void btnArc_Click(object sender, EventArgs e)
        {
            bArc = true;
            bEllipse = false;
            bLine = false;
            bFEllipse = false;
            bRectangle = false;
            bFRectangle = false;
            bSquare = false;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            bArc = false;
            bEllipse = false;
            bLine = false;
            bFEllipse = false;
            bRectangle = false;
            bFRectangle = false;
            bSquare = true;
        }
        #endregion

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            isPress = true;

            try
            {
                if (bLine == true)
                {
                    clsDrawObject myObj = new clsLine();
                    myObj.P1 = e.Location;
                    myObj.P2 = e.Location;

                    myObj.MyPen = new Pen(colorDialog1.Color, float.Parse(txtDoDay.Text));
                    myObj.MyPen.DashStyle = dashStyle;


                    lstObject.Add(myObj);
                }
                else
                {
                    if (bRectangle == true)
                    {
                        clsDrawObject myObj = new clsRectangle();
                        myObj.P1 = e.Location;
                        myObj.P2 = e.Location;

                        myObj.MyPen = new Pen(colorDialog1.Color, float.Parse(txtDoDay.Text));
                        myObj.MyPen.DashStyle = dashStyle;

                        lstObject.Add(myObj);
                    }
                    else
                    {
                        if (bFRectangle == true)
                        {
                            clsDrawObject myObj = new clsFRectangle();
                            myObj.P1 = e.Location;
                            myObj.P2 = e.Location;
                            myObj.SBrush = new SolidBrush(colorDialog2.Color);
                            lstObject.Add(myObj);
                        }
                        else
                        {
                            if (bEllipse == true)
                            {
                                clsDrawObject myObj = new clsEllipse();
                                myObj.P1 = e.Location;
                                myObj.P2 = e.Location;

                                myObj.MyPen = new Pen(colorDialog1.Color, float.Parse(txtDoDay.Text));
                                myObj.MyPen.DashStyle = dashStyle;

                                lstObject.Add(myObj);
                            }
                            else
                            {
                                if (bFEllipse == true)
                                {
                                    clsDrawObject myObj = new clsFEllipse();
                                    myObj.P1 = e.Location;
                                    myObj.P2 = e.Location;
                                    myObj.SBrush = new SolidBrush(colorDialog2.Color);
                                    lstObject.Add(myObj);
                                }
                                else
                                {
                                    if (bArc == true)
                                    {
                                        clsDrawObject myObj = new clsArc();
                                        myObj.P1 = e.Location;
                                        myObj.P2 = e.Location;

                                        myObj.MyPen = new Pen(colorDialog1.Color, float.Parse(txtDoDay.Text));
                                        myObj.MyPen.DashStyle = dashStyle;

                                        lstObject.Add(myObj);
                                    }
                                    else
                                    {
                                        if (bSquare == true)
                                        {
                                            clsDrawObject myObj = new clsSquare();
                                            myObj.P1 = e.Location;
                                            myObj.P2 = e.Location;

                                            myObj.MyPen = new Pen(colorDialog1.Color, float.Parse(txtDoDay.Text));
                                            myObj.MyPen.DashStyle = dashStyle;

                                            lstObject.Add(myObj);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Độ dày không hợp lệ.", "Thông báo");
                isPress = false;
            }
        }

        private void pnlMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPress == true)
            {
                if (lstObject.Count > 0)
                {
                    this.lstObject[lstObject.Count - 1].P2 = e.Location;
                    pnlMain.Refresh();
                }
            }
        }

        private void pnlMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (isPress == true)
            {
                if (lstObject.Count > 0)
                {
                    this.lstObject[lstObject.Count - 1].P2 = e.Location;
                    pnlMain.Refresh();
                }
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

        private void btnColorPen_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnColorPen.BackColor = colorDialog1.Color;
        }

        private void btnColorBrush_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            btnColorBrush.BackColor = colorDialog2.Color;
        }

        private void cbKieuVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbKieuVe.SelectedIndex)
            {
                case 0:
                    dashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
                    break;
                case 1:
                    dashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    break;
                case 2:
                    dashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                    break;
                case 3:
                    dashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                    break;
                case 4:
                    dashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    break;
                case 5:
                    dashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    break;
            }
        }
    }

    public abstract class clsDrawObject
    {
        private Point p1;
        private Point p2;
        private Color mausac;
        private SolidBrush sBrush;
        private Pen myPen;
        private float doday;

        public Point P1 { get => p1; set => p1 = value; }
        public Point P2 { get => p2; set => p2 = value; }
        public Color Mausac { get => mausac; set => mausac = value; }
        public SolidBrush SBrush { get => sBrush; set => sBrush = value; }
        public Pen MyPen { get => myPen; set => myPen = value; }
        public float Doday { get => doday; set => doday = value; }

        public clsDrawObject()
        {
            //mausac = Color.Black;
            //doday = 4;
            //myPen = new Pen(mausac, doday);
            //sBrush = new SolidBrush(mausac);

        }

        protected Rectangle CreateRectangle()
        {
            Point p = new Point();
            if (this.P1.X < this.P2.X && this.P1.Y < this.P2.Y)
            {
                p = this.P1;
            }
            else
            {
                if (this.P1.X > this.P2.X && this.P1.Y > this.P2.Y)
                {
                    p = this.P2;
                }
                else
                {
                    if (this.P1.X > this.P2.X && this.P1.Y < this.P2.Y)
                    {
                        p.X = this.P2.X;
                        p.Y = this.P1.Y;
                    }
                    else
                    {
                        p.X = this.P1.X;
                        p.Y = this.P2.Y;
                    }
                }
            }
            return new Rectangle(p, new Size(Math.Abs(this.P1.X - this.P2.X), Math.Abs(this.P1.Y - this.P2.Y)));
        }

        public abstract void Draw(Graphics g);
    }

    public class clsLine : clsDrawObject
    {
        public override void Draw(Graphics g)
        {
            g.DrawLine(this.MyPen, this.P1, this.P2);
        }
    }

    public class clsRectangle : clsDrawObject
    {
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(this.MyPen, CreateRectangle());
        }
    }

    public class clsFRectangle : clsDrawObject
    {
        public override void Draw(Graphics g)
        {
            g.FillRectangle(this.SBrush, CreateRectangle());
        }
    }

    public class clsEllipse : clsDrawObject
    {
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(this.MyPen, CreateRectangle());
        }
    }

    public class clsFEllipse : clsDrawObject
    {
        public override void Draw(Graphics g)
        {
            g.FillEllipse(this.SBrush, CreateRectangle());
        }
    }

    public class clsArc : clsDrawObject
    {
        public override void Draw(Graphics g)
        {
            //Chưa xong
            g.DrawArc(this.MyPen, CreateRectangle(), 45.0F, 270.0F);
        }
    }

    public class clsSquare : clsDrawObject
    {
        public override void Draw(Graphics g)
        {
            Point p = new Point();
            if (this.P1.X < this.P2.X && this.P1.Y < this.P2.Y)
            {
                p = this.P1;
            }
            else
            {
                if (this.P1.X > this.P2.X && this.P1.Y > this.P2.Y)
                {
                    p = this.P2;
                }
                else
                {
                    if (this.P1.X > this.P2.X && this.P1.Y < this.P2.Y)
                    {
                        p.X = this.P2.X;
                        p.Y = this.P1.Y;
                    }
                    else
                    {
                        p.X = this.P1.X;
                        p.Y = this.P2.Y;
                    }
                }
            }
            
        }
    }
}

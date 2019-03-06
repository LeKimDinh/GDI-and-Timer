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

        FlagPaint flagStatus = FlagPaint.None;

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
            flagStatus = FlagPaint.Line;
        }

        private void btnKhungHCN_Click(object sender, EventArgs e)
        {
            flagStatus = FlagPaint.Rectangle;
        }

        private void btnHCN_Click(object sender, EventArgs e)
        {
            flagStatus = FlagPaint.FillRectangle;
        }

        private void btnKhungEllipse_Click(object sender, EventArgs e)
        {
            flagStatus = FlagPaint.Ellipse;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            flagStatus = FlagPaint.FillEllipse;
        }

        private void btnArc_Click(object sender, EventArgs e)
        {
            flagStatus = FlagPaint.Arc;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            flagStatus = FlagPaint.Square;
        }
        #endregion

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            //if (flagStatus != FlagPaint.None)
            isPress = true;

            try
            {
                if (flagStatus == FlagPaint.Line)
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
                    if (flagStatus == FlagPaint.Rectangle)
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
                        if (flagStatus == FlagPaint.FillRectangle)
                        {
                            clsDrawObject myObj = new clsFRectangle();
                            myObj.P1 = e.Location;
                            myObj.P2 = e.Location;
                            myObj.SBrush = new SolidBrush(colorDialog2.Color);
                            lstObject.Add(myObj);
                        }
                        else
                        {
                            if (flagStatus == FlagPaint.Ellipse)
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
                                if (flagStatus == FlagPaint.FillEllipse)
                                {
                                    clsDrawObject myObj = new clsFEllipse();
                                    myObj.P1 = e.Location;
                                    myObj.P2 = e.Location;
                                    myObj.SBrush = new SolidBrush(colorDialog2.Color);
                                    lstObject.Add(myObj);
                                }
                                else
                                {
                                    if (flagStatus == FlagPaint.Arc)
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
                                        if (flagStatus == FlagPaint.Square)
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
            //flagStatus = FlagPaint.None;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            if (isPress == true)
            {
                foreach (var i in lstObject)
                {
                    i.Draw(gp);
                }
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

    /// <summary>
    /// Cờ hiệu cho biết tình trạng loại hình đang vẽ.
    /// </summary>
    public enum FlagPaint
    {
        None, Line, FillLine, Rectangle, FillRectangle, Ellipse,
        FillEllipse, Square, Arc
    }

    public abstract class clsDrawObject
    {
        private Point p1;
        private Point p2;
        private Color mausac;
        private SolidBrush sBrush;
        private Pen myPen;
        private float doday;

        public Point P1
        {
            get
            {
                return p1;
            }

            set
            {
                p1 = value;
            }
        }

        public Point P2
        {
            get
            {
                return p2;
            }

            set
            {
                p2 = value;
            }
        }

        public Color Mausac
        {
            get
            {
                return mausac;
            }

            set
            {
                mausac = value;
            }
        }

        public SolidBrush SBrush
        {
            get
            {
                return sBrush;
            }

            set
            {
                sBrush = value;
            }
        }

        public Pen MyPen
        {
            get
            {
                return myPen;
            }

            set
            {
                myPen = value;
            }
        }

        public float Doday
        {
            get
            {
                return doday;
            }

            set
            {
                doday = value;
            }
        }

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
            Rectangle rect = CreateRectangle();
            rect.Width += 1;
            rect.Height += 1;

            g.DrawArc(this.MyPen, rect, 0, 180);
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

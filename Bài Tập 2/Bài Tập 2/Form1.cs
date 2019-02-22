using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_Tập_2
{
    public partial class Form1 : Form
    {
        Graphics gp;
        bool bLine = false;

        Pen myPen;
        Color myColor;

        bool isStart = false;   //Cờ xác định đi vẽ

        List<cLine> lLine = new List<cLine>();

        public Form1()
        {
            InitializeComponent();

            gp = this.pnlMain.CreateGraphics();
            myColor = Color.Blue;
            myPen = new Pen(myColor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            this.isStart = true;        //bắt đầu vẽ

            if (bLine == true)
            {
                cLine myLine = new cLine();
                myLine.p1 = e.Location;
                myLine.p2 = e.Location;
                this.lLine.Add(myLine);
            }
        }

        private void pnlMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isStart == true)
            {
                if (this.bLine == true)
                {
                    //Cập nhật lại vị trí con chuột hiện tại
                    this.lLine[this.lLine.Count - 1].p2 = e.Location;
                    this.pnlMain.Refresh(); //Làm tười màn hình
                    //Xóa sách màn hình và gọi hàm Paint
                }
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            if (this.isStart == true)
            {
                for (int i = 0; i < this.lLine.Count; i++)
                {
                    gp.DrawLine(myPen, lLine[i].p1, lLine[i].p2);
                }
            }
        }

        private void pnlMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.bLine == true)
            {
                this.lLine[this.lLine.Count - 1].p2 = e.Location;
                this.pnlMain.Refresh();
            }
            this.isStart = false;
            this.bLine = false;
        }

        private void btnDuongThang_Click(object sender, EventArgs e)
        {
            bLine = true;
        }
    }

    public class cLine
    {
        public Point p1;
        public Point p2;
       
    }
}

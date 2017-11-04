using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cam {
    public partial class camForm : Form {
        public int GraphicNum = 0;
        private void numChecker(KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)48 || e.KeyChar == (Char)49 ||
                e.KeyChar == (Char)50 || e.KeyChar == (Char)51 ||
                e.KeyChar == (Char)52 || e.KeyChar == (Char)53 ||
                e.KeyChar == (Char)54 || e.KeyChar == (Char)55 ||
                e.KeyChar == (Char)56 || e.KeyChar == (Char)57 ||
                e.KeyChar == (Char)13 || e.KeyChar == (Char)8) {
                e.Handled = false;

            }
            else {
                e.Handled = true;
            }
        }
        private bool emptyChecker()
        {
            if (camNum.Text == "" || camStationNum.Text == "") {
                MessageBox.Show("數值不得為空!", "錯誤");
                return false;
            }
            return true;
        }
        public camForm()
        {
            InitializeComponent();
        }

        private void camStationNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            numChecker(e);
        }

        private void camNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            numChecker(e);
        }
        private void drawing(PictureBox draw)
        {
            int startX = 0;
            int startY = 0;

            int roadLen = 115;
            int roadWidth = 30;

            int tmpX1, tmpY1;
            int tmpX2, tmpY2;

            int middleX = startX + (roadLen * 2 + roadWidth) / 2;
            int middleY = startY + (roadLen * 2 + roadWidth) / 2;


            int[,] labelLocation = new int[,] {
                        { roadLen,  roadLen },
                        { middleX + roadWidth/2,  middleY - roadWidth / 2 },
                        { middleX - roadWidth/2,  middleY + roadWidth / 2 },
                        { middleX + roadWidth/2,  middleY + roadWidth / 2 }
                    };

            int[] lableSize = new int[] { 30, 15 };

            /**
            Label labelA = new Label();
            Label labelB = new Label();
            Label labelC = new Label();
            Label labelD = new Label();
            
            labelA.Location = new Point(labelLocation[0, 0] - lableSize[0], labelLocation[0, 1] - lableSize[1]);
            labelA.Size = new Size(lableSize[0], lableSize[1]);
            labelA.Text = "A";
            this.camDisplay.Controls.Add(labelA);
            **/


            //Graphics g = draw.CreateGraphics();
            Graphics g = draw.CreateGraphics();
            g.Clear(SystemColors.Control);//清除
            using (Pen p = new Pen(Brushes.Black)) {
                //g.DrawLine(p, x1, y1, e.X, e.Y);
                //g.DrawEllipse(p, midX, midY, 100, 100);

                //Line1
                tmpX1 = startX + roadLen;
                tmpY1 = startY;

                tmpX2 = startX + roadLen;
                tmpY2 = startY + roadLen;

                g.DrawLine(p, tmpX1, tmpY1, tmpX2, tmpY2);


                //Line2
                tmpX1 = startX + roadWidth + roadLen;
                tmpY1 = startY;

                tmpX2 = startX + roadWidth + roadLen;
                tmpY2 = startY + roadLen;
                g.DrawLine(p, tmpX1, tmpY1, tmpX2, tmpY2);


                //Line3
                tmpX1 = startX;
                tmpY1 = startY + roadLen;

                tmpX2 = startX + roadLen;
                tmpY2 = startY + roadLen;
                g.DrawLine(p, tmpX1, tmpY1, tmpX2, tmpY2);

                //Line4
                tmpX1 = startX + roadWidth + roadLen;
                tmpY1 = startY + roadLen;

                tmpX2 = startX + roadWidth + roadLen + roadLen;
                tmpY2 = startY + roadLen;
                g.DrawLine(p, tmpX1, tmpY1, tmpX2, tmpY2);

                //Line5
                tmpX1 = startX;
                tmpY1 = startY + roadLen + roadWidth;

                tmpX2 = startX + roadLen;
                tmpY2 = startY + roadLen + roadWidth;
                g.DrawLine(p, tmpX1, tmpY1, tmpX2, tmpY2);

                //Line6
                tmpX1 = startX + roadWidth + roadLen;
                tmpY1 = startY + roadLen + roadWidth;

                tmpX2 = startX + roadWidth + roadLen + roadLen;
                tmpY2 = startY + roadLen + roadWidth;
                g.DrawLine(p, tmpX1, tmpY1, tmpX2, tmpY2);


                //Line7
                tmpX1 = startX + roadLen;
                tmpY1 = startY + roadLen + roadWidth;

                tmpX2 = startX + roadLen;
                tmpY2 = startY + roadLen + roadWidth + roadLen;
                g.DrawLine(p, tmpX1, tmpY1, tmpX2, tmpY2);

                //Line8
                tmpX1 = startX + roadLen + roadWidth;
                tmpY1 = startY + roadLen + roadWidth;

                tmpX2 = startX + roadLen + roadWidth;
                tmpY2 = startY + roadLen + roadWidth + roadLen;
                g.DrawLine(p, tmpX1, tmpY1, tmpX2, tmpY2);

                //Circle1
                g.DrawEllipse(p, startX + 50, startY + 50, 50, 50);
                //Circle2
                g.DrawEllipse(p, startX + roadLen + roadWidth + 15, startY + 50, 50, 50);
                //Circle3
                g.DrawEllipse(p, startX + 50, startY + roadLen + roadWidth + 15, 50, 50);
                //Circle4
                g.DrawEllipse(p, startX + roadLen + roadWidth + 15, startY + roadLen + roadWidth + 15, 50, 50);

            }




        }

        private void generate_Click(object sender, EventArgs e) {
            if (emptyChecker()) {
                int camStationValue = int.Parse(camStationNum.Text);
                int camValue = int.Parse(camNum.Text);
                
                string ErrorMsg = "";

                if (camStationValue > 4 || camStationValue <= 0) {
                    ErrorMsg += "監視站數量範圍為 1～4 !! \n";
                    camStationNum.Clear();
                }

                if (camValue > 9 || camValue <= 0) {
                    ErrorMsg += "監視器數量範圍為 1～9 !! \n";
                    camNum.Clear();
                }
                if (ErrorMsg == "") {

                    //drawing(camDisplay); 

                    PictureBox[] pics = new PictureBox[9];
                    int[] firstPicLocation = new int[2] { 17, 159 };
                    int[,,] picLocation = new int[,,] {
                        { 
                          { firstPicLocation[0], firstPicLocation[1] },
                          { firstPicLocation[0] + 260 + 10 ,firstPicLocation[1] },
                          { firstPicLocation[0] + (260 + 10)*2 , firstPicLocation[1]}
                        },
                        {
                          { firstPicLocation[0], firstPicLocation[1] + 260 +10 },
                          { firstPicLocation[0] + 260 + 10 ,firstPicLocation[1] + 260 +10 },
                          { firstPicLocation[0] + (260 + 10)*2 , firstPicLocation[1] + 260 +10}
                        },
                        {
                          { firstPicLocation[0], firstPicLocation[1] + (260 +10)*2 },
                          { firstPicLocation[0] + 260 + 10 ,firstPicLocation[1] + (260 +10)*2 },
                          { firstPicLocation[0] + (260 + 10)*2 , firstPicLocation[1] + (260 +10)*2 }
                        },
                    };
                    int picNum = 0;
                    for (int i = 0; i < 3; ++i) {
                        for (int j = 0; j < 3; ++j) {
                            pics[picNum] = new PictureBox();
                            pics[picNum].Location = new Point(picLocation[i, j, 0], picLocation[i, j, 1]);
                            pics[picNum].Name = "pic" + i + "-" + j;
                            pics[picNum].Size = new Size(260, 260);
                            //pics[i].ImageLocation = "E:/image" + i;
                            //pics[picNum].BackColor = Color.Azure;
                            this.Controls.Add(pics[picNum]);
                            pics[picNum].Update();
                            drawing(pics[picNum]);
                            ++picNum;
                        }
                    }
                    for (int i = 0; i < 3; ++i) {

                    }

                

                }
            }
        }
    }
}

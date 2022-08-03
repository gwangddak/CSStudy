namespace Project3
{
    public partial class Form1 : Form
    {

        private Graphics g;
        private Pen pen;
        private Brush wBrush, bBrush;

        private int margin = 40;
        private int sizeNun = 30;
        private int sizeDol = 28;
        private bool isBlack = true;

        enum STONE {none,black,white }

        STONE[,] dataSet = new STONE[19, 19];


        public Form1()
        {
            InitializeComponent();


            //그래픽 객체 초기화 
            g = this.CreateGraphics();
            pen = new Pen(Color.Black);
            wBrush = new SolidBrush(Color.White);
            bBrush = new SolidBrush(Color.Black);

            //바둑판 색 ,크기
            this.BackColor = Color.Orange;
            this.ClientSize = new Size(2 * margin + 18 * sizeNun, 2 * margin + 18 * sizeNun);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.X - margin + sizeNun /2)/sizeNun;    
            int y = (e.Y - margin + sizeNun / 2) / sizeNun;

            //Console.WriteLine($"x : {x}, y : {y}");

            Rectangle dol = new Rectangle(margin + sizeNun * x - sizeNun / 2,
                margin + sizeNun * y - sizeNun / 2,
                sizeDol,sizeDol);

            //돌을 그리기 전에 확인해야할것 // 돌이 놓여있는지 확인
            if (dataSet[x,y] != STONE.none)
            {
                MessageBox.Show("이미 돌이 놓여 있습니다.");
                return;
            }


            //검은돌, 흰돌 그리기
            if (isBlack)
            {
                g.FillEllipse(bBrush, dol);
                dataSet[x,y] = STONE.black;
                isBlack = false;    
            }
            else
            {
                g.FillEllipse(wBrush, dol);
                dataSet[x, y] = STONE.white;
                isBlack = true;
            }

            //오목 판정 
            CheckOmok(x,y);
 
        }
        public void CheckOmok(int x, int y) // 판정 체크 
        {
            int count = 1;
            //오른쪽 방향
            for (int i = x+1 ; i < x+ 5; i++)
            {
                if (dataSet[x, y] == dataSet[i,y]) //00부터 가정
                {
                    count++;

                }
                else
                {
                    break;
                }
            }
         
            //왼쪽 방향
            for (int i = x - 1; i > x - 5; i--)
            {
                if (dataSet[x, y] == dataSet[i, y]) //00부터 가정
                {
                    count++;

                }
                else
                {
                    break;
                }
            }
            CheckCountResult(count); 
            //Console.WriteLine("카운트 : " + count);
            count = 1;




            //위쪽 방향
            for (int i = y + 1; i< y + 5; i++)
            {
                if (dataSet[x, y] == dataSet[x, i]) //00부터 가정
                {
                    count++;

                }
                else
                {
                    break;
                }
            }
           

            //아래쪽 방향
            for (int i = y - 1; i > y - 5; i--)
            {
                if (dataSet[x, y] == dataSet[x, i]) //00부터 가정
                {
                    count++;

                }
                else
                {
                    break;
                }
            }
            CheckCountResult(count);

            count = 1;



            //11시 방향
            for (int i = x - 1,j= y-1; i >= 0 && j>=0;i-- ,j--)
            {
                if (dataSet[x, y] == dataSet[i, j]) //00부터 가정
                {
                    count++;

                }
                else
                {
                    break;
                }
            }
            //16시 방향
            for (int i = x + 1, j = y + 1; i < 5 && j < 5; i++, j++)
            {
                if (dataSet[x, y] == dataSet[i, j]) //00부터 가정
                {
                    count++;

                }
                else
                {
                    break;
                }
            }
            CheckCountResult(count);

            count = 1;

            //13시 방향
            for (int i = x + 1, j = y - 1; i < 19 && j >= 0; i++, j--)
            {
                if (dataSet[x, y] == dataSet[i, j]) //00부터 가정
                {
                    count++;

                }
                else
                {
                    break;
                }
            }

            //19시 방향
            for (int i = x - 1, j = y + 1; i >= 0 && j < 19; i--, j++)
            {
                if (dataSet[x, y] == dataSet[i, j]) //00부터 가정
                {
                    count++;

                }
                else
                {
                    break;
                }
            }
            CheckCountResult(count);
            Console.WriteLine("카운트 : " + count);
            count = 1;

        }
        public void CheckCountResult(int count)
        {
            if (count >= 5)
            {
                DialogResult result =  MessageBox.Show("오목입니다! 새로운 게임을 시작할까예?  ","확인",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    NewGame();

                }
                else
                {
                    this.Close();
                }
                

            }
        }
        public void NewGame()
        {
            //화면 갱신
            
            this.Invalidate();
            //데이타 셋 초기화 
            for (int x = 0; x < 19; x++)
            {
                for (int y = 0; y < 19; y++)
                {
                    dataSet[x, y] = STONE.none;
                }
            }
            isBlack = true;
        }

        protected override void OnPaint(PaintEventArgs e) // 
        {
            Console.WriteLine("OnPaint!");
            //바둑판 라인 그리기
            //g.DrawLine(pen, new Point(margin, margin), new Point(margin+18*sizeNun,margin)); // 왼쪽 오른쪽 
            //g.DrawLine(pen, new Point(margin, margin + sizeNun*1), new Point(margin+18*sizeNun,margin+sizeNun*1)); // 왼쪽 오른쪽 
            //g.DrawLine(pen, new Point(margin, margin + sizeNun*2), new Point(margin+18*sizeNun,margin+sizeNun*2)); // 왼쪽 오른쪽 
            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, new Point(margin, margin + sizeNun * i), new Point(margin + 18 * sizeNun, margin + sizeNun * i)); // 왼쪽 오른쪽 
                g.DrawLine(pen, new Point(margin + sizeNun * i, margin), new Point(margin + sizeNun * i, margin + 18 * sizeNun)); // 왼쪽 오른쪽 
            }





        }




    }
}
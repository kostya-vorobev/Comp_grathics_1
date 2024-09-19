using System;
using System.Drawing;
using System.Windows.Forms;

namespace kg_lab1
{
    public partial class MainForm : Form
    {
        private float[,] B;
        private float[,] proection;
        private int cenX;
        private int cenY;
        private Graphics _graphics;

        public MainForm() 
            => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            cenX = Size.Width / 2;
            cenY = Size.Height / 2;
            SetDefaultPosition();
            //кабинетное проецирование относительно центра правосторонней системы координат
            float[,] p =
            {
                { 1, 0, 0, 0},
                { 0, -1, 0, 0},
                { -(float)(Math.Cos(Math.PI/4))/2, (float)(Math.Cos(Math.PI/4))/2, 0, 0},
                { cenX, cenY, 0, 1}
            };
            proection = p;
            DrawB();
        }

        //умножение матриц
        private float[,] Mult(float[,] X, float[,] Y)
        {
            float[,] result = new float[X.GetLength(0), Y.GetLength(1)];
            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = 0; j < Y.GetLength(1); j++)
                    for (int k = 0; k < Y.GetLength(0); k++)
                        result[i, j] += X[i, k] * Y[k, j];
            return result;
        }

        //отрисовка осей
        private void DrawAxis()
        {
            _graphics = CreateGraphics();
            _graphics.Clear(Color.White);
            float[,] Axis =
            {
                { 0, 0, 0, 1},
                { 500, 0, 0, 1},
                { 0, 400, 0, 1},
                { 0, 0, 500, 1},
                { 490, 5, 0, 1},
                { 490, -5, 0, 1},
                { 5, 390, 0, 1},
                { -5, 390, 0, 1},
                { 12, 0, 495, 1},
                { -10, 0, 480, 1}
            };
            Axis = Mult(Axis, proection);
            #region X
            _graphics.DrawLine(Pens.Gray, Axis[0, 0], Axis[0, 1], Axis[1, 0], Axis[1, 1]);
            _graphics.DrawLine(Pens.Gray, Axis[1, 0], Axis[1, 1], Axis[4, 0], Axis[4, 1]);
            _graphics.DrawLine(Pens.Gray, Axis[1, 0], Axis[1, 1], Axis[5, 0], Axis[5, 1]);
            #endregion
            #region Y
            _graphics.DrawLine(Pens.Gray, Axis[0, 0], Axis[0, 1], Axis[2, 0], Axis[2, 1]);
            _graphics.DrawLine(Pens.Gray, Axis[2, 0], Axis[2, 1], Axis[6, 0], Axis[6, 1]);
            _graphics.DrawLine(Pens.Gray, Axis[2, 0], Axis[2, 1], Axis[7, 0], Axis[7, 1]);
            #endregion
            #region B
            _graphics.DrawLine(Pens.Gray, Axis[0, 0], Axis[0, 1], Axis[3, 0], Axis[3, 1]);
            _graphics.DrawLine(Pens.Gray, Axis[3, 0], Axis[3, 1], Axis[8, 0], Axis[8, 1]);
            _graphics.DrawLine(Pens.Gray, Axis[3, 0], Axis[3, 1], Axis[9, 0], Axis[9, 1]);
            #endregion
        }

        //начальные значения B
        private void SetDefaultPosition()
        {
            float[,] DefB =
            {
        { 0, 0, 0, 1 },         // |
        { 0, 120, 0, 1 },       // _
        { 40, 120, 0, 1 },      // \
        { 60, 100, 0, 1 },      // |
        { 60, 80, 0, 1 },       // /
        { 40, 60, 0, 1 },       // \
        { 0, 60, 0, 1 },
        { 20, 80, 0, 1},
        { 20, 100, 0, 1},
        { 40, 100, 0, 1},
        { 40, 80, 0, 1},
        { 20, 80, 0, 1},
         { 0, 60, 0, 1 },
         { 40, 60, 0, 1 },
        { 60, 40, 0, 1 },       // |
        { 60, 20, 0, 1 },       // /
        { 40, 0, 0, 1},
        { 0, 0, 0, 1 },
        { 20, 20, 0, 1},
        { 20, 40, 0, 1},
        { 40, 40, 0, 1},
        { 40, 20, 0, 1},
        { 20, 20, 0, 1},
        { 0, 0, 0, 1},
        { 0, 0, 10, 1 },         // |
        { 0, 120, 10, 1 },       // _
        { 40, 120, 10, 1 },      // \
        { 60, 100, 10, 1 },      // |
        { 60, 80, 10, 1 },       // /
        { 40, 60, 10, 1 },       // \
        { 0, 60, 10, 1 },
        { 20, 80, 10, 1},
        { 20, 100, 10, 1},
        { 40, 100, 10, 1},
        { 40, 80, 10, 1},
        { 20, 80, 10, 1},
         { 0, 60, 10, 1 },
         { 40, 60, 10, 1 },
        { 60, 40, 10, 1 },       // |
        { 60, 20, 10, 1 },       // /
        { 40, 0, 10, 1},
        { 0, 0, 10, 1 },
        { 20, 20, 10, 1},
        { 20, 40, 10, 1},
        { 40, 40, 10, 1},
        { 40, 20, 10, 1},
        { 20, 20, 10, 1},
         { 0, 0, 10, 1 },


       };
            B = DefB;
        }

        //отрисовка проекции буквы
        private void DrawB()
        {
            _graphics = CreateGraphics();
            DrawAxis();
            float[,] matrixDraw = Mult(B, proection);
            for (int i = 0; i < (B.Length/8)-1; i++)
            {
                _graphics.DrawLine(Pens.Red, matrixDraw[i, 0], matrixDraw[i, 1], matrixDraw[i + 1, 0], matrixDraw[i + 1, 1]);
                _graphics.DrawLine(Pens.Red, matrixDraw[i + (B.Length / 8), 0], matrixDraw[i + (B.Length / 8), 1], matrixDraw[i + (B.Length / 8)+1, 0], matrixDraw[i + (B.Length / 8)+1, 1]);
                _graphics.DrawLine(Pens.Red, matrixDraw[i, 0], matrixDraw[i, 1], matrixDraw[i + (B.Length / 8) , 0], matrixDraw[i + (B.Length / 8) , 1]);
            }
            //_graphics.DrawLine(Pens.Red, matrixDraw[0, 0], matrixDraw[0, 1], matrixDraw[(B.Length / 8) - 1, 0], matrixDraw[(B.Length / 8) - 1, 1]);
            //_graphics.DrawLine(Pens.Red, matrixDraw[(B.Length / 8) - 1 , 0], matrixDraw[(B.Length / 8) - 1, 1], matrixDraw[(B.Length / 4) - 1, 0], matrixDraw[(B.Length/4) - 1, 1]);
            //_graphics.DrawLine(Pens.Red, matrixDraw[(B.Length / 8) - 1 , 0], matrixDraw[(B.Length / 8) - 1, 1], matrixDraw[(B.Length / 4) - 1, 0], matrixDraw[(B.Length / 4) - 1, 1]);
        }

        //поместить буквы начального размера в центр системы координат
        private void buttonDeffaultPosition_Click(object sender, EventArgs e)
        {
            SetDefaultPosition();
            DrawB();
        }
        private void MoveX (int mi)
        {
            int toMove = mi * Convert.ToInt32(MoveTextBox.Text);
            float[,] Move =
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { toMove, 0, 0, 1}
            };
            B = Mult(B, Move);
            DrawB();
        }
        //движение вдоль OX в положительном направлении
        private void MovePlusX_Click(object sender, EventArgs e)
        {
            MoveX(1);
        }

        //движение вдоль OX в отрицательном направлении
        private void MoveMinusX_Click(object sender, EventArgs e)
        {
            MoveX(-1);
        }
        private void MoveY(int mi)
        {
            int toMove = mi * Convert.ToInt32(MoveTextBox.Text);
            float[,] Move =
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { 0, toMove, 0, 1}
            };
            B = Mult(B, Move);
            DrawB();
        }
        //движение вдоль OY в положительном направлении
        private void MovePlusY_Click(object sender, EventArgs e)
        {
            MoveY(1);
        }

        //движение вдоль OY в отрицательном направлении
        private void MoveMinusY_Click(object sender, EventArgs e)
        {
            MoveY(-1);
        }
        private void MoveZ(int mi)
        {
            int toMove = mi * Convert.ToInt32(MoveTextBox.Text);
            float[,] Move =
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, toMove, 1}
            };
            B = Mult(B, Move);
            DrawB();
        }
        //движение вдоль OB в положительном направлении
        private void MovePlusZ_Click(object sender, EventArgs e)
        {
            MoveZ(1);
        }

        //движение вдоль OB в отрицательном направлении
        private void MoveMinusZ_Click(object sender, EventArgs e)
        {
            MoveZ(-1);
        }

        //вращение вокруг OX вправо
        private void RotateRightX_Click(object sender, EventArgs e)
        {
            int toRotate = Convert.ToInt32(RotateTextBox.Text);
            //перевод в радианы
            float angle = (float)(toRotate * Math.PI /180);
            float[,] Rotate =
            {
                { 1, 0, 0, 0},
                { 0, (float)(Math.Cos(angle)), (float)(Math.Sin(angle)), 0},
                { 0, -(float)(Math.Sin(angle)), (float)(Math.Cos(angle)), 0},
                { 0, 0, 0, 1}
            };
            B = Mult(B, Rotate);
            DrawB();
        }

        //вращение вокруг OX влево
        private void RotateLeftX_Click(object sender, EventArgs e)
        {
            int toRotate = Convert.ToInt32(RotateTextBox.Text);
            //перевод в радианы
            float angle = (float)(toRotate * Math.PI / 180);
            float[,] Rotate =
            {
                { 1, 0, 0, 0},
                { 0, (float)Math.Cos(angle), -((float)(Math.Sin(angle))), 0},
                { 0, ((float)(Math.Sin(angle))), ((float)(Math.Cos(angle))), 0},
                { 0, 0, 0, 1}
            };
            B = Mult(B, Rotate);
            DrawB();
        }

        //вращение вокруг OY вправо
        private void RotateRightY_Click(object sender, EventArgs e)
        {
            int toRotate = Convert.ToInt32(RotateTextBox.Text);
            //перевод в радианы
            float angle = (float)(toRotate * Math.PI / 180);
            float[,] Rotate =
            {
                { ((float)(Math.Cos(angle))), 0, ((float)(Math.Sin(angle))), 0},
                { 0, 1, 0, 0},
                { -((float)(Math.Sin(angle))), 0, ((float)(Math.Cos(angle))), 0},
                { 0, 0, 0, 1}
            };
            B = Mult(B, Rotate);
            DrawB();
        }

        //вращение вокруг OY влево
        private void RotateLeftY_Click(object sender, EventArgs e)
        {
            int toRotate = Convert.ToInt32(RotateTextBox.Text);
            //перевод в радианы
            float angle = (float)(toRotate * Math.PI / 180);
            float[,] Rotate =
            {
                { ((float)(Math.Cos(angle))), 0, -((float)(Math.Sin(angle))), 0},
                { 0, 1, 0, 0},
                { ((float)(Math.Sin(angle))), 0, ((float)(Math.Cos(angle))), 0},
                { 0, 0, 0, 1}
            };
            B = Mult(B, Rotate);
            DrawB();
        }

        //вращение вокруг OB вправо
        private void RotateRightZ_Click(object sender, EventArgs e)
        {
            int toRotate = Convert.ToInt32(RotateTextBox.Text);
            //перевод в радианы
            float angle = (float)(toRotate * Math.PI / 180);
            float[,] Rotate =
            {
                { ((float)(Math.Cos(angle))), -((float)(Math.Sin(angle))), 0, 0},
                { ((float)(Math.Sin(angle))), ((float)(Math.Cos(angle))), 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, 0, 1}
            };
            B = Mult(B, Rotate);
            DrawB();
        }

        //вращение вокруг OB влево
        private void RotateLeftZ_Click(object sender, EventArgs e)
        {
            int toRotate = Convert.ToInt32(RotateTextBox.Text);
            //перевод в радианы
            float angle = (float)(toRotate * Math.PI / 180);
            float[,] Rotate =
            {
                { ((float)(Math.Cos(angle))), ((float)(Math.Sin(angle))), 0, 0},
                { -((float)(Math.Sin(angle))), ((float)(Math.Cos(angle))), 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, 0, 1}
            };
            B = Mult(B, Rotate);
            DrawB();
        }

        //отражение относительно плоскости XY
        private void MirrorXY_Click(object sender, EventArgs e)
        {
            float[,] Mirror =
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, -1, 0},
                { 0, 0, 0, 1}
            };
            B = Mult(B, Mirror);
            DrawB();
        }

        //отражение относительно плоскости XB
        private void MirrorXZ_Click(object sender, EventArgs e)
        {
            float[,] Mirror =
            {
                { 1, 0, 0, 0},
                { 0, -1, 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, 0, 1}
            };
            B = Mult(B, Mirror);
            DrawB();
        }

        //отражение относительно плоскости YB
        private void MirrorYZ_Click(object sender, EventArgs e)
        {
            float[,] Mirror =
            {
                { -1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, 0, 1}
            };
            B = Mult(B, Mirror);
            DrawB();
        }
        private void Stretch_func(double mi)
        {
            float[,] Stretch =
{
                { (float)mi, 0, 0, 0},
                { 0,  (float)mi, 0, 0},
                { 0, 0,  (float)mi, 0},
                { 0, 0, 0, 1}
            };
            B = Mult(B, Stretch);
            DrawB();
        }
        //растяжение
        private void Stretch_Click(object sender, EventArgs e)
        {
            Stretch_func(Convert.ToDouble(ScaleTB.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int vertexIndex = rand.Next(0, B.GetLength(0)); // случайный выбор вершины

            float randomX = (float)(rand.NextDouble() * 20 - 10); // случайный вектор смещения (от -10 до +10)
            float randomY = (float)(rand.NextDouble() * 20 - 10);
            float randomZ = (float)(rand.NextDouble() * 20 - 10);

            int steps = 100; // количество шагов для анимации
            int count = 0;
            Timer timer = new Timer();
            timer.Interval = 10; // задержка между шагами

            timer.Tick += (o, ev) =>
            {
                float t = (float)count / steps; // текущий коэффициент времени (0..1)

                // интерполяция: изменение позиции по синусоиде
                B[vertexIndex, 0] += t * randomX;
                B[vertexIndex, 1] += t * randomY;
                B[vertexIndex, 2] += t * randomZ;

                // Обновление отрисовки
                DrawB();

                count++;
                if (count >= steps)
                {
                    // Возвращаем назад
                    for (int i = 0; i < steps; i++)
                    {
                        t = (float)i / steps;
                        B[vertexIndex, 0] -= (float)(t * randomX);
                        B[vertexIndex, 1] -= (float)(t * randomY);
                        B[vertexIndex, 2] -= (float)(t * randomZ);
                        DrawB();
                        System.Threading.Thread.Sleep(10); // пауза для анимации
                    }
                    timer.Stop();
                }
            };

            timer.Start();
        }
    }

}

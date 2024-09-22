using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace kg_lab1
{
    public partial class MainForm : Form
    {
        private float[,] B;
        private float[,] proection;
        private int cenX;
        private int cenY;
        private Graphics _graphics;
        private float offsetX = -250;
        private float offsetY = -50;
        private float offsetZ = 0;
        private enum ActionType
        {
            MovePlusX,
            MoveMinusX,
            MovePlusY,
            MoveMinusY,
            MovePlusZ,
            MoveMinusZ,
            RotateRightX,
            RotateRightY,
            RotateRightZ,
            RotateLeftX,
            RotateLeftY,
            RotateLeftZ
        }

        private ActionType? currentAction = null;
        private Timer moveTimer;

        public MainForm() 
            => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e)
        {
            moveTimer = new Timer();
            moveTimer.Interval = 100; // Установите нужный интервал
            moveTimer.Tick += MoveTimer_Tick; // Подписка на событие

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

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            if (currentAction.HasValue)
            {
                switch (currentAction.Value)
                {
                    case ActionType.MovePlusX:
                        MoveX(1);
                        break;
                    case ActionType.MoveMinusX:
                        MoveX(-1);
                        break;
                    case ActionType.MovePlusY:
                        MoveY(1);
                        break;
                    case ActionType.MoveMinusY:
                        MoveY(-1);
                        break;
                    case ActionType.MovePlusZ:
                        MoveZ(1);
                        break;
                    case ActionType.MoveMinusZ:
                        MoveZ(-1);
                        break;
                    case ActionType.RotateRightX:
                        RotateX(1);
                        break;
                    case ActionType.RotateLeftX:
                        RotateX(-1);
                        break;
                    case ActionType.RotateRightY:
                        RotateY(1);
                        break;
                    case ActionType.RotateLeftY:
                        RotateY(-1);
                        break;
                    case ActionType.RotateRightZ:
                        RotateZ(1);
                        break;
                    case ActionType.RotateLeftZ:
                        RotateZ(-1);
                        break;

                }
            }
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

            float offsetX = -250;

            float offsetY = -50;

            float[,] Axis =
            {
                { offsetX, offsetY, 0, 1},          // Начало оси X
                { offsetX + 500, offsetY, 0, 1},    // Конец оси X
                { offsetX, offsetY + 400, 0, 1},     // Начало оси Y
                { offsetX, offsetY, 500, 1},         // Начало оси Z
                { offsetX + 490, offsetY + 5, 0, 1}, // Конец оси X стрелка
                { offsetX + 490, offsetY - 5, 0, 1}, // Конец оси X стрелка
                { offsetX + 5, offsetY + 390, 0, 1}, // Конец оси Y стрелка
                { offsetX - 5, offsetY + 390, 0, 1}, // Конец оси Y стрелка
                { offsetX + 12, offsetY, 495, 1},     // Конец оси Z стрелка
                { offsetX - 10, offsetY, 480, 1}      // Конец оси Z стрелка
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
            for (int i = 0; i < DefB.GetLength(0); i++)
            {
                DefB[i, 0] += offsetX;
                DefB[i, 1] += offsetY;
                DefB[i, 2] += offsetZ; 
            }
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
        }

        //поместить буквы начального размера в центр системы координат
        private void buttonDeffaultPosition_Click(object sender, EventArgs e)
        {
            SetDefaultPosition();
            DrawB();
        }
        private void MoveX (int toMove)
        {
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

        private void MoveY(int toMove)
        {
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

        private void MoveZ(int toMove)
        {
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

        private void RotateX(int toRotate)
        {
            //перевод в радианы
            float angle = (float)(toRotate * Math.PI / 180);
            float[,] Rotate =
            {
                { 1, 0, 0, 0},
                { 0, (float)(Math.Cos(angle)), ((float)(Math.Sin(angle))), 0},
                { 0, (-1)*((float)(Math.Sin(angle))), (float)(Math.Cos(angle)), 0},
                { 0, 0, 0, 1}
            };
            // Сдвиг всех точек к началу координат
            for (int i = 0; i < B.GetLength(0); i++)
            {
                B[i, 0] -= offsetX;
                B[i, 1] -= offsetY;
                B[i, 2] -= offsetZ; 
            }

            B = Mult(B, Rotate);

            for (int i = 0; i < B.GetLength(0); i++)
            {
                B[i, 0] += offsetX;
                B[i, 1] += offsetY;
                B[i, 2] += offsetZ; 
            }

            DrawB();
        }
        private void RotateY(int toRotate)
        {
            //перевод в радианы
            float angle = (float)(toRotate * Math.PI / 180);
            float[,] Rotate =
            {
                { ((float)(Math.Cos(angle))), 0, ((float)(Math.Sin(angle))), 0},
                { 0, 1, 0, 0},
                { (-1)*((float)(Math.Sin(angle))), 0, ((float)(Math.Cos(angle))), 0},
                { 0, 0, 0, 1}
            };
            // Сдвиг всех точек к началу координат
            for (int i = 0; i < B.GetLength(0); i++)
            {
                B[i, 0] -= offsetX;
                B[i, 1] -= offsetY;
                B[i, 2] -= offsetZ; 
            }

            B = Mult(B, Rotate);

            for (int i = 0; i < B.GetLength(0); i++)
            {
                B[i, 0] += offsetX;
                B[i, 1] += offsetY;
                B[i, 2] += offsetZ; 
            }
            DrawB();
        }
        private void RotateZ(int toRotate)
        {
            //перевод в радианы
            float angle = (float)(toRotate * Math.PI / 180);
            float[,] Rotate =
            {
                { ((float)(Math.Cos(angle))), ((float)(Math.Sin(angle))), 0, 0},
                { (-1)*((float)(Math.Sin(angle))), ((float)(Math.Cos(angle))), 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, 0, 1}
            };
            // Сдвиг всех точек к началу координат
            for (int i = 0; i < B.GetLength(0); i++)
            {
                B[i, 0] -= offsetX;
                B[i, 1] -= offsetY;
                B[i, 2] -= offsetZ; 
            }

            B = Mult(B, Rotate);

            for (int i = 0; i < B.GetLength(0); i++)
            {
                B[i, 0] += offsetX;
                B[i, 1] += offsetY;
                B[i, 2] += offsetZ; 
            }
            DrawB();
        }

        private void MirrotXYZ(int oX, int oY, int oZ)
        {

            float[,] Mirror =
            {
                { oZ, 0, 0, 0},
                { 0, oY, 0, 0},
                { 0, 0, oX, 0},
                { 0, 0, 0, 1}
            };
            B = Mult(B, Mirror);
            DrawB();
        }

        //отражение относительно плоскости XY
        private void MirrorXY_Click(object sender, EventArgs e)
        {
            MirrotXYZ(-1, 1, 1);
        }

        //отражение относительно плоскости XB
        private void MirrorXZ_Click(object sender, EventArgs e)
        {
            MirrotXYZ(1, -1, 1);
        }

        //отражение относительно плоскости YB
        private void MirrorYZ_Click(object sender, EventArgs e)
        {
            MirrotXYZ(1, 1, -1);
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
            for (int i = 0; i < B.GetLength(0); i++)
            {
                B[i, 0] -= offsetX;
                B[i, 1] -= offsetY;
                B[i, 2] -= offsetZ; 
            }

            B = Mult(B, Stretch);

            for (int i = 0; i < B.GetLength(0); i++)
            {
                B[i, 0] += offsetX;
                B[i, 1] += offsetY;
                B[i, 2] += offsetZ; 
            }
            DrawB();
        }

        //растяжение
        private void Stretch_Click(object sender, EventArgs e)
        {
            string input = ScaleTB.Text.Trim().Replace('.', ','); // Замена точки на запятую
            Stretch_func(Convert.ToDouble(input)); // Передача значения в функцию
        }


        private void MovePlusX_MouseDown(object sender, MouseEventArgs e)
        {
            currentAction = ActionType.MovePlusX; // Задаем текущее действие
            moveTimer.Start(); // Запускаем таймер
        }

        private void MoveMinusX_MouseDown(object sender, MouseEventArgs e)
        {
            currentAction = ActionType.MoveMinusX; // Задаем текущее действие
            moveTimer.Start(); // Запускаем таймер
        }


        private void Current_MouseUp(object sender, MouseEventArgs e)
        {
            currentAction = null; // Сбрасываем текущее действие
            moveTimer.Stop(); // Останавливаем таймер
        }

        private void MovePlusY_MouseDown(object sender, MouseEventArgs e)
        {
            currentAction = ActionType.MovePlusY; // Задаем текущее действие
            moveTimer.Start(); // Запускаем таймер
        }

        private void MoveMinusY_MouseDown(object sender, MouseEventArgs e)
        {
            currentAction = ActionType.MoveMinusY; // Задаем текущее действие
            moveTimer.Start(); // Запускаем таймер
        }

        private void MovePlusZ_MouseDown(object sender, MouseEventArgs e)
        {
            currentAction = ActionType.MovePlusZ; // Задаем текущее действие
            moveTimer.Start(); // Запускаем таймер
        }

        private void MoveMinusZ_MouseDown(object sender, MouseEventArgs e)
        {
            currentAction = ActionType.MoveMinusZ; // Задаем текущее действие
            moveTimer.Start(); // Запускаем таймер
        }

        private void RotateRightX_MouseDown(object sender, MouseEventArgs e)
        {
            currentAction = ActionType.RotateRightX; // Задаем текущее действие
            moveTimer.Start(); // Запускаем таймер
        }

        private void RotateLeftX_MouseDown(object sender, MouseEventArgs e)
        {
            currentAction = ActionType.RotateLeftX; // Задаем текущее действие
            moveTimer.Start(); // Запускаем таймер
        }

        private void RotateRightY_MouseDown(object sender, MouseEventArgs e)
        {
            currentAction = ActionType.RotateRightY; // Задаем текущее действие
            moveTimer.Start(); // Запускаем таймер
        }

        private void RotateLeftY_MouseDown(object sender, MouseEventArgs e)
        {
            currentAction = ActionType.RotateLeftY; // Задаем текущее действие
            moveTimer.Start(); // Запускаем таймер
        }

        private void RotateRightZ_MouseDown(object sender, MouseEventArgs e)
        {
            currentAction = ActionType.RotateRightZ; // Задаем текущее действие
            moveTimer.Start(); // Запускаем таймер
        }

        private void RotateLeftZ_MouseDown(object sender, MouseEventArgs e)
        {
            currentAction = ActionType.RotateLeftZ; // Задаем текущее действие
            moveTimer.Start(); // Запускаем таймер
        }

        private void MovingAPoint_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int vertexIndex = rand.Next(0, B.GetLength(0)); // случайный выбор вершины

            float randomX = (float)(rand.NextDouble() * 20 - 10); // случайный вектор смещения (от -10 до +10)
            float randomY = (float)(rand.NextDouble() * 20 - 10);
            float randomZ = (float)(rand.NextDouble() * 20 - 10);

            int steps = 100; // количество шагов для анимации
            int count = 0;
            Timer timer = new Timer();
            timer.Interval = 1; // задержка между шагами

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

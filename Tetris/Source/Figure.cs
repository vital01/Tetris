using System;
using System.Drawing;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Tetris
{ 
    public class Figure
    {
        public static bool ProjectionEnabled { get; set; }
        public static int BrickSize { get; set; }
        public static Color[] Colors { get; private set; }
        public static Point[][][] Schemas { get; private set; }
        //скорость при нажатии вниз
        private static int AccelerationTimeout { get; set; }                                  
        private static object LockObject { get; set; }
        //для активации падения фигуры
        private Game Game { get; set; }
        private bool Activated { get; set; }
        //ускорена?
        private bool Accelerated { get; set; }
        private bool Paused { get; set; }
        private int Id { get; set; } 
        //скорость падения, которую передаем при создании
        private int NormalTimeout { get; set; } 
        //текущая скорость
        private int Timeout { get; set; }
        //сколько осталось висеть после паузы
        private int LeftTimeout { get; set; }
        private Point Position { get; set; }
        //на пред шаге, чтобы вытереть
        private Point OldPosition { get; set; }
        private Point ProjectionPosition { get; set; }
        private Point OldProjectionPosition { get; set; }
        private int SchemaId { get; set; }
        private int OldSchemaId { get; set; }
        //отмена задержки
        private AutoResetEvent CancelTimeoutEvent { get; set; }
        private ManualResetEvent PauseEvent { get; set; }
        private Stopwatch Timer { get; set; }

        static Figure()
        {
            ProjectionEnabled = true;
            BrickSize = 25;
            AccelerationTimeout = 35;
            Colors = new Color[7] { Color.OrangeRed, Color.Red, Color.Blue, Color.Aqua, Color.Lime, Color.Magenta, Color.Yellow };
            Schemas = new Point[7][][]
            {
                #region T-фигура
                new Point[4][]
                {
                    new Point[4]
                    {
                        new Point(0, 0),
                        new Point(-1, 1),
                        new Point(0, 1),
                        new Point(1, 1)
                    },
                    new Point[4]
                    {
                        new Point(0, 0),
                        new Point(0, 1),
                        new Point(1, 1),
                        new Point(0, 2)
                    },
                    new Point[4]
                    {
                        new Point(-1, 1),
                        new Point(0, 1),
                        new Point(1, 1),
                        new Point(0, 2)
                    },
                    new Point[4]
                    {
                        new Point(0, 0),
                        new Point(0, 1),
                        new Point(-1, 1),
                        new Point(0, 2)
                    }
                },
                #endregion
                #region I-фигура
                new Point[2][]
                {
                    new Point[4]
                    {
                        new Point(-1, 1),
                        new Point(0, 1),
                        new Point(1, 1),
                        new Point(2, 1)
                    },
                    new Point[4]
                    {
                        new Point(0, 0),
                        new Point(0, 1),
                        new Point(0, 2),
                        new Point(0, 3)
                    }
                },
                #endregion
                #region O-фигура
                new Point[1][]
                {
                    new Point[4]
                    {
                        new Point(0, 0),
                        new Point(1, 0),
                        new Point(0, 1),
                        new Point(1, 1)
                    }
                },
                #endregion
                #region Z-Фигура
                new Point[2][]
                {
                    new Point[4]
                    {
                        new Point(0, 0),
                        new Point(-1, 0),
                        new Point(0, 1),
                        new Point(1, 1)
                    },
                    new Point[4]
                    {
                        new Point(1, 0),
                        new Point(1, 1),
                        new Point(0, 1),
                        new Point(0, 2)
                    }
                },
                #endregion
                #region S-фигура
                new Point[2][]
                {
                    new Point[4]
                    {
                        new Point(0, 0),
                        new Point(1, 0),
                        new Point(0, 1),
                        new Point(-1, 1)
                    },
                    new Point[4]
                    {
                        new Point(-1, 0),
                        new Point(-1, 1),
                        new Point(0, 1),
                        new Point(0, 2)
                    }
                },
                #endregion
                #region L-фигура
                new Point[4][]
                {
                    new Point[4]
                    {
                        new Point(1, 0),
                        new Point(1, 1),
                        new Point(0, 1),
                        new Point(-1, 1)
                    },
                    new Point[4]
                    {
                        new Point(0, 0),
                        new Point(0, 1),
                        new Point(0, 2),
                        new Point(1, 2)
                    },
                    new Point[4]
                    {
                        new Point(1, 1),
                        new Point(0, 1),
                        new Point(-1, 1),
                        new Point(-1, 2)
                    },
                    new Point[4]
                    {
                        new Point(-1, 0),
                        new Point(0, 0),
                        new Point(0, 1),
                        new Point(0, 2)
                    }
                },
                #endregion
                #region J-фигура
                new Point[4][]
                {
                    new Point[4]
                    {
                        new Point(-1, 0),
                        new Point(-1, 1),
                        new Point(0, 1),
                        new Point(1, 1)
                    },
                    new Point[4]
                    {
                        new Point(1, 0),
                        new Point(0, 0),
                        new Point(0, 1),
                        new Point(0, 2)
                    },
                    new Point[4]
                    {
                        new Point(-1, 1),
                        new Point(0, 1),
                        new Point(1, 1),
                        new Point(1, 2)
                    },
                    new Point[4]
                    {
                        new Point(0, 0),
                        new Point(0, 1),
                        new Point(0, 2),
                        new Point(-1, 2)
                    }
                }
                #endregion
            };
            LockObject = new object();
        }

        public Figure(Game game, int id, int timeout)
        {
            Game = game;
            Activated = false;
            Accelerated = false;
            Paused = false;
            Id = id;
            NormalTimeout = timeout;
            Timeout = NormalTimeout;
            LeftTimeout = Timeout;
            Position = new Point(Game.Field.ColumnCount / 2, 0);
            SchemaId = 0;
            CancelTimeoutEvent = new AutoResetEvent(false);
            PauseEvent = new ManualResetEvent(true);
            Timer = new Stopwatch();
        }

        public int Activate()
        {
            Task<int> task = Task.Factory.StartNew<int>
                (delegate()
                {
                    if (!CheckSuperposition(SchemaId))
                    {
                        Draw(clearOld: false);
                        Activated = true;
                        while (Activated)
                        {
                            Timer.Start();
                            CancelTimeoutEvent.WaitOne(LeftTimeout);
                            Timer.Stop();
                            PauseEvent.WaitOne();
                            if (Paused)
                            {
                                Paused = false;
                                if (Timer.ElapsedMilliseconds <= LeftTimeout)
                                {
                                    LeftTimeout -= Convert.ToInt32(Timer.ElapsedMilliseconds);
                                    continue;
                                }
                            }
                            lock (LockObject)
                            {
                                if (!Move(Direction.Down))
                                {
                                    Activated = false;
                                    for (int i = 0; i < 4; i++)
                                    {
                                        Game.Field.Matrix[Position.Y + Schemas[Id][SchemaId][i].Y, Position.X + Schemas[Id][SchemaId][i].X] = Id + 1;
                                    }
                                    SoundPlayer.PlaySound(SoundPlayer.Sounds.Hit);
                                }
                            }
                            LeftTimeout = Timeout;
                            Timer.Reset();
                        }
                        return TryClearLines();
                    }
                    else
                    {
                        return 5;
                    }
                });
            int result = task.Result;
            PauseEvent.WaitOne();
            return result;
        }

        public void Pause()
        {
            if (Game.Running)
            {
                if (!Paused)
                {
                    Paused = true;
                    PauseEvent.Reset();
                    CancelTimeoutEvent.Set();
                    MainForm.Instance.infoLabel.Visible = true;
                    MainForm.CenterInfoLabel("Pause");
                    SoundPlayer.PauseBackground();
                    SoundPlayer.PlaySound(SoundPlayer.Sounds.Pause);
                }
                else
                {
                    PauseEvent.Set();
                    MainForm.Instance.infoLabel.Visible = false;
                    SoundPlayer.ResumeBackground();
                }
            }
        }

        public void Accelerate()
        {
            if (!Paused && Activated)
            {
                Accelerated = true;                
                Timeout = AccelerationTimeout;
                CancelTimeoutEvent.Set();
            }
        }

        public void SlowDown()
        {
            if (Activated)
            {
                Accelerated = false;
                Timeout = NormalTimeout;
            }
        }

        public void Drop()
        {
            lock (LockObject)
            {
                if (!Paused && Activated)
                {
                    Position = ProjectionPosition;
                    Draw(drawProjection: false);
                    CancelTimeoutEvent.Set();
                }
            }
        }

        private int TryClearLines()
        {
            List<int> rowsNumbers;
            if (TryFindLines(out rowsNumbers))
            {
                Thread.Sleep(150);
                SoundPlayer.PlaySound(SoundPlayer.Sounds.Line);
                for (int j = 0; j < Game.Field.ColumnCount; j++)                
                {
                    Thread.Sleep(20);
                    int bricksCleared = 0;
                    for (int i = Game.Field.RowCount - 1; i >= 0; i--)
                    {
                        if (rowsNumbers.Contains(i))
                        {
                            Game.Field.ClearCell(Color.Black, new Point(j, i));
                            Game.Field.Matrix[i, j] = 0;
                            bricksCleared++;
                        }                   
                        if (bricksCleared == rowsNumbers.Count)
                        {
                            break;
                        }
                    }
                    Game.Field.Refresh();                  
                }
                Thread.Sleep(150);
                //опускание поля вниз
                for (int j = 0; j < Game.Field.ColumnCount; j++)
                {
                    int offset = 0;
                    for (int i = rowsNumbers[0]; i >= 0; i--)
                    {
                        if (rowsNumbers.Contains(i))
                        {
                            offset++;
                        }
                        else
                        {
                            if (Game.Field.Matrix[i, j] != 0)
                            {
                                Game.Field.ClearCell(Color.Black, new Point(j, i));
                                Game.Field.PaintCell(Colors[Game.Field.Matrix[i, j] - 1], new Point(j, i + offset));
                                Game.Field.Matrix[i + offset, j] = Game.Field.Matrix[i, j];
                                Game.Field.Matrix[i, j] = 0;
                            }
                        }
                    }
                }
                Game.Field.Refresh();
            }
            return rowsNumbers.Count;
        }

        private bool TryFindLines(out List<int> rowsNumbers)
        {
            rowsNumbers = new List<int>();
            for (int i = (Game.Field.RowCount - 1); i >= 0; i--)
            {
                int bricksCount = 0;
                for (int j = 0; j < Game.Field.ColumnCount; j++)
                {
                    if (Game.Field.Matrix[i, j] != 0)
                    {
                        bricksCount++;
                    }
                }
                if (bricksCount == Game.Field.ColumnCount)
                {
                    rowsNumbers.Add(i);
                }
                else
                {
                    if (bricksCount == 0)
                    {
                        if (rowsNumbers.Count != 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return false;
        }

        private void Draw(bool drawProjection = true, bool clearOld = true)
        {
            if (clearOld)
            {                
                for (int i = 0; i < 4; i++)
                {
                    if (ProjectionEnabled && drawProjection)
                    {
                        Game.Field.ClearCell(Color.Black, new Point(OldProjectionPosition.X + Schemas[Id][OldSchemaId][i].X, OldProjectionPosition.Y + Schemas[Id][OldSchemaId][i].Y));
                    }
                    Game.Field.ClearCell(Color.Black, new Point(OldPosition.X + Schemas[Id][OldSchemaId][i].X, OldPosition.Y + Schemas[Id][OldSchemaId][i].Y));
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (ProjectionEnabled && drawProjection)
                {
                    FindProjectionPosition();
                    Game.Field.PaintCell(Color.FromArgb(96, Colors[Id]), new Point(ProjectionPosition.X + Schemas[Id][SchemaId][i].X, ProjectionPosition.Y + Schemas[Id][SchemaId][i].Y));
                    OldProjectionPosition = ProjectionPosition;
                }
                Game.Field.PaintCell(Colors[Id], new Point(Position.X + Schemas[Id][SchemaId][i].X, Position.Y + Schemas[Id][SchemaId][i].Y));                
            }
            OldSchemaId = SchemaId;
            OldPosition = Position;
            Game.Field.Refresh();
        }       

        private void FindProjectionPosition()
        {
            ProjectionPosition = Position;
            while (!CheckCollision(Direction.Down, ProjectionPosition))
            {
                ProjectionPosition = new Point(ProjectionPosition.X, ProjectionPosition.Y + 1);
            }
        }

        private bool CheckCollision(Direction direction, Point position)
        {
            for (int i = 0; i < 4; i++)
            {
                if (direction == Direction.Down)
                {
                    if ((position.Y + Schemas[Id][SchemaId][i].Y) == (Game.Field.RowCount - 1) || Game.Field.Matrix[position.Y + Schemas[Id][SchemaId][i].Y + 1, position.X + Schemas[Id][SchemaId][i].X] != 0)
                    {
                        return true;
                    }
                }
                if (direction == Direction.Left)
                {
                    if ((position.X + Schemas[Id][SchemaId][i].X) == 0 || Game.Field.Matrix[position.Y + Schemas[Id][SchemaId][i].Y, position.X + Schemas[Id][SchemaId][i].X - 1] != 0)
                    {
                        return true;
                    }
                }
                if (direction == Direction.Right)
                {
                    if ((position.X + Schemas[Id][SchemaId][i].X) == (Game.Field.ColumnCount - 1) || Game.Field.Matrix[position.Y + Schemas[Id][SchemaId][i].Y, position.X + Schemas[Id][SchemaId][i].X + 1] != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool CheckSuperposition(int schemaId)
        {
            for (int i = 0; i < 4; i++)
            {
                if (Game.Field.Matrix[Position.Y + Schemas[Id][schemaId][i].Y, Position.X + Schemas[Id][schemaId][i].X] != 0)
                {
                    return true;
                }
            }
            return false;
        }

        //УДАЛИТЬ ЭТО!!!!
        private bool CheckOutOfBounds()
        {
            for (int i = 0; i < 4; i++)
            {
                if ((Position.X + Schemas[Id][(SchemaId + 1) % (Schemas[Id].Length)][i].X) < 0 || (Position.X + Schemas[Id][(SchemaId + 1) % (Schemas[Id].Length)][i].X) > (Game.Field.ColumnCount - 1) || (Position.Y + Schemas[Id][(SchemaId + 1) % (Schemas[Id].Length)][i].Y) > (Game.Field.RowCount - 1))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Move(Direction direction)
        {
            lock (LockObject)
            {
                if (!Paused && Activated && !CheckCollision(direction, Position))
                {
                    OldPosition = new Point(Position.X, Position.Y);
                    if (direction == Direction.Down)
                    {
                        Position = new Point(Position.X, Position.Y + 1);
                        Draw(drawProjection: false);
                    }
                    else
                    {
                        if (direction == Direction.Left)
                        {
                            Position = new Point(Position.X - 1, Position.Y);
                            Draw();
                        }
                        else
                        {
                            if (direction == Direction.Right)
                            {
                                Position = new Point(Position.X + 1, Position.Y);
                                Draw();
                            }
                        }
                    }                   
                    return true;
                }
                return false;
            }
        }

        public void Rotate()
        {           
            lock (LockObject)
            {
                if (!Paused && Activated && !CheckOutOfBounds() && !CheckSuperposition((SchemaId + 1) % (Schemas[Id].Length)))
                {
                    SchemaId = (SchemaId + 1) % (Schemas[Id].Length);
                    Draw();
                }
            }
        }
    }
}
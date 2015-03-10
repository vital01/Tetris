using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    public static class Drawing
    {
        public static void PaintCell(Graphics graphics, Color color, Point position)
        {
            graphics.DrawRectangle(new Pen(color, 2), position.X * Figure.BrickSize + 2, position.Y * Figure.BrickSize + 2, Figure.BrickSize - 4, Figure.BrickSize - 4);
        }

        public static void ClearCell(Graphics graphics, Color color, Point position)
        {
            graphics.FillRectangle(new SolidBrush(color), position.X * Figure.BrickSize, position.Y * Figure.BrickSize, Figure.BrickSize, Figure.BrickSize);
        }

        public static void RefreshImage(PictureBox pictureBox, Bitmap bitmap)
        {
            MainForm.BeginInvokeControl(pictureBox, new Action(() => { pictureBox.Image = bitmap; }));
        }

        public static void PaintBorder(Graphics graphics, Color color, Rectangle rectangle)
        {
            graphics.DrawRectangle(new Pen(color, 2), 1, 1, rectangle.Width - 2, rectangle.Height - 2);
        }
    }
}

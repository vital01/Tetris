using System.Drawing;

namespace Tetris
{
    public class Field
    {
        public int RowCount { get; private set; }
        public int ColumnCount { get; private set; }
        public int[,] Matrix { get; private set; }
        private Bitmap Bitmap { get; set; }
        private Graphics Graphics { get; set; }

        public Field()
        {
            RowCount = MainForm.Instance.fieldPicture.Height / Figure.BrickSize;
            ColumnCount = MainForm.Instance.fieldPicture.Width / Figure.BrickSize;
            Matrix = new int[RowCount, ColumnCount];
            Bitmap = new Bitmap(ColumnCount * Figure.BrickSize, RowCount * Figure.BrickSize);
            Graphics = Graphics.FromImage(Bitmap);
        }

        public void PaintCell(Color color, Point position)
        {
            Drawing.PaintCell(Graphics, color, position);
        }

        public void ClearCell(Color color, Point position)
        {
            Drawing.ClearCell(Graphics, color, position);
        }

        public void Refresh()
        {
            Drawing.RefreshImage(MainForm.Instance.fieldPicture, Bitmap);
        }
    }
}
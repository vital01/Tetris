using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    public class Field
    {
        public int RowCount { get; private set; }
        public int ColumnCount { get; private set; }
        public int[,] Matrix { get; private set; }
        private PictureBox FieldPicture { get; set; }
        private Bitmap Bitmap { get; set; }
        private Graphics Graphics { get; set; }

        public Field(PictureBox fieldPicture)
        {
            FieldPicture = fieldPicture;
            RowCount = FieldPicture.Height / Figure.BrickSize;
            ColumnCount = FieldPicture.Width / Figure.BrickSize;
            Matrix = new int[RowCount, ColumnCount];
            Bitmap = new Bitmap(ColumnCount * Figure.BrickSize, RowCount * Figure.BrickSize);
            Graphics = Graphics.FromImage(Bitmap);
        }

        public void PaintCell(Color color, Point position, bool dashed)
        {
            Drawing.PaintCell(Graphics, color, position, dashed);
        }

        public void ClearCell(Color color, Point position)
        {
            Drawing.ClearCell(Graphics, color, position);
        }

        public void Refresh()
        {
            Drawing.RefreshImage(FieldPicture, Bitmap);
        }
    }
}
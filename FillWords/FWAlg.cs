using System.Drawing;
using System.Windows.Forms;

namespace FillWords
{
    class FWAlg // fillword algorytm
    {
        DataGridView dgv;
        string[][] Matrix;
        string[] Words;
        bool Paint;
        string PickWord;
        Game OwnerF;

        //цвета
        public Color EmptyCell = properites.EmptyCell; // пустой
        public Color MouseDown = properites.MouseDown; //нажатие мыши
        public Color CheckStep = properites.CheckStep; //ход
        public Color TrueWord = properites.TrueWord; //правильное слово

        /// <summary>
        /// Конструирование сетки филлворда
        /// </summary>
        /// <param name="dgv">сетка DataGridViev</param>
        /// <param name="matrix">Думерный массив букв</param>
        /// <param name="words">Слова в сетке</param>
        /// <param name="size">ширина квардрата сетки</param>
        public FWAlg(DataGridView dgv, string[][] matrix, string[] words, int size, Game Owner)
        {
            Matrix = matrix;
            Words = words;
            this.dgv = dgv;
            this.OwnerF = Owner;
            Paint = false;

            dgv.RowCount = size;
            dgv.ColumnCount = size;
            dgv.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Red;
            dgv.ClearSelection();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    dgv[i, j].Value = Matrix[i][j];
                    dgv[i, j].Style.BackColor = EmptyCell;
                }
            }

            AutoSizeDGV(size);
        }

        public void OnMouseUp()
        {
            Paint = false;
            dgv.ClearSelection();
            for (int i = 0; i < Words.Length; i++)
            {
                if (PickWord == Words[i])
                {
                    Words[i] = "cheked";
                    OwnerF.TimeOnNoPlay = 0;
                    for (int j = 0; j < dgv.ColumnCount; j++)
                    {
                        for (int k = 0; k < dgv.RowCount; k++)
                        {
                            if (dgv[j, k].Style.BackColor == MouseDown)
                            {
                                dgv[j, k].Style.BackColor = TrueWord;
                            }
                        }
                    }
                }                    
            }
            PickWord = "";
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (dgv[i, j].Style.BackColor == MouseDown)
                        dgv[i, j].Style.BackColor = EmptyCell;
                    if (dgv[i, j].Style.BackColor == CheckStep)
                        dgv[i, j].Style.BackColor = EmptyCell;
                }
            }
        }

        private void AutoSizeDGV(int size)
        {
            int maxX = properites.CellSize, maxY = properites.CellSize;

            dgv.Width = (maxX + 1) * size;
            dgv.Height = (maxY + 1) * size;

            for (int i = 0; i < size; i++)
            {
                dgv.Columns[i].Width = maxX;
                dgv.Rows[i].Height = maxY;
            }
        }

        public void OnCellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Paint)
            {
                if (dgv[e.ColumnIndex, e.RowIndex].Style.BackColor == CheckStep)
                {
                    dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = MouseDown;
                    PickWord += dgv[e.ColumnIndex, e.RowIndex].Value.ToString();

                    // очистка подсказывающих клеток перед новыми подсказками
                    for (int i = 0; i < dgv.RowCount; i++)
                    {
                        for (int j = 0; j < dgv.ColumnCount; j++)
                        {
                            if (dgv[i, j].Style.BackColor == CheckStep)
                                dgv[i, j].Style.BackColor = EmptyCell;
                        }
                    }

                    // возможные ячейки для выбора
                    if (e.ColumnIndex < dgv.ColumnCount - 1)
                        if (dgv[e.ColumnIndex + 1, e.RowIndex].Style.BackColor == EmptyCell)
                            dgv[e.ColumnIndex + 1, e.RowIndex].Style.BackColor = CheckStep;

                    if (e.ColumnIndex > 0)
                        if (dgv[e.ColumnIndex - 1, e.RowIndex].Style.BackColor == EmptyCell)
                            dgv[e.ColumnIndex - 1, e.RowIndex].Style.BackColor = CheckStep;

                    if (e.RowIndex < dgv.RowCount - 1)
                        if (dgv[e.ColumnIndex, e.RowIndex + 1].Style.BackColor == EmptyCell)
                            dgv[e.ColumnIndex, e.RowIndex + 1].Style.BackColor = CheckStep;

                    if (e.RowIndex > 0)
                        if (dgv[e.ColumnIndex, e.RowIndex - 1].Style.BackColor == EmptyCell)
                            dgv[e.ColumnIndex, e.RowIndex - 1].Style.BackColor = CheckStep;
                }
            }
        }

        public void OnCellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv[e.ColumnIndex, e.RowIndex].Style.BackColor == TrueWord)
                dgv.DefaultCellStyle.SelectionBackColor = dgv[e.ColumnIndex, e.RowIndex].Style.BackColor;
            else
            {
                dgv.DefaultCellStyle.SelectionBackColor = MouseDown;
                Paint = true;
                dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = CheckStep;
                OnCellMouseEnter(sender, new DataGridViewCellEventArgs(e.ColumnIndex, e.RowIndex));
            }
        }

        public string ShowTip()
        {
            for (int i = 0; i < Words.Length; i++)
            {
                if (Words[i] != "cheked")
                    return Words[i];
            }
            return null;
        }
    }
}

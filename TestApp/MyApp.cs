using System;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.Threading;

namespace TestApp {
    public partial class MyApp : Form {
        public MyApp() {
            InitializeComponent();
            matrix.ColumnCount = 2;
            matrix.RowCount = 2;

            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 2; j++) {
                    matrix[j, i].Value = 0;
                }
            }
        }

        /// <summary>
        /// Увеличение размеров матрицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enlargeTheMatrixToolStripMenuItem_Click(object sender, EventArgs e) {
            matrix.ColumnCount++;
            matrix.RowCount++;
            int SIZE = matrix.Columns.Count;

            for (int i = 0; i < SIZE; i++) {
                for (int j = 0; j < SIZE; j++) {
                    if (i == SIZE - 1 || j == SIZE - 1) {
                        matrix[j, i].Value = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Уменьшение размеров матрицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reduseTheMatrixToolStripMenuItem_Click(object sender, EventArgs e) {
            if (matrix.ColumnCount == 1 && matrix.RowCount == 1) return;
            matrix.ColumnCount--;
            matrix.RowCount--;
        }

        /// <summary>
        /// Проверка, чтобы в ячейках не было других символов кроме цифр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void matrix_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            int i = e.ColumnIndex; int j = e.RowIndex;
            if (matrix[i, j].Value == null) return;
            int cellInt;
            bool isNum = int.TryParse(matrix[i, j].Value.ToString(), out cellInt);
            if (!isNum) 
                matrix[i, j].Value = 0;
        }

        /// <summary>
        /// Выполнение метода Гаусса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gaussMethodToolStripMenuItem_Click(object sender, EventArgs e) {
            GaussMethod.ServiceClient gaussClient = new GaussMethod.ServiceClient();
            int SIZE = matrix.Columns.Count;
            int inCnt = 0;
            bool flag = true;
            double[] inData = new double[SIZE * SIZE];
            for (int i = 0; i < SIZE; i++) {
                for (int j = 0; j < SIZE; j++) {
                    inData[inCnt++] = Convert.ToDouble(matrix[j, i].Value);
                    if (inData[inCnt - 1] != 0) flag = false;
                }
            }

            if (flag) {
                //значит матрица нулевая
                MessageBox.Show($"Определитель: 0");
                return;
            }

            //ЗАПУСК
            double[] outData = gaussClient.StartGauss(inData, SIZE);
            int outCnt = 0;
            for (int i = 0; i < SIZE; i++) {
                for (int j = 0; j < SIZE; j++) {
                    matrix[j, i].Value = outData[outCnt++];
                }
            }

            double det = outData[outCnt];
            MessageBox.Show($"Определитель: {det}");
            gaussClient.Close();
        }

        private void generateMatrixToolStripMenuItem_Click(object sender, EventArgs e) {
            int SIZE = matrix.Columns.Count;
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < SIZE; i++) {
                for (int j = 0; j < SIZE; j++) {
                    matrix[j, i].Value = rnd.Next(-30, 30);
                }
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Раздел тестируется :)");
            //GaussMethod.ServiceClient gaussClient = new GaussMethod.ServiceClient();

            //int SIZE = matrix.Columns.Count;
            //int inCnt = 0;
            //double[] inData = new double[SIZE * SIZE];
            //for (int i = 0; i < SIZE; i++) {
            //    for (int j = 0; j < SIZE; j++) {
            //        inData[inCnt++] = Convert.ToDouble(matrix[j, i].Value);
            //    }
            //}

            //double[] outData = gaussClient.GetObrMatrix(inData, SIZE);

            //int outCnt = 0;
            //for (int i = 0; i < SIZE - 1; i++) {
            //    for (int j = 0; j < SIZE - 1; j++) {
            //        matrix[j, i].Value = outData[outCnt++];
            //    }
            //}

            //gaussClient.Close();
        }
    }
}

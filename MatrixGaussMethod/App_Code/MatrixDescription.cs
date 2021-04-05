using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для MatrixDescription
/// </summary>
public class MatrixDesc {
    public int N { get; private set; }
    public double[,] Matrix { get; private set; }
    int realConst = 0;
    int sign = 0;

    public void StartGauss() {
        int real = 0;

        while (realConst <= N - 1)
            TransformMatrix(ref real, Matrix);
    }

    private double[,] TransformMatrix(ref int real, double[,] matr) {
        int i0 = real, j0 = real;

        if (matr[i0, j0] == 0) {
            var pos = SearchElementPosition(i0);
            i0 = pos.First;
            j0 = pos.Second;
        }

        //если мы тут значит элемент главной диагонали нам не подходит
        //и мы должны менять строки и столбцы 
        if (i0 != real && j0 != real) {
            swapStolb(real, j0);
            swapStr(real, i0);
        }
        else if (i0 == real && j0 != real) swapStolb(real, j0);
        else if (i0 != real && j0 == real) swapStr(real, i0);

        if (i0 != -1 && j0 != -1) {
            double del = matr[real, real];
            double checkNullStrings = 0;

            for (int i = real + 1; i < N; i++) {
                double realStr = matr[i, real];
                for (int j = real; j < N; j++) {
                    //вычитаем из предыдущей строки текущую умноженную на элемент гл диагонали
                    matr[i, j] = -1 * ((matr[real, j] / del) * realStr - matr[i, j]);
                    checkNullStrings += matr[i, j];
                }

            }

            if (checkNullStrings == 0) real--;
        }

        real++;
        realConst++;
        return matr;
    }   //Гаусс
    private Pair SearchElementPosition(int real) {
        double elemenet = 0;
        Pair minPosition = new Pair(real, real);
        for (int i = real; i < N; i++)
            for (int j = 0; j < N; j++)
                if (Matrix[i, j] != 0) {
                    minPosition = new Pair(i, j);
                    elemenet = Matrix[i, j];
                    return minPosition;
                }

        if (elemenet == 0) return new Pair(-1, -1);
        return minPosition;
    }     //поиск координат ненулевого элемента матрицы
    private double[,] swapStolb(int real, int j0) {
        if (sign > 0) sign--;
        else sign++;
        for (int i = real; i < Matrix.GetLength(0); i++) {
            double tmp = Matrix[i, real];
            Matrix[i, real] = Matrix[i, j0];
            Matrix[i, j0] = tmp;
        }

        return Matrix;
    }     //перестановка столбцов
    private double[,] swapStr(int real, int i0) {
        if (sign > 0) sign--;
        else sign++;
        for (int j = real; j < Matrix.GetLength(1); j++) {
            double tmp = Matrix[real, j];
            Matrix[real, j] = Matrix[i0, j];
            Matrix[i0, j] = tmp;
        }

        return Matrix;
    }       //перестановка строк

    private double[,] GetAlgDop(double[,] matrix, int ii, int jj) {
        int size = matrix.GetLength(1);
        double[,] algDop = new double[size - 1, size - 1];
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                if (i == ii || j == jj) continue;
                if (i < ii && j < jj) algDop[i, j] = matrix[i, j];
                else if (i < ii && j > jj) algDop[i, j - 1] = matrix[i, j];
                else if (i > ii && j < jj) algDop[i - 1, j] = matrix[i, j];
                else if (i > ii && j > jj) algDop[i - 1, j - 1] = matrix[i, j];
            }
        }

        return algDop;
    }



    public void StartObrMatrix() {
        double[,] algDopMatrix = new double[N, N];

        //Ищем матрицу алгебраических дополнений (союзную матрицу)
        for (int i = 0; i < N; i++) {
            for (int j = 0; j < N; j++) {
                double[,] algDop = GetAlgDop(Matrix, i, j);

                int real = 0;
                while (realConst <= N - 2)
                    TransformMatrix(ref real, algDop);

                double det = 1;
                for (int ii = 0; ii < N - 1; ii++)
                    for (int jj = 0; jj < N - 1; jj++)
                        if (ii == jj) det *= algDop[ii, jj];

                algDopMatrix[i, j] = det;
            }
        }

        //Транспонируем союзную матрицу
        for (int i = 0; i < N; i++) {
            for (int j = 0; j < N; j++) {
                if (i == j) continue;
                double tmp = algDopMatrix[i, j];
                algDopMatrix[i, j] = algDopMatrix[j, i];
                algDopMatrix[j, i] = tmp;
            }
        }

        int real1 = 0;
        var dupplicateMatrix = Matrix;
        while (realConst <= N - 1)
            TransformMatrix(ref real1, dupplicateMatrix);

        double det1 = 1;
        for (int i = 0; i < N; i++) {
            for (int j = 0; j < N; j++) {
                if (i == j) det1 *= dupplicateMatrix[i, j];
            }
        }

        for (int i = 0; i < N; i++) {
            for (int j = 0; j < N; j++) {
                algDopMatrix[i, j] /= det1;
            }
        }

        Matrix = algDopMatrix;
    }

    public MatrixDesc() { }
    //Создание матрицы
    public MatrixDesc(double[,] matrix, int size) {
        Matrix = matrix;
        N = size;
    }
}
public class Pair {
    public int First { get; set; }
    public int Second { get; set; }

    public Pair() { }
    public Pair(int first, int second) {
        First = first;
        Second = second;
    }
}
using System.Configuration;

public class Service : IService
{
	public double[] StartGauss(double[] matrix, int size)
	{
		double[,] inData = new double[size, size];
		int inCnt = 0;
		for (int i = 0; i < size; i++) {
			for (int j = 0; j < size; j++) {
				inData[i, j] = matrix[inCnt++];
            }
        }

		MatrixDesc matrixDesc = new MatrixDesc(inData, size);
		matrixDesc.StartGauss();

		var outData = matrixDesc.Matrix;
		double[] result = new double[matrix.Length + 1]; 
		int outCnt = 0; double det = 1;
		for (int i = 0; i < size; i++) {
			for (int j = 0; j < size; j++) {
				if (i == j) det *= outData[i, j];
				result[outCnt++] = outData[i, j];
			}
		}

		result[outCnt] = det;

		return result;
	}
    public double[] GetObrMatrix(double[] matrix, int size) {
        double[,] inData = new double[size, size];
        int inCnt = 0;
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                inData[i, j] = matrix[inCnt++];
            }
        }

        MatrixDesc matrixDesc = new MatrixDesc(inData, size);
        matrixDesc.StartObrMatrix();

        var outData = matrixDesc.Matrix;
        double[] result = new double[size * size];
        int outCnt = 0; 
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size - 1; j++) {
                result[outCnt++] = outData[i, j];
            }
        }

        return result;
    }
}

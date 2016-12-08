class MatrixRotate
{
	public void toRight90(ref int[,] m)
	{
		int row = m.GetLength(0);
		int col = m.GetLength(1) -1;
		int tmp;
		for (int i = 0; i < row / 2; i++)
		{
			for (int j = i; j < col  - i; j++)
			{
				tmp = m[i, j];
				m[i, j] = m[row - 1 - j, i];
				m[row - 1 - j, i] = m[row - 1 - i, col  - j];
				m[row - 1 - i, col - j] = m[j, col  - i];
				m[j, col - i] = tmp;
			}
		}
	}
	public void toLeft90(ref int[,] m)
	{
		int row = m.GetLength(0);
		int col = m.GetLength(1) - 1;
		int tmp;

		for (int i = 0; i < row / 2; i++)
		{
			for (int j = i; j < col - i; j++)
			{
				tmp = m[j, i];
				m[j, i] = m[i, col - j];
				m[i, col - j] = m[col  - j, row - 1 - i];
				m[col  - j, row - 1 - i] = m[row - 1 - i, j];
				m[row - 1 - i, j] = tmp;
			}
		}
	}
	public void reverseMatrixTopToButtom(ref int[,] m)
	{
		int row = m.GetLength(0);
		int col = m.GetLength(1);
		int tmp;
		for (int i = 0; i < row / 2; i++)
		{
			for (int j = 0; j < col; j++)
			{
				tmp = m[i, j];
				m[i, j] = m[col - 1 - i, j];
				m[col - 1 - i, j] = tmp;
			}
		}
	}
	public void reverseMatrixLeftToRight(ref int[,] m)
	{
		int row = m.GetLength(0);
		int col = m.GetLength(1);
		int tmp;
		for (int i = 0; i < row; i++)
		{
			for (int j = 0; j < col / 2; j++)
			{
				tmp = m[i, j];
				m[i, j] = m[i, col - 1 - j];
				m[i, col - 1 - j] = tmp;
			}
		}
	}
}

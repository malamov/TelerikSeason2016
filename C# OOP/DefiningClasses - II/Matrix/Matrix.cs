using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix<T> where T : IComparable<T>
    {
        private T[,] matrix;

        public Matrix(int row,int col)
        {
            this.matrix = new T[row, col];
        }

        public T this[int row,int col]
        {
            get
            {
               return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int r = 0; r < this.matrix.GetLength(0); r++)
            {
                for (int c = 0; c < this.matrix.GetLength(1); c++)
                {
                    sb.AppendFormat("{0,3}", matrix[r, c]);
                }
                sb.Append("\n");
            }

            return sb.ToString();
        }
        
        public static Matrix<T> operator +(Matrix<T>m1, Matrix<T> m2)
        {
            if (m1.matrix.GetLength(0) != m1.matrix.GetLength(0)
                || m1.matrix.GetLength(1) != m1.matrix.GetLength(1))
            {
                throw new ArgumentException("Matreces are not equal");
            }
            var result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(0));

            for (int row = 0; row < m1.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < m1.matrix.GetLength(1); col++)
                {
                    result[row, col] = (dynamic)m1[row, col] + (dynamic)m2[row, col];
                }   
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.matrix.GetLength(0) != m1.matrix.GetLength(0)
                || m1.matrix.GetLength(1) != m1.matrix.GetLength(1))
            {
                throw new ArgumentException("Matreces are not equal");
            }
            var result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(0));

            for (int row = 0; row < m1.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < m1.matrix.GetLength(1); col++)
                {
                    result[row, col] = (dynamic)m1[row, col] - (dynamic)m2[row, col];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.matrix.GetLength(0) != m1.matrix.GetLength(0)
               || m1.matrix.GetLength(1) != m1.matrix.GetLength(1))
            {
                throw new ArgumentException("Matreces are not equal");
            }
            var result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(0));

            for (int row = 0; row < m1.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < m1.matrix.GetLength(1); col++)
                {
                    result[row, col] = (dynamic)m1[row, col] * (dynamic)m2[row, col];
                }
            }
            return result;
        }

        

    }
}

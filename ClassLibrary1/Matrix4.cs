using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public struct Matrix4
    {
        private float[,] matr;
        public Matrix4(float[,] m)
        {
            matr = new float[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    matr[i, j] = m[i, j];
        }
        public float this[int i, int j]
        {
            get { return matr[i, j]; }
            set { matr[i, j] = value; }
        }
        public static Matrix4 Zero()
        {
            return new Matrix4(new float[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } });
        }
        public static Matrix4 One()
        {
            return new Matrix4(new float[,]
            {
                { 1,0,0,0},
                { 0,1,0,0},
                { 0,0,1,0},
                { 0,0,0,1}
            });
        }
        public static Vector4 operator *(Matrix4 m, Vector4 v)
        {
            Vector4 r = Vector4.Zero();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    r[i] += m[i, j] * v[j];
            return r;
        }
        public static Matrix4 operator *(Matrix4 m1, Matrix4 m2)
        {
            Matrix4 r = Zero();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    for (int k = 0; k < 4; k++)
                        r[i, j] += m1[i, k] * m2[k, j];
            return r;
        }
        public static Matrix4 Rotate(int ia, float angle)
        {
            int a1 = (ia + 1) % 3;
            int a2 = (ia + 2) % 3;
            Matrix4 m = One();
            m[a1, a1] = (float)Math.Cos(angle);
            m[a1, a2] = (float)-Math.Sin(angle);
            m[a2, a1] = (float)Math.Sin(angle);
            m[a2, a2] = (float)Math.Cos(angle);
            return m;
        }

        public static Matrix4 Rotate(int ia, float cosAngle, float sinAngle)
        {
            int a1 = (ia + 1) % 3;
            int a2 = (ia + 2) % 3;
            Matrix4 m = One();
            m[a1, a1] = cosAngle;
            m[a1, a2] = -sinAngle;
            m[a2, a1] = sinAngle;
            m[a2, a2] = cosAngle;
            return m;
        }

        public static Matrix4 Translate(float dx, float dy, float dz) // смещение фигуры
        {
            Matrix4 m = new Matrix4(new float[,]
            {
                { 1, 0, 0, dx },
                { 0, 1, 0, dy },
                { 0, 0, 1, dz },
                { 0, 0, 0, 1 },
            });
            return m;
        }

        public static Matrix4 TranslateReverse(float dx, float dy, float dz) // смещение фигуры
        {
            Matrix4 m = new Matrix4(new float[,]
            {
                { 1, 0, 0, -dx },
                { 0, 1, 0, -dy },
                { 0, 0, 1, -dz },
                { 0, 0, 0, 1 },
            });
            return m;
        }

        private double Det(Matrix4 m, int s)
        {
            Matrix4 t = new Matrix4();
            double det = 0;
            for (int i = 0; i < s; i++)
            {
                int a = 0;
                for(int j = 1; j < s; j++)
                {
                    int b = 0;
                    for(int r = 0; r < s; r++)
                    {
                        if(r != i)
                        {
                            t[a, b] = m[j, r];
                        }
                    } a++;
                }
                det += Math.Pow(-1, i + 2) * m[0, i] * Det(t, 3);
            }
            return det;
        } 

        public Matrix4 Reverse(Matrix4 m, int s)
        {
            double det = Det(m, s);
            Matrix4 t = new Matrix4();
            Matrix4 reverse = new Matrix4();
            for(int i = 0; i < s; i++)
            {
                for(int j = 0; j < s; j++)
                {
                    int r = 0, y = 0;
                    for(int a = 0; a < s; a++)
                    {
                        for(int b = 0; b < s; b++)
                            if((i != a) && (j != b))
                            {
                                t[r, y] = m[a, b];
                                y++;
                                if(y >= s-1)
                                {
                                    r++;
                                    y = 0;
                                }
                            }
                    }
                    reverse[i, j] = (float)(Math.Pow(-1, j + i + 2) * Det(t, s - 1) / det);
                }               
            }
            return reverse;
        }
    }
}

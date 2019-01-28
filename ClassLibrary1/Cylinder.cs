using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cylinder : IModel
    {
        public Vector3 TLF { get; set; } //top left far
        public Vector3 BRN { get; set; } // bottom right near 
        public int N { get; set; }
        public float Radius { get; set; }
        public Cylinder(Vector3 tlf, Vector3 brn, float radius)
        {
            TLF = tlf;
            BRN = brn;
            Radius = radius;
            N = 32;
        }

        public List<PolyLine3D> GetLines()
        {
            var l = new List<PolyLine3D>();
            List<Vector3> up = new List<Vector3>();
            List<Vector3> down = new List<Vector3>();
            float r = Radius;
            Vector3 yellowVector = new Vector3(TLF.X - BRN.X, TLF.Y - BRN.Y, TLF.Z - BRN.Z);
            Vector3 blueVector = new Vector3(TLF.X - BRN.X, 0, TLF.Z - BRN.Z);
            float cosangleZ, cosangleY, sinangleZ, sinangleY;
            cosangleY = yellowVector.Z / blueVector.Length;
            sinangleY = yellowVector.X / blueVector.Length;
            cosangleZ = blueVector.Length / yellowVector.Length;
            sinangleZ = yellowVector.Y / yellowVector.Length;
            Matrix4 R = Matrix4.Rotate(2, cosangleZ, sinangleZ) * Matrix4.Rotate(1, cosangleY, sinangleY);


            for(int i = 0; i < N + 1; i++)
            {
                double angle = 2 * Math.PI * i / N;
                Vector3 tempUp = new Vector3((float)(r * Math.Cos(angle)), (float)(r * Math.Sin(angle)), 0);

                Vector4 newUp = new Vector4(tempUp);                
                newUp = (Matrix4.Translate(TLF.X, TLF.Y, TLF.Z) * R * newUp).Normalized;
                Vector4 newDown = new Vector4(newUp.X + yellowVector.X, newUp.Y + yellowVector.Y, newUp.Z + yellowVector.Z);

                Vector3 resultUp = new Vector3(newUp);
                Vector3 resultDown = new Vector3(newDown);

                up.Add(resultUp);
                down.Add(resultDown);

                l.Add(new PolyLine3D(new List<Vector3>()
                {
                    new Vector3(newUp.X,newUp.Y,newUp.Z),
                    new Vector3(newDown.X,newDown.Y,newDown.Z)
                }));
            }

            l.Add(new PolyLine3D(up));
            l.Add(new PolyLine3D(down));
            return l;
        }
    }
}

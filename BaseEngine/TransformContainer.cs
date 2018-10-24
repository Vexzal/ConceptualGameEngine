using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Jitter.DataStructures;
using Jitter.LinearMath;
namespace BaseEngine.Components
{
    public class TransformContainer
    {
        //position
        float x;
        float y;
        float z;

        //rotation
        Quaternion rotation;

        //scale 
        float sx;
        float sy;
        float sz;

        public TransformContainer()
        {
            x = 0;
            y = 0;
            z = 0;

            rotation = Quaternion.Identity;

            sx = 1;
            sy = 1;
            sz = 1;
        }
        public JVector GetJVector()
        {
            return new JVector(x, y, z);
        }
        public Vector3 GetVector()
        {
            return new Vector3(x, y, z);
        }
        public Matrix GetWorld()
        {
            return Matrix.CreateScale(sx, sy, sz) * Matrix.CreateFromQuaternion(rotation) * Matrix.CreateTranslation(x, y, z);
        }
        public void SetPosition(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public void SetRotation(Quaternion rot)
        {
            rotation = rot;
        }
        public void SetScale(float _sx, float _sy, float _sz)
        {
            sx = _sx;
            sy = _sy;
            sz = _sz;
        }


    }
}

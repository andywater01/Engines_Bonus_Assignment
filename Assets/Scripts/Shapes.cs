using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.ShapeSpawner
{
    //Monster parent class
    public abstract class _Shapes
    {
        //This method implements the Prototype design pattern
        public abstract _Shapes Clone();

        public abstract void Move();
    }
}

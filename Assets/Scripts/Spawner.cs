using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.ShapeSpawner
{
    public class Spawner
    {
        private _Shapes prototype;

        public Spawner(_Shapes prototype)
        {
            this.prototype = prototype;
        }

        public _Shapes SpawnShape()
        {
            return prototype.Clone();
        }
    }
}
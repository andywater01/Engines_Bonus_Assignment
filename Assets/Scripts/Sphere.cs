using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.ShapeSpawner
{
    public class Sphere : _Shapes
    {
        private int radius;
        private GameObject go;
        private Transform transform;
        

        private static int sphereCounter = 0;

        public Sphere(int radius, GameObject go, Transform transfrom)
        {
            this.radius = radius;
            this.go = go;
            this.transform = transform;
            

            sphereCounter += 1;
        }

        public override _Shapes Clone()
        {
            return new Sphere(radius, go, transform);
        }

        public override void Move()
        {
            //Debug.Log($"Worked");
            Debug.Log($"Hello this is shape number {sphereCounter}. My radius is {radius}");

        }
    }
}
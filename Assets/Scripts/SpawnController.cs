using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.ShapeSpawner
{
    public class SpawnController : MonoBehaviour
    {

        private Sphere spherePrototype;

        public Transform t;

        public GameObject go;

        private Spawner[] shapeSpawners;


        void Start()
        {

            spherePrototype = new Sphere(2, go, t);

            shapeSpawners = new Spawner[] {

                new Spawner(spherePrototype),


            };

        }


        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //If we know which spawner we are using we can easily cast to the correct monster type
                Spawner sphereSpawner = new Spawner(spherePrototype);
                

                Sphere newSphere = sphereSpawner.SpawnShape() as Sphere;
                

                newSphere.Move();
                
            }
        }
    }
}

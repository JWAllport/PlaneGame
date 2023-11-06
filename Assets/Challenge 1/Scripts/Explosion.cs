using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    GameObject Plane;
    public Explosion()
    {

        void OnCollisionEnter() {

            Destroy(Plane);


        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    public float lifeTime = 1;
    void Awake(){
        Destroy(gameObject, lifeTime);
    }
}

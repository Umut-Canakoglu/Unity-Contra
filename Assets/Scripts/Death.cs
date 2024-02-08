using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public float lifeTime = 2;
    void Awake(){
        Destroy(gameObject, lifeTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public float lifeTime = 3;
    void Awake(){
        Destroy(gameObject, lifeTime);
    }
}

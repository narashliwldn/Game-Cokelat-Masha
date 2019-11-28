using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public int xDirection;
    public float destroyPoint;

    // Update is called once per frame
    void Update()
    {
        if(xDirection < 0 && transform.position.x <= destroyPoint){
            Destroy(this.gameObject);
        }
        else if(xDirection > 0 && transform.position.x > destroyPoint){
            Destroy(this.gameObject);
        }
    }
}

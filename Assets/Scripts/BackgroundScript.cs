using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    public float xLeft, xRight;

    // Update is called once per frame
    void Update()
    {
        if(transform.localPosition.x <= xLeft){
            transform.localPosition = new Vector3(xRight,0,0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    Vector3 playerPos;
    public float speedX, speedY;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedX,speedY,0);
    }
}

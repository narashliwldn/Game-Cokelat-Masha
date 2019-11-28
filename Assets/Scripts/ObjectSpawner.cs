using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnPosX = 16;
    public float xLeft, xRight;
    public float spawnTime;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer<=0){
            GameObject obj = Instantiate(objectToSpawn, this.transform);
            obj.transform.localPosition = new Vector3(spawnPosX, Random.Range(xLeft, xRight),0);
            timer = spawnTime;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveDriverScript : MonoBehaviour
{

    public GameObject objs;
    public float spawnterval;
    private float timer;
    public float heightOffset;
    public float zOffset;

    // Start is called before the first frame update
    void Start()
    {
        driveObjs();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnterval) timer += Time.deltaTime;
        else
        {
            driveObjs();
            timer = 0;
        }

        if (Input.GetKey(KeyCode.Escape)) { Application.Quit(); }
    }

    void driveObjs()
    {
        float ylo = transform.position.y + heightOffset;
        float yhi = transform.position.y - heightOffset;
        float zlo = transform.position.z + zOffset;
        float zhi = transform.position.z - zOffset;
        Instantiate(objs, new Vector3(transform.position.x, Random.Range(ylo, yhi), 0), transform.rotation);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewDriverScript : MonoBehaviour
{

    public float moveSpeed = 1;
    public float driverDeadZone = -2;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < driverDeadZone) Destroy(gameObject);
    }

}

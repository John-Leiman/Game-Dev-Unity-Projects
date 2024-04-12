using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonCoreScript : MonoBehaviour
{

    public Rigidbody2D demonCore;
    public float flapStrength;
    public LogicScript logic;
    public bool criticality = false;
    public float coreLo = -2.5f;
    public float coreHi = 2.5f;
    public float timer;
    public float flyterval = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if (timer < flyterval) timer += Time.deltaTime;
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) && !criticality)
            {
                demonCore.velocity = Vector2.up * flapStrength;
                timer = 0;
            }
        }
        if ((transform.position.y < coreLo || coreHi < transform.position.y) && !criticality)
        {
            logic.goCritical();
            criticality = true;
        }
        if (transform.position.y < coreLo) Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!criticality)
        {
            logic.goCritical();
            criticality = true;
        }
    }

}

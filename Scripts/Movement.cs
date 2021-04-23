using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float velocity = 1f;

    public float jumpVel = 1f;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) { transform.position += new Vector3(velocity, 0, 0); }

        if (Input.GetKey(KeyCode.A)) { transform.position += new Vector3(-velocity, 0, 0); }

        if (Input.GetKeyDown(KeyCode.Space)) { transform.position += new Vector3(0, jumpVel, 0); }
    }
}

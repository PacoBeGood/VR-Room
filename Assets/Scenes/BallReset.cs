using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{

    void Update()
    {
        if (transform.position.y < 2)
        {
            transform.position = new Vector3(-0.2329339f,1.774077f,-0.045101f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CanReset : MonoBehaviour
{

    void Update()
    {
        if (transform.position.y < 2)
        {
            Destroy(gameObject);
        }

    }
}

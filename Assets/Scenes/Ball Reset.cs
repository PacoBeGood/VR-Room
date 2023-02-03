using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    [SerializeField] private GameObject bal;
    private GameObject bal2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bal")
        {
            Destroy(other);
            bal2 = Instantiate(bal);
            bal2.transform.position = new Vector3(-0.2329339f,1.774077f-0.045101f);
        }
    }
}

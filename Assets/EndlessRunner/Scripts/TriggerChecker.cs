using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ball") {
            FallDown();
        }
    }

    private void FallDown()
    {
       GetComponentInParent<Rigidbody>().useGravity = true;
    }
}

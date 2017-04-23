using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoScript : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Creep") && this.gameObject.CompareTag("US"))
        {
            Destroy(other.gameObject);
        }
        if(other.CompareTag("USSR"))
        {
            other.gameObject.GetComponent<PlayerController>().health -= 25;
        }
        if(other.CompareTag("US"))
        {
            other.gameObject.GetComponent<PlayerController>().health -= 25;

        }
    }

}

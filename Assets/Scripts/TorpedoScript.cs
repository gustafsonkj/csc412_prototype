using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoScript : MonoBehaviour {

    public WinConditions wc;
    public float speed;
    public GameObject explosion;

	// Use this for initialization
	void Start ()
    {
        wc = GameObject.Find("GameManager").GetComponent<WinConditions>();
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("SpawnPoint"))
            return;

        if (other.CompareTag("Creep") && this.gameObject.CompareTag("USTorpedo"))
        {
            Destroy(other.gameObject);
            Instantiate(explosion, other.transform.position, Quaternion.identity);
            wc.score++;
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

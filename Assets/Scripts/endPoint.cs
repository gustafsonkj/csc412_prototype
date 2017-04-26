using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endPoint : MonoBehaviour {

    public WinConditions wc;
    public int creepsThrough;
    public UnityEngine.UI.Text shipCount;

    // Use this for initialization
    void Start ()
    {
        creepsThrough = 0;
        //text = GameObject.Find("WinText");
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(creepsThrough > 19 && !wc.won)
        {
            wc.USLose();
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Creep"))
        {
            Destroy(other.gameObject);
            creepsThrough++;
            shipCount.text = "" + creepsThrough;
        }
    }
}

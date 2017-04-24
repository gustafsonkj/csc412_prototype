using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endPoint : MonoBehaviour {


    public int count;
    public GameObject text;

	// Use this for initialization
	void Start ()
    {
        count = 0;
        //text = GameObject.Find("WinText");
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(count > 19)
        {
            //text.GetComponent<GUIText>().text = "MURICA";
            Debug.Log("Screw you, MURICA wins");
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Creep"))
        {
            Destroy(other.gameObject);
            count++;
        }
    }
}

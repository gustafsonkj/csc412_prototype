using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobUpAndDown : MonoBehaviour {

    public float amplitude;          //Set in Inspector 
    public float speed;                  //Set in Inspector 
    public float tempVal;
    public Vector3 tempPos;
    // Use this for initialization
    void Start () {
        tempVal = transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {
        tempPos.y = tempVal + amplitude * Mathf.Sin(speed * Time.time);
        transform.position = tempPos;

    }
}

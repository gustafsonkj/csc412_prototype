﻿using UnityEngine;
using System.Collections;

public class ChangeDirection : MonoBehaviour
{

    public Vector3 newDirection1 = new Vector3();
    public Vector3 newDirection2 = new Vector3();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        EnemyUnit eu = other.gameObject.GetComponent<EnemyUnit>();
        int dir = Random.Range(0, 2);

        eu.GetComponent<Rigidbody>().velocity = Vector3.zero;

        if (eu != null)
        {
            if (dir == 0)
            {
                eu.velocity.x = newDirection1.x * 100.0f;
                eu.velocity.y = newDirection1.y * 100.0f;
                eu.velocity.z = newDirection1.z * 100.0f;
            }
            else if (dir == 1)
            {
                eu.velocity.x = newDirection2.x * 100.0f;
                eu.velocity.y = newDirection2.y * 100.0f;
                eu.velocity.z = newDirection2.z * 100.0f;
            }
        }
    }
}

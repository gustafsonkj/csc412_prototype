using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public GameObject player;
    public GameObject Torpedo;
    public float speed;
    public float rotateSpeed;
    public float lifetime;
    public Component[] rends;
    public Transform fireTransform;
    public float health;

    void Start ()
    {
        rends = GetComponentsInChildren<Renderer>();
		if (player.CompareTag("US"))
        {
            speed = 20f;
            rotateSpeed = 100f;
            health = 125f;
            foreach(Renderer r in rends)
            {
                r.material.color = Color.blue;
            }

        }

        if (player.CompareTag("USSR"))
        {
            speed = 10f;
            rotateSpeed = 20f;
            health = 75f;
            foreach(Renderer r in rends)
            {
                r.material.color = Color.red;
            }
        }

	}
	

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        if (player.CompareTag("US"))
        {
            //move forward
            if (Input.GetKey(KeyCode.W))
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            //move backward
            if (Input.GetKey(KeyCode.S))
                transform.Translate(Vector3.back * speed * Time.deltaTime);
            //strafe left
            if (Input.GetKey(KeyCode.A))
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            //strafe right
            if (Input.GetKey(KeyCode.D))
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            //move up
            if (Input.GetKey(KeyCode.R))
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            //move down
            if (Input.GetKey(KeyCode.C))
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            //yaw left
            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);

            }
            //yaw right
            if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
          
            }
            //launch torpedo
            if (Input.GetKeyDown(KeyCode.F) && player.transform.position.y <=0)
            {
                GameObject f1 = Instantiate(Torpedo, fireTransform.position, fireTransform.rotation);
                Destroy(f1, lifetime);

            }
            if (health <= 0)
                Destroy(player);
        }

        if (player.CompareTag("USSR"))
        {
            //move forward
            if (Input.GetKey(KeyCode.I))
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            //move backward
            if (Input.GetKey(KeyCode.K))
                transform.Translate(Vector3.back * speed * Time.deltaTime);
            //strafe left
            if (Input.GetKey(KeyCode.J))
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            //strafe right
            if (Input.GetKey(KeyCode.L))
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            //move up
            if (Input.GetKey(KeyCode.Y))
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            //move down
            if (Input.GetKey(KeyCode.N))
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            //yaw left
            if (Input.GetKey(KeyCode.U))
                transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
            //yaw right
            if (Input.GetKey(KeyCode.O))
                transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);

            //launch torpedo
            if (Input.GetKeyDown(KeyCode.H) && player.transform.position.y <= 0)
            {
                GameObject f1 = Instantiate(Torpedo, fireTransform.position, fireTransform.rotation);
                Destroy(f1, lifetime);

            }
            if (health <= 0)
                Destroy(player);

        }
        
    }
}

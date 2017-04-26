using UnityEngine;
using System.Collections;

public class ChangeDirection : MonoBehaviour
{

    public Vector3 newDirection1 = new Vector3();
    public Vector3 newDirection2 = new Vector3();

    public Vector3 newRotation1 = new Vector3();
    public Vector3 newRotation2 = new Vector3();

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
        if (other.gameObject.GetComponent<EnemyUnit>() != null)
        {
            EnemyUnit eu = other.gameObject.GetComponent<EnemyUnit>();
            int dir = Random.Range(0, 2);

            eu.GetComponent<Rigidbody>().velocity = Vector3.zero;
            eu.GetComponent<Rigidbody>().rotation = Quaternion.identity;

            if (eu != null)
            {
                if (dir == 0)
                {
                    eu.velocity.x = newDirection1.x * eu.speed;
                    eu.velocity.y = newDirection1.y * eu.speed;
                    eu.velocity.z = newDirection1.z * eu.speed;

                    eu.rotation.x = newRotation1.x;
                    eu.rotation.y = newRotation1.y;
                    eu.rotation.z = newRotation1.z;
                }
                else if (dir == 1)
                {
                    eu.velocity.x = newDirection2.x * eu.speed;
                    eu.velocity.y = newDirection2.y * eu.speed;
                    eu.velocity.z = newDirection2.z * eu.speed;

                    eu.rotation.x = newRotation2.x;
                    eu.rotation.y = newRotation2.y;
                    eu.rotation.z = newRotation2.z;
                }
            }
        }
        
    }
}

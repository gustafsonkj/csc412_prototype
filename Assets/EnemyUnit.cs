using UnityEngine;
using System.Collections;

public class EnemyUnit : MonoBehaviour
{

    public float health;
    public Vector3 velocity = new Vector3();
    public Vector3 rotation = new Vector3();

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().velocity = velocity;
        GetComponent<Rigidbody>().rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = velocity;
        GetComponent<Rigidbody>().rotation = Quaternion.Euler(rotation);
    }

    public void explode()
    {
        Destroy(gameObject);
    }

}

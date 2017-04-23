using UnityEngine;
using System.Collections;

public class EnemyUnit : MonoBehaviour
{

    public float health;
    public Vector3 velocity = new Vector3();

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = velocity;
    }

    public void explode()
    {
        Destroy(gameObject);
    }

}

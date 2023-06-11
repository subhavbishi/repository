using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;
    public float speed = 5f;
    private Rigidbody rb;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other){
        speed = (-1)*speed;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = point1.transform.position - point2.transform.position;
        rb.velocity = direction*speed;
    }
}

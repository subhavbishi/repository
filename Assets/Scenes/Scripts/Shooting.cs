using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float bulletSpeed = 5f;
    public Rigidbody bullet;
    public GameObject bulletpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
           Rigidbody rb;
           rb = Instantiate(bullet,bulletpoint.transform.position,bulletpoint.transform.rotation);
          
           Vector3 forward = transform.TransformDirection(Vector3.forward);
           rb.velocity = forward*bulletSpeed; 
        }
    }
}

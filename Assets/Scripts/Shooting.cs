using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float bulletSpeed = 100f;
    public GameObject bullet;
    public Camera Cam;
    public float range = 50f;
    private Vector3 TargetPosition;
    public GameObject bulletpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
           shoot();
           
        }
    }
    void shoot(){
        Ray ray = Cam.ViewportPointToRay(new Vector3(0.5f,0.5f,0f));
        RaycastHit hit;
        if(Physics.Raycast(Cam.transform.position,Cam.transform.forward,out hit, range)){
           TargetPosition = hit.point;
        }
        else{
            TargetPosition = ray.GetPoint(range);
        }

        Vector3 dir = TargetPosition - bulletpoint.transform.position;

        GameObject b = Instantiate(bullet, bulletpoint.transform.position, Quaternion.identity);
        b.transform.forward = dir.normalized;

        b.GetComponent<Rigidbody>().AddForce(dir.normalized * bulletSpeed, ForceMode.Impulse); 

    }
}

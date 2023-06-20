using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public Health health;
    public float damage = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("bullet")){
            health.OnDamage(damage);
        }
    }
}

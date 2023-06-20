using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 100;
    public void OnDamage(float damage){

        health -= damage;
        
        
    }
    void Update(){
        if(health<=0){
            Destroy(gameObject);
        }
    }
}


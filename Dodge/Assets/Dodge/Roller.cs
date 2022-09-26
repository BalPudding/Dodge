using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour
{
    private Rigidbody roll;
    public float speed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        roll = GetComponent<Rigidbody>();
        roll.velocity = transform.forward * speed;
        Destroy(gameObject, 4f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            PlayerCtrl player = other.GetComponent<PlayerCtrl>();
            if(player != null)
            { 
                player.Die(); 
            }
        }
    }


}
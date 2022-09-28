using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movetotarget : MonoBehaviour
{
    private Transform target;
  
    
     void Start()
    {
        target = FindObjectOfType<PlayerCtrl>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(gameObject.transform.position, target.transform.position, 5f*Time.deltaTime);
    }
}

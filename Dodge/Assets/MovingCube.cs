using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    private Rigidbody cube;
    public float speed = 100f;
    public void Die()
    {
        gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        cube = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        float xspeed = x * speed;
        float yspeed = y * speed;

        Vector3 Velo = new Vector3(xspeed, 0f, yspeed);
        cube.velocity = Velo;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private Rigidbody player;
        public float speed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    void Dash()
    {
        speed = 14f;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        float xspeed = x * speed;
            float zspeed = z * speed;

        Vector3 velo = new Vector3(xspeed, 0f, zspeed);
        player.velocity = velo;

        if(Input.GetKeyDown(KeyCode.Space) == true)
            {
            speed = 90f;
            Invoke("Dash", 0.07f);
        }
    }
    public void Die()
    {
        gameObject.SetActive(false);
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}

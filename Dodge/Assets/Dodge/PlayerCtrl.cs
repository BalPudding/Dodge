using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private Rigidbody player;
    public float speed = 8f;
    private float timer = 0f;
    private float breaker = 2.5f;
    public bool cool = true;
    Renderer player_color;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
        player_color = gameObject.GetComponent<Renderer>();
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

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            if (cool == true)
            {
                speed = 90f;
                Invoke("Dash", 0.07f);
                cool = false;
            }
        }
        timer += Time.deltaTime;
        if (timer > breaker)
        {
            timer = 0f;
            cool = true;
        }
        if(cool == true)
        {
            player_color.material.color = Color.yellow;
        }
        if(cool == false)
        {
            player_color.material.color = new Color(35 / 255f, 74 / 255f, 255 / 255f);
        }
        
    }
public void Die()
    {
        gameObject.SetActive(false);
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiner : MonoBehaviour
{
    public GameObject Prefab;
    public float rateMax = 0f;
    public float rateMin = 3f;

    private float rate;
    private float afterspawn;

    public float speed = 30f;

    // Start is called before the first frame update
    void Start()
    {
        afterspawn = 0f;
        rate = Random.Range(rateMin, rateMax);
        Destroy(gameObject, 4f);
        

    }

    // Update is called once per frame
    void Update()
    {
        afterspawn += Time.deltaTime;
        if (afterspawn >= rate)
        {
            afterspawn = 0f;
            GameObject Roller = Instantiate(Prefab, transform.position, transform.rotation);
            rate = Random.Range(rateMin, rateMax);
        }
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }
}

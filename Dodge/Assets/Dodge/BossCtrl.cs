using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCtrl : MonoBehaviour
{
    public GameObject Prefab;
    public GameObject Prefab_02;
    public float rateMax =0.5f;
    public float rateMin =3f;
    public float rate01 = 10f;

    private Transform target;
    private float rate;
    private float afterspawn;
    private float afterspawn01;

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        afterspawn = 0f;
        afterspawn01 = 0f;
        rate = Random.Range(rateMin, rateMax);
        target = FindObjectOfType<PlayerCtrl>().transform;

    }

    // Update is called once per frame
    void Update()
    {
        afterspawn += Time.deltaTime;
        afterspawn01 += Time.deltaTime;
        if (afterspawn >= rate)
        {
            afterspawn = 0f;
            GameObject Roller = Instantiate(Prefab, transform.position, transform.rotation);
            Roller.transform.LookAt(target);
            rate = Random.Range(rateMin, rateMax);
        }

        if (afterspawn01 >= rate01)
        {
            afterspawn01 = 0f;
            GameObject Spiner = Instantiate(Prefab_02, transform.position, transform.rotation);
            Spiner.transform.LookAt(target);
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);

        if (transform.position.x >= 12f)
        {
            speed *= -1;
        }
        else if (transform.position.x <= -12f)
        {
            speed *= -1;
        }

    }
}

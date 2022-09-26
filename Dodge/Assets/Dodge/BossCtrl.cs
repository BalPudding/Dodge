using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCtrl : MonoBehaviour
{
    public GameObject Prefab;
    public float rateMax =0.5f;
    public float rateMin =3f;

    private Transform target;
    private float rate;
    private float afterspawn;

    // Start is called before the first frame update
    void Start()
    {
        afterspawn = 0f;
        rate = Random.Range(rateMin, rateMax);
        target = FindObjectOfType<PlayerCtrl>().transform;

    }

    // Update is called once per frame
    void Update()
    {
        afterspawn += Time.deltaTime;
        if (afterspawn >= rate)
        {
            afterspawn = 0f;
            GameObject Roller = Instantiate(Prefab, transform.position, transform.rotation);
            Roller.transform.LookAt(target);
            rate = Random.Range(rateMin, rateMax);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float intervalMin = 0.5f;
    public float intervalMax = 3f;

    private Transform target;
    private float interval;
    private float timeAfterSpawm;
    // Start is called before the first frame update
    void Start()
    {
        interval = Random.Range(intervalMin, intervalMax);
        timeAfterSpawm = 0f;

        //타켓지정 컴포넌트로 찾기
        target = FindObjectOfType<player>().transform;


         
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawm += Time.deltaTime;
        if (timeAfterSpawm >= interval)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);

            interval = Random.Range(intervalMin, intervalMax);
            timeAfterSpawm = 0f;
        }

    }
}

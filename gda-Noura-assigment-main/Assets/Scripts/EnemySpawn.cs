using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame


    [SerializeField] private GameObject m_prefab2;

    private bool isSpawning = false;
    [SerializeField] private EnemyData enemydata;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.F))
        {
            // تبديل الإطلاق المستمر
            isSpawning = !isSpawning;

            // بدء أو إيقاف الإطلاق بناءً على مفتاح التبديل
            if (isSpawning)
            {
                InvokeRepeating("SpawnC", 0.0f, enemydata.Shootdelay);
            }
            else
            {
                CancelInvoke();
            }
        }
        if (Input.GetKey(KeyCode.P))
        {
            isSpawning = !isSpawning;
            if (!isSpawning)
            {
                CancelInvoke();
            }
        }

        //  InvokeRepeating("SpawnC", 0.0f ,20.0f);
    }

    void SpawnC()
    {
        Instantiate(m_prefab2, transform.position + Vector3.back * 3, Quaternion.identity);
    }

}

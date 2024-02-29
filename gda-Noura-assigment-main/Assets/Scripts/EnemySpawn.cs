using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject m_prefab2;

    [SerializeField] private EnemyData enemydata;
    [SerializeField] private float Shootdelay;
    public bool isSpawning = true;


    void Start()
    {
        if (isSpawning)
            StartShoot();
    }
    public void StartShoot()
    {

        StartCoroutine(SpawnEnemyCoroutine());
        // StartCoroutine(MoveEnemyCoroutine());
    }


    private IEnumerator SpawnEnemyCoroutine()
    {
        while (true)
        {
            for (int i = 0; i < 3; i++)
            {
                Shoot();
                yield return new WaitForSeconds(0.3f);
            }

            yield return new WaitForSeconds(enemydata.Shootdelay);
        }
    }


    private void Shoot()
    {
        GameObject newBullet = Instantiate(m_prefab2, transform.position + Vector3.up, Quaternion.identity);
        newBullet.GetComponent<BulletScript>().Init(enemydata.m_speed, true, enemydata.AutoAim);
    }

    // #########

    // private IEnumerator MoveEnemyCoroutine()
    // {
    //     Rigidbody er = GetComponent<Rigidbody>();
    //     while (true)
    //     {
    //         for (int i = 0; i < 200; i++)
    //         {
    //             er.velocity = Vector3.up;
    //             yield return new WaitForFixedUpdate();
    //         }
    //         for (int i = 0; i < 200; i++)
    //         {
    //             er.velocity = Vector3.zero;
    //             yield return new WaitForFixedUpdate();
    //         }
    //         for (int i = 0; i < 200; i++)
    //         {
    //             er.velocity = Vector3.down;
    //             yield return new WaitForFixedUpdate();
    //         }
    //         for (int i = 0; i < 200; i++)
    //         {
    //             er.velocity = Vector3.zero;
    //             yield return new WaitForFixedUpdate();
    //         }

    //     }
    // }


}

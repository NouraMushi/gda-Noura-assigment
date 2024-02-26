using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    [SerializeField] private GameObject m_prefab2;

    // private bool isSpawning = false;
    [SerializeField] private EnemyData enemydata;
    private void Awake()
    {

        StartCoroutine(SpawnEnemyCoroutine());
        StartCoroutine(MoveEnemyCoroutine());
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
        GameObject newBullet = Instantiate(m_bullet, transform.position + Vector3.up, Quaternion.identity);
        newBullet.GetComponent<BulletController>().Init(enemydata.m_speed, true, enemydata.AutoAim);
    }

    // #########

    private IEnumerator MoveEnemyCoroutine()
    {
        Rigidbody er = GetComponent<Rigidbody>();
        while (true)
        {
            for (int i = 0; i < 200; i++)
            {
                er.velocity = Vector3.up;
                yield return new WaitForFixedUpdate();
            }
            for (int i = 0; i < 200; i++)
            {
                er.velocity = Vector3.zero;
                yield return new WaitForFixedUpdate();
            }
            for (int i = 0; i < 200; i++)
            {
                er.velocity = Vector3.down;
                yield return new WaitForFixedUpdate();
            }
            for (int i = 0; i < 200; i++)
            {
                er.velocity = Vector3.zero;
                yield return new WaitForFixedUpdate();
            }

        }
    }


}

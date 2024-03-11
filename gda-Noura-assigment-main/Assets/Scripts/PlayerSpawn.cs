using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using System.Collections.Generic;

public class PlayerSpawn : MonoBehaviour
{
    // public float ClipLength = 1f;
    // public GameObject AudioClip;

    [SerializeField] private GameObject m_prefab1;
    [SerializeField] private float m_bulletSpeed;
    [SerializeField] private Transform m_ShootingPoint;
    [SerializeField] private Animator p_animator;

    // private float _nextFireTime = 0f;

    // private ButtonScript m_pauseController;
    void Start()
    {
        // AudioClip.SetActive(false);
        // m_pauseController = FindObjectOfType<PauseController>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            p_animator.SetTrigger("Shoot");
            // InvokeRepeating("SpawnC", 0.0f, 0.9f);
        }

    }


    public void SpawnC()
    {
        // Instantiate(m_prefab1);
        GameObject newBullet = Instantiate(m_prefab1, m_ShootingPoint.position, Quaternion.identity);
        newBullet.GetComponent<BulletScript>().Init(m_bulletSpeed, false, false, true);


    }

}


using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] private GameObject m_prefab1;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            InvokeRepeating("SpawnC", 0.0f, 0.9f);
        }
        else if (!Input.GetKeyDown(KeyCode.T))
        {
            CancelInvoke();
        }
    }

    void SpawnC()
    {
        // Instantiate(m_prefab1);
        Instantiate(m_prefab1, transform.position + Vector3.forward, Quaternion.identity);
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private PlayerSpawn m_shootingController;
    private void Awake()
    {
        m_shootingController = GetComponentInParent<PlayerSpawn>();
    }

    void ShootBullet()
    {
        m_shootingController.SpawnC();
    }
}

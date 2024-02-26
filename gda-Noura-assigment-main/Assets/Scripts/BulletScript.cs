using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    [SerializeField] private float m_speed;
    // [SerializeField] private float m_lifetime;
    private Rigidbody m_rigidbody;
    private PlayerMove m_player;
    private Quaternion m_quat;
    private bool m_followPlayer;
    void Awake()
    {
        Destroy(gameObject, 5.0f);
        m_rigidbody = GetComponent<Rigidbody>();
    }


    public void Init(float speed, bool lookAtPlayer, bool followPlayer)
    {
        m_speed = speed;

        if (lookAtPlayer)
        {
            m_player = FindObjectOfType<PlayerMovementController>();
            m_quat = Quaternion.LookRotation(m_player.transform.position - transform.position);
            m_followPlayer = followPlayer;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (m_followPlayer)
        {
            m_quat = Quaternion.LookRotation(m_player.transform.position - transform.position);
        }

        m_rigidbody.velocity = m_quat * Vector3.forward * 25.0f;
        // transform.position += 25.0f * Time.deltaTime * Vector3.forward;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    // [SerializeField] private float m_speed;
    // [SerializeField] private float m_lifetime;
    // private Rigidbody m_rigidbody;
    // private PlayerMove m_player;
    // private Quaternion m_quat;
    // [SerializeField] private AudioSource collisionSound;
    // private bool m_followPlayer;


    // void Awake()
    // {
    //     Destroy(gameObject, 5.0f);
    //     m_rigidbody = GetComponent<Rigidbody>();
    // }


    // public void Init(float speed, bool lookAtPlayer, bool followPlayer)
    // {
    //     m_speed = speed;

    //     if (lookAtPlayer)
    //     {
    //         m_player = FindObjectOfType<PlayerMove>();
    //         m_quat = Quaternion.LookRotation(m_player.transform.position - transform.position);
    //         m_followPlayer = followPlayer;
    //     }
    // }
    // // Update is called once per frame
    // void FixedUpdate()
    // {
    //     if (m_followPlayer)
    //     {
    //         m_quat = Quaternion.LookRotation(m_player.transform.position - transform.position);
    //     }

    //     m_rigidbody.velocity = m_quat * Vector3.forward * 25.0f;
    //     // transform.position += 25.0f * Time.deltaTime * Vector3.forward;
    // }

    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.tag != m_ignoredTag)
    //     {
    //         Destroy(gameObject);
    //         PlayCollisionSound();
    //         if (m_explosive)
    //         {
    //             Collider[] colliders = Physics.OverlapSphere(transform.position, m_explosionRadius);
    //             foreach (var collider in colliders)
    //             {
    //                 Rigidbody rb;
    //                 if (collider.TryGetComponent<Rigidbody>(out rb))
    //                 {
    //                     rb.AddExplosionForce(m_explosionForce, transform.position, m_explosionRadius, 1.0f);
    //                 }
    //             }
    //         }
    //     }
    // }
    // void PlayCollisionSound()
    // {
    //     if (collisionSound != null) // Check if the AudioSource component is assigned
    //     {
    //         collisionSound.Play(); // Play the collision sound
    //     }
    // }

    //[SerializeField] private float m_speed;
    [SerializeField] private float m_lifetime;
    [SerializeField] private string m_ignoredTag;
    [SerializeField] private AudioSource collisionSound;
    [SerializeField] private float m_explosionRadius = 10.0f;
    [SerializeField] private float m_explosionForce = 100.0f;
    private float m_speed;
    private Rigidbody m_rigidbody;
    private PlayerMove m_player;
    private Quaternion m_quat;
    private bool m_followPlayer;
    private bool m_explosive;
    void Start()
    {
        Destroy(gameObject, m_lifetime);
        m_rigidbody = GetComponent<Rigidbody>();
    }

    public void Init(float speed, bool lookAtPlayer, bool followPlayer, bool explosive)
    {
        m_speed = speed;
        m_explosive = explosive;
        if (lookAtPlayer)
        {
            m_player = FindObjectOfType<PlayerMove>();
            m_quat = Quaternion.LookRotation(m_player.transform.position - transform.position);
            m_followPlayer = followPlayer;
        }
    }
    void FixedUpdate()
    {
        if (m_followPlayer)
        {
            m_quat = Quaternion.LookRotation(m_player.transform.position - transform.position);
        }
        m_rigidbody.velocity = m_quat * Vector3.forward * m_speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != m_ignoredTag)
        {
            Destroy(gameObject);
            PlayCollisionSound();
            if (m_explosive)
            {
                Collider[] colliders = Physics.OverlapSphere(transform.position, m_explosionRadius);
                foreach (var collider in colliders)
                {
                    Rigidbody rb;
                    if (collider.TryGetComponent<Rigidbody>(out rb))
                    {
                        rb.AddExplosionForce(m_explosionForce, transform.position, m_explosionRadius, 1.0f);
                    }
                }
            }
        }
    }
    void PlayCollisionSound()
    {
        if (collisionSound != null) // Check if the AudioSource component is assigned
        {
            collisionSound.Play(); // Play the collision sound
        }
    }

}

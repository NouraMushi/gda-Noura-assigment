using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    // [SerializeField] private float m_speed;
    // [SerializeField] private float m_lifetime;
    void Awake()
    {
        Destroy(gameObject, 5.0f);
    }


    // Update is called once per frame
    void Update()
    {
        transform.position += 25.0f * Time.deltaTime * Vector3.forward;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody m_ridibody;
    // Start is called before the first frame update
    void Awake()
    {
        m_ridibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // bool moving = false;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_ridibody.velocity = Vector3.forward * 5.0f;
            // moving = true;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_ridibody.velocity = Vector3.back * 5.0f;
            // moving = true;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_ridibody.velocity = Vector3.left * 5.0f;
            // moving = true;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_ridibody.velocity = Vector3.right * 5.0f;
            // moving = true;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptR : MonoBehaviour
{
    private Rigidbody m_ridibody ;
    // Start is called before the first frame update
    void Awake()
    {
        m_ridibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_ridibody.velocity = Vector3.up;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_ridibody.velocity = Vector3.forward;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_ridibody.velocity = Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_ridibody.velocity = Vector3.right;
        }
       
    }
}

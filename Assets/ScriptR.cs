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
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_ridibody.velocity = Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_ridibody.velocity = Vector3.forward;
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            m_ridibody.velocity = Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            m_ridibody.velocity = Vector3.right;
        }
       
    }
}

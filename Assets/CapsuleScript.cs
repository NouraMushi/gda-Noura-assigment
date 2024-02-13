using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // [SerializeField] private Vector3 m_direction;
    [SerializeField] private float m_speed;
    

    // Vector3 forwardMove = new Vector3(0.1f, 0, 0);
    // Vector3 BackourdMove = new Vector3(-0.1f, 0, 0);
    // Vector3 RightMove = new Vector3(0, 0, -0.1f);
    // Vector3 leftMove = new Vector3(0, 0, 0.1f);

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * m_speed * Time.deltaTime; 
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.forward * m_speed * Time.deltaTime ;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * m_speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * m_speed * Time.deltaTime;
        }   
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Vector3 m_direction;
    

    Vector3 forwardMove = new Vector3(0.1f, 0, 0);
    Vector3 BackourdMove = new Vector3(-0.1f, 0, 0);
    Vector3 RightMove = new Vector3(0, 0, -0.1f);
    Vector3 leftMove = new Vector3(0, 0, 0.1f);

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += forwardMove;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += BackourdMove;
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += leftMove;   
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += RightMove;   
        }      
    }
}

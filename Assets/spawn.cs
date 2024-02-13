using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField] public GameObject m_prefab1;
    // [SerializeField] private Vector3 m_direction;
    // Start is called before the first frame update
    // void Update()
    // {
    //     Vector3 vec2 = new Vector3(1 ,2,3 );
    // }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Spawn();
            InvokeRepeating("Spawn", 0.0f ,1.0f);
        }
       
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if(Input.GetKeyDown(KeyCode.Space)){
    //         Instantiate(m_prefab1, GetComponent<Transform>().position, Quaternion.identity);

    //     }
    // }
    void Spawn(){
        Instantiate(m_prefab1);
    }
    
}

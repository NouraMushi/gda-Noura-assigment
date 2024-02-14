using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField] private GameObject m_prefab1;
    private Rigidbody t_ridibody ;
    // [SerializeField] private Vector3 m_direction;
    // Start is called before the first frame update
    // void Update()
    // {
    //     Vector3 vec2 = new Vector3(1 ,2,3 );
    // }


    // Start is called before the first frame update
    void Awake()
    {
        t_ridibody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            SpawnC();
            InvokeRepeating("SpawnC", 0.0f ,0.5f);
        }
      else if(!Input.GetKeyDown(KeyCode.T)){
             CancelInvoke();
      }
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if(Input.GetKeyDown(KeyCode.Space)){
    //         Instantiate(m_prefab1, GetComponent<Transform>().position, Quaternion.identity);

    //     }
    // }
    void SpawnC(){
        // Instantiate(m_prefab1);
        // Instantiate(m_prefab1 , transform.position , Quaternion.identity );

        GameObject obj = Instantiate(m_prefab1, transform.position, Quaternion.identity);
        Rigidbody objRb = obj.GetComponent<Rigidbody>();

        if (objRb != null)
        {
            // قم بتطبيق قوى أو نبضات على المكون Rigidbody للكائن المنشأ
            objRb.AddForce(Vector3.forward * 10f, ForceMode.Impulse);
        }
    }
    
}

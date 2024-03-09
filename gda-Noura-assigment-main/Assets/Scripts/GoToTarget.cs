using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToTarget : MonoBehaviour
{
    [SerializeField] private Transform m_target;
    void Start()
    {
        GetComponent<UnityEngine.AI.NavMeshAgent>().destination = m_target.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Integrefy/Enemy Data")]
public class EnemyData : ScriptableObject
{
    // Start is called before the first frame update
    public float m_speed;
    public float Shootdelay;

    public bool AutoAim;  //if true bullet follow player 

    // public static EnemyData Create(float speed)
    // {
    //     var data = ScriptableObject.CreatInstsnce<EnemyData>();
    //     data.m_speed = speed ;
    //     return data ;
    // }
}

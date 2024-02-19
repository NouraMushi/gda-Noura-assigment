using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKill : MonoBehaviour
{
  // Start is called before the first frame update

  void OnCollisionEnter(Collision col)
  {
    if (col.gameObject.tag == "Player")
    {

      UIManegerScript.instance.UpdateKillCounterUI();
      Destroy(gameObject);

    }
  }
}

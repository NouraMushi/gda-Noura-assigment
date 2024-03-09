using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKill : MonoBehaviour
{
  // Start is called before the first frame update
  // [SerializeField] GomeObject enemyHitSoundPlayer;
  void OnCollisionEnter(Collision col)
  {
    if (col.gameObject.tag == "Player")
    {

      UIManegerScript.instance.UpdateKillCounterUI();
      // var soundPlayer = Instantiate(enemyHitSoundPlayer, Collision.gameObject.transform.position, Quaternion.identity);
      // Destroy(soundPlayer, 2.0f);
      Destroy(gameObject);

    }
  }
}

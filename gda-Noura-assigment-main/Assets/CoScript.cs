using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoScript : MonoBehaviour
{
    // Start is called before the first frame update

      void OnCollisionEnter(Collision col){
          if (col.gameObject.tag == "Player"){
            Destroy(gameObject);
            }
            UIManegerScript.instance.UpdateKillCounterUI();
        }
}

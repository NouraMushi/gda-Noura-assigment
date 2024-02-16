using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playreScript : MonoBehaviour
{
    // Start is called before the first frame update

    // تعريف متغير من متيريال
    private Material playerMaterial;

    void Start()
    {
        playerMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision col){
          if (col.gameObject.tag == "killplayer"){
            //  Debug.Log($"Kill");
            // Destroy(gameObject);

            playerMaterial.color = Color.red;

            // إعادة لون اللاعب بعد 2 ثانية
           Invoke("ResetColor", 2.0f);
  }
}
void ResetColor()
    {
        playerMaterial.color = Color.white;
    }
}

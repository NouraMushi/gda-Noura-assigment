using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class UIManegerScript : MonoBehaviour
{

    public static UIManegerScript instance;
    [SerializeField]
    TextMeshProUGUI KillCounter_TMP;
    public int KillCount;
    // Start is called before the first frame update
    private void Awake()
    {   if(instance == null)
         {
            instance = this;
         }
         else
         {
            Destroy(gameObject);
         }
    }

    // Update is called once per frame
    public void UpdateKillCounterUI()
    {
        KillCounter_TMP.text = KillCount.ToString();
    }
}
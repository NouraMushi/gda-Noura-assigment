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
    private int KillCount;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }
    // Update is called once per frame
    public void UpdateKillCounterUI()
    {
        KillCount++;
        KillCounter_TMP.text = KillCount.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeOneCostText : MonoBehaviour
{
    Text upgradeOneCostText;

    int upgradeOneCost = -100;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        upgradeOneCostText.text = upgradeOneCost.ToString();
    }
}

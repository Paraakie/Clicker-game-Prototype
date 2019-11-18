using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade1Text : MonoBehaviour
{
    public Text upgrade1Text;
    private string[] upgrades = new[] {
        "Gain +5 Wood when clicking Branches",
        "Gain +10 Wood per Ranger"
    }; 


    // Update is called once per frame
    void Update()
    {
        upgrade1Text.text = upgrades[0];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade1Text : MonoBehaviour
{
    public Text upgrade1Text;
    private string upgrades = "Gain +1 WpC(Branches)"; // will become an array with upgrade text



    // Update is called once per frame
    void Update()
    {
        upgrade1Text.text = upgrades;
    }
}

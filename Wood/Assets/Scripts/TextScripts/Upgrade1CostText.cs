using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade1CostText : MonoBehaviour
{
    public Text upgrade1CostText;

    private int upgrade1Cost = -100;

    // Update is called once per frame
    void Update()
    {
        upgrade1CostText.text = upgrade1Cost.ToString();
    }

    /*
     * Getters and Setters 
     */
    public int GetUpgradeOneCost()
    {
        return upgrade1Cost;
    }

    public void SetUpgradeOneCost(int value)
    {
        upgrade1Cost = value;
    }

}

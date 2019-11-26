using UnityEngine;
using UnityEngine.UI;

public class RangerCostText : MonoBehaviour
{
    /*
     * Values
     */
    public Text rangerCostText;
    private double rangerCost = -10.0; // will become an array for all upgrade costs

    // Update is called once per frame
    void Update()
    {
        //Display Text
        /*Note, fix how many decimals are displayed*/
        rangerCostText.text = rangerCost.ToString("0.00") + " Wood";

    }

    /*
     * Getters and Setters
     */
     //RangerCost
    public double GetRangerCost()
    {
        return rangerCost;
    }

    public void SetRangerCost(double value)
    {
        rangerCost = value;
    }

}

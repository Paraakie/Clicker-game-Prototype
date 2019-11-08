using UnityEngine;
using UnityEngine.UI;

public class RangerCostText : MonoBehaviour
{
    /*
     * Values
     */
    public Text rangerCostText;
    private double rangerCost = -10;

    // Update is called once per frame
    void Update()
    {
        //Display Text
        /*Note, fix how many decimals are displayed*/
        rangerCostText.text = rangerCost + " Wood";

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

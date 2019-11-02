using UnityEngine;
using UnityEngine.UI;

public class RangerCostText : MonoBehaviour
{
    /*
     * Values
     */
    public Text rangerCostText;
    private int rangerCost;

    // Update is called once per frame
    void Update()
    {
        //Display Text
        rangerCostText.text = "-" + rangerCost + "Wood";
    }

    /*
     * Getters and Setters
     */
     //RangerCost
    public int GetRangerCost()
    {
        return rangerCost;
    }

    public void SetRangerCost(int value)
    {
        rangerCost = value;
    }

}

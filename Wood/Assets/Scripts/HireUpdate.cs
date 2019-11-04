using UnityEngine;
using UnityEngine.UI;

public class HireUpdate : MonoBehaviour
{
    /*
     * All Hire Objects
     */
    
    /* Ranger */
    // Gameobject for rangers
    public GameObject rangerGain;
    public GameObject rangerCost;
    // Script for rangerNumText and RangerCostText
    RangerNumText rangerNumScript;
    RangerCostText rangerCostScript;



    // Start is called before the first frame update
    void Start()
    {
        //Use Gameobject to initialise empty script objects
        rangerNumScript = rangerGain.GetComponent<RangerNumText>();
        rangerCostScript = rangerCost.GetComponent<RangerCostText>();
    }

    
    void Update()
    {
        // Update Automatic Wood Gain by Calling FUnction

        //Update Wood when Hiring (Wood Cost)

        //Update New Hiring Cost by calling function
    }

    //Function that gets WpS
    //just get WpS from all "Hire"NumText

    //FUnction that calculates new Hiring Cost
}

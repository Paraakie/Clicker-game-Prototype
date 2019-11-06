using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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

    /*
     * WoodUpdate Object Reference
     */
    public GameObject woodUp;
    WoodUpdate woodUpScript;

    // Start is called before the first frame update
    void Start()
    {
        //Use Gameobject to initialise empty script objects
        rangerNumScript = rangerGain.GetComponent<RangerNumText>();
        rangerCostScript = rangerCost.GetComponent<RangerCostText>();

        woodUpScript = woodUp.GetComponent<WoodUpdate>();
    }

    private float nextActionTime = 0.0f;
    public float period = 1.0f; // period = 1 second

    void Update()
    { 
        // Update Automatic Wood Gain by Calling Function
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            // Adds WoodperSecond every Second
            woodUpScript.UpdateWood(calculateWpS());
        }

    }       

    //Update Wood when Hiring (Wood Cost)

    //Update New Hiring Cost by calling function


    //Function that gets all WpS from all "Hire"NumText
    public double calculateWpS()
    {
        // Note: Update this function as more Hired GameObjects added
        double total = rangerNumScript.GetRangerWpS(); 

        return total;
    }


    //FUnction that calculates new Hiring Cost
}

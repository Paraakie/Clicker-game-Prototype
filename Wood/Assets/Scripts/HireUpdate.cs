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
    public GameObject rangerGainOB;
    public GameObject rangerCostOB;
    // Script for rangerNumText and rangerCostText
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
        /* Use Gameobject to initialise empty script objects */

        //Ranger
        rangerNumScript = rangerGainOB.GetComponent<RangerNumText>();
        rangerCostScript = rangerCostOB.GetComponent<RangerCostText>();

        //Wood
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

    //Function that gets all WpS from all "Hire"NumText
    public double calculateWpS()
    {
        // Note: Update this function as more Hired GameObjects added
        double total = rangerNumScript.GetRangerWpS();

        return total;
    }

    //Function that updates a hire based on input
    public void Hiring(string hireMethod)
    {
        
        //Update Wood when Hiring (Wood Cost)
        woodUpScript.UpdateWood(findHiringMethod(hireMethod));
        
    }

    //Function that finds hire method and hires
    public double findHiringMethod(string hireM)
    {
        // Ranger
        if (hireM == "Ranger" || hireM == "ranger")
        {
            double currentrangerCost = rangerCostScript.GetRangerCost();
            if (woodUpScript.enoughWood(currentrangerCost))
            {
                //Update HireNum
                rangerNumScript.SetRangerNum(rangerNumScript.GetRangerNum() + 1);

                //Update New Hiring Cost
                rangerCostScript.SetRangerCost(currentrangerCost * 1.05);

                return currentrangerCost;
            }                
        }

        return 0;
    }

}

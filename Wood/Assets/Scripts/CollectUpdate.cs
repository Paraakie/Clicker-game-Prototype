using UnityEngine;
using UnityEngine.UI;
using System;

public class CollectUpdate : MonoBehaviour
{
    /*
     * All Collect Objects
     */

    /* Branch */
    //GameObject for Branch
    public GameObject branch;
    //create BranchText script object
    BranchText branchScript;


    /*
     * WoodUpdate Object Reference
     */
    public GameObject woodUp;
    WoodUpdate woodUpScript;

    // Start is called before the first frame update
    void Start()
    {
        //Use Gameobject to initialise empty script objects
        branchScript = branch.GetComponent<BranchText>();

        woodUpScript = woodUp.GetComponent<WoodUpdate>();
    }

    
    /*
     * Get called when collect-buttons are pressed
     */
    public void updateCollectedWood(string collectMethod)
    {

       woodUpScript.UpdateWood(getWoodChange(collectMethod));

    }


    /*
     * Find the correct Value that wood is changed by
     * based on passed string
     */
    public double getWoodChange(string collectMethod)
    {

        // Change BranchPerSec    
        if (collectMethod == "Branch" || collectMethod == "branch")
        {
            return branchScript.GetBranch_WpClick();
        }


        return Int32.Parse(collectMethod);
    }

    
}

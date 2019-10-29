using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateResources : MonoBehaviour
{
    //GameObject for Wood
    public GameObject wood;
    //create Update_WoodText script object
    Update_WoodText woodScript;

    //GameObject for Branch
    public GameObject branch;
    //create BranchText script object
    BranchText branchScript;

    
    private void Start()
    {
        //Use Gameobject to initialise empty script objects
        woodScript = wood.GetComponent<Update_WoodText>();

        branchScript = branch.GetComponent<BranchText>();
    }

    /*
     * Update wood value based on (+/-)int
     */ 
    public void UpdateWood(string collectMethod)
    {

        //Get current Wood Value
        int newWood = woodScript.GetWoodNum();

        //Get woodChange
        int woodChange = getWoodChange(collectMethod);

        //Calculate new Wood Value
        newWood = newWood + woodChange;

        // Prevent Negative Wood
        if (newWood < 0)
        {
            Debug.Log("Error: Invalid wood value. Wood Value was not updated.");
            return;
        }

        //Set new Wood Value
        woodScript.SetWoodNum(newWood);
    }

    /*
     * Find the correct Value that wood is changed by
     * based on passed string
     */
    public int getWoodChange(string collectMethod)
    {
        if (collectMethod == "Branch" || collectMethod == "branch")
        {
            return branchScript.GetBranchPerSec();
        }


        return Int32.Parse(collectMethod);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateResources : MonoBehaviour
{
    //GameObject for Wood
    public GameObject wood;
    //create Update_WoodText script object
    Update_WoodText woodScript;

    
    private void Start()
    {
        //Use Gameobject to initialise empty script objects
        woodScript = wood.GetComponent<Update_WoodText>();
    }

    /*
     * Update wood value based on (+/-)int
     */ 
    public void UpdateWood(int woodChange)
    {

        //Get current Wood Value
        int newWood = woodScript.GetWoodNum();

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


    
}

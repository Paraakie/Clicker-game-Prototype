using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateResources : MonoBehaviour
{
    //GameObject for Wood
    public GameObject wood;
    //create Update_WoodText script object
    Update_WoodText woodScript;

    //GameObject for Minions
    public GameObject minion;
    //create Update_MinionText script object
    Update_MinionText minionScript;

    private void Start()
    {
        //Use Gameobject to initialise empty script objects
        woodScript = wood.GetComponent<Update_WoodText>();
        minionScript = minion.GetComponent<Update_MinionText>();
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


    /*
     * Update minion Value based on (+/-)int
     */
    public void UpdateMinions(int minionsChange)
    {
        //Get current Minion Value
        int newMinions = minionScript.GetMinionNum();

        //Calculate new Mininon Value
        newMinions = newMinions + minionsChange;

        //Prevent Negative Minion Value
        if (newMinions < 0)
        {
            Debug.Log("Error: Invalid minion value. Minion Value was not updated.");
            return;
        }

        //Set new Minion Value
        minionScript.SetMinionNum(newMinions);
    }

    /*
     * General Function for Updating Resources based on (+/-)int
     */ 
    public void UpdateResource(int resourceChange/**/)
    {
        return;
    }
}

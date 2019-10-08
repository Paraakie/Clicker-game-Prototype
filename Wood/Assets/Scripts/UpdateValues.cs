using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateValues : MonoBehaviour
{
    //Singular GameObject
    public GameObject wood;
    //create empty object based on Update_WoodText script
    Update_WoodText woodScript;

    private void Start()
    {
        //Use Gameobject to access Script values
        woodScript = wood.GetComponent<Update_WoodText>();
    }

    //used tp update wood value
    public void UpdateWood(int woodChange)
    {

        //Get current Wood Value
        int newWood = woodScript.GetWoodNum();

        //Calculate new Wood Value
        newWood = newWood + woodChange;

        //Set new Wood Value
        woodScript.SetWoodNum(newWood);

        Debug.Log("This is the new Wood Value " + newWood);

        if (newWood < 0)
        {
            Debug.Log("Error: Invalid wood value.");
        }
    }
}

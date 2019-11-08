using UnityEngine;
using UnityEngine.UI;

/*
 * Script when called will update wood value
 */
public class WoodUpdate : MonoBehaviour
{

    //GameObject for Wood
    public GameObject wood;
    //create Update_WoodText script object
    WoodText woodScript;

    // Start is called before the first frame update
    void Start()
    {
        //Use Gameobject to initialise empty script objects
        woodScript = wood.GetComponent<WoodText>();
    }

    /*
     * Update wood value based on (+/-)int
     */
    public void UpdateWood(double woodChange)
    {

        //Get current Wood Value
        double newWood = woodScript.GetWoodNum();

        
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

    // Simple function that determines if a
    public bool enoughWood(double woodCost)
    {
        if (woodCost <= woodScript.GetWoodNum())
        {
            return true;
        }

        return false;
    }
}

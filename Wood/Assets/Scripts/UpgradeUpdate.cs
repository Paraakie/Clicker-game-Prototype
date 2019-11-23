using UnityEngine;
using UnityEngine.UI;

public class UpgradeUpdate : MonoBehaviour
{

    /*
     * UnityCost Script Object Reference
     */
    public Upgrade1CostText upgrade1Cost;
    Upgrade1CostText upgrade1CostScript;

    /*
     * WoodUpdate Object Reference
     */
    public GameObject woodUp;
    WoodUpdate woodUpScript;


    // Start is called before the first frame update
    void Start()
    {
        //Use Gameobject to initialise empty script objects
        woodUpScript = woodUp.GetComponent<WoodUpdate>();

        upgrade1CostScript = upgrade1Cost.GetComponent<Upgrade1CostText>();
    }

    // Update is called once per frame
    public void updateUpgrades(string upgradeNum)
    {
        // 1. Checking boolarray, and getting right index
        //2. use index and upgradeNum to get WoodChange
        double woodChange = 0;

        //1. Update wood 
        woodUpScript.UpdateWood(woodChange);
        //2. update bool-array

    }
}

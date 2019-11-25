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
        int upgradeIndex = get1stFalseIndex(upgrade1CostScript.GetUpgradePurchased());
        //2. use index and upgradeNum to get WoodChange
        int woodChange = upgrade1CostScript.GetUpgradeOneCost(upgradeIndex);

        //3. Update wood 
        woodUpScript.UpdateWood(woodChange);
        //4. update bool-array
        upgrade1CostScript.SetUpgradePurchased(true, upgradeIndex);


    }

    // Takes bool array and finds first false entry
    public int get1stFalseIndex(bool[] boolArray)
    {
        for(int i = 0; i < boolArray.Length; i++)
        {
            if (boolArray[i] == false)
            {
                //return correct index
                return i;
            }
        }


        return -1; //return -1 if no entry with "false" is found
    }


}

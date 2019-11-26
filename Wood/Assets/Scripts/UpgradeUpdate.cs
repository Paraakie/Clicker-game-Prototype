using UnityEngine;
using UnityEngine.UI;

public class UpgradeUpdate : MonoBehaviour
{
    //Upgrade-TEXT Array
    private string[] upgradeText = new[] {
        "Gain +5 WpC(Branches)",
        "Gain +10 Wood per Ranger"
    };


    /*
     * UpgradeText Script Object Reference
     */


    /*
     * UpgradeCost Script Object Reference
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
        

        upgrade1CostScript = upgrade1Cost.GetComponent<Upgrade1CostText>();

        woodUpScript = woodUp.GetComponent<WoodUpdate>();
    }

    // Update is called once per frame
    public void updateUpgrades(string upgradeNum)
    {
        
        // 1. Checking boolarray, and getting right index
        int upgradeIndex = upgrade1CostScript.get1stFalseIndex(upgrade1CostScript.GetUpgradePurchased());

        if (upgradeIndex <= -1)
        {
            Debug.Log("Error: Invalid upgradeIndex.\n");
            return;
        }

        //2. use index and upgradeNum to get WoodChange
        int woodChange = upgrade1CostScript.GetUpgradeOneCost(upgradeIndex);

        //Check if purchase can be completed based on Wood Value
        if (woodUpScript.enoughWood(woodChange*-1)){
            //3. Update wood 
            woodUpScript.UpdateWood(woodChange);

            //4. update bool-array
            upgrade1CostScript.SetUpgradePurchased(true, upgradeIndex);
        }

        


    }



}

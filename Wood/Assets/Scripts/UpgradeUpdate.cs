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
    public Upgrade1Text upgrade1Text;
    Upgrade1Text upgrade1TextScript;

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
        upgrade1TextScript = upgrade1Text.GetComponent<Upgrade1Text>();

        upgrade1CostScript = upgrade1Cost.GetComponent<Upgrade1CostText>();

        woodUpScript = woodUp.GetComponent<WoodUpdate>();
    }

    // Keeps track of the newest unpurchased Upgrade
    public int upgradeIndex = 0;

    // Update is called once per frame
    void Update()
    {
        // Checking boolarray, and getting right index
        upgradeIndex = upgrade1CostScript.get1stFalseIndex(upgrade1CostScript.GetUpgradePurchased());

        if (upgradeIndex <= -1)
        {
            Debug.Log("Error: Invalid upgradeIndex.\n");
            return;
        }

        /**
         * Update Values
         */

        //Always Update UpgradeText
        upgrade1TextScript.SetUpgradeString(upgradeText[upgradeIndex]);

        /* 
         * Later Changes
         * 
         * And UpgradeCost
         * Remember to later move UpgradeBoolArray to this file
         */
    }


    // Update is called when Upgrade Buttons is pressed
    public void updateUpgrades(string upgradeNum)
    {
        // Use index and upgradeNum to get WoodChange
        int woodChange = upgrade1CostScript.GetUpgradeOneCost(upgradeIndex);

        // Check if purchase can be completed based on Wood Value
        if (woodUpScript.enoughWood(woodChange*-1)){
            // Update wood 
            woodUpScript.UpdateWood(woodChange);

            // Update bool-array
            upgrade1CostScript.SetUpgradePurchased(true, upgradeIndex);

            // Apply Purchased Upgrade Effect
            applyUpgrade();
        }

    }

    public void applyUpgrade()
    {

    }



}

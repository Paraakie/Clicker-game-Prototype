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
    public GameObject wood;
    WoodText woodScript;

    // Start is called before the first frame update
    void Start()
    {
        //Use Gameobject to initialise empty script objects
        woodScript = wood.GetComponent<WoodText>();

        upgrade1CostScript = upgrade1Cost.GetComponent<Upgrade1CostText>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

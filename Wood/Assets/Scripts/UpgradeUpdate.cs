using UnityEngine;
using UnityEngine.UI;

public class UpgradeUpdate : MonoBehaviour
{

    /*
     * UnityCost Script Object Reference
     */ 

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

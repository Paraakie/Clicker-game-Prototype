using UnityEngine;
using UnityEngine.UI;

public class WoodText : MonoBehaviour
{
    private double woodNum = 0;
    public Text woodText;

    // Update is called once per frame
    void Update()
    {
        //Text Displayed
        woodText.text = "Wood: "+ GetWoodNum().ToString("0.00");
     
    }

    /*
     * Getters and Setters 
     */ 

    public double GetWoodNum()
    {
        return woodNum;
    }

    public void SetWoodNum(double newWoodNum)
    {
        woodNum = newWoodNum;
    }
}


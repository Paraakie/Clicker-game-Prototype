using UnityEngine;
using UnityEngine.UI;

public class WoodText : MonoBehaviour
{
    private int woodNum = 0;
    public Text woodText;

    // Update is called once per frame
    void Update()
    {
        //Text Displayed
        woodText.text = "Wood: "+ GetWoodNum();
     
    }

    /*
     * Getters and Setters 
     */ 

    public int GetWoodNum()
    {
        return woodNum;
    }

    public void SetWoodNum(int newWoodNum)
    {
        woodNum = newWoodNum;
    }
}


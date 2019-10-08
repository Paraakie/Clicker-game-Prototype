using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Update_WoodText : MonoBehaviour
{
    private int woodNum = 0;
    public Text woodText;

    // Update is called once per frame
    void Update()
    {
        //Text Displayed
        woodText.text = "Wood: "+ GetWoodNum();

        //Test function grants wood when pressing space
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetWoodNum(GetWoodNum() + 1);
        }
        */
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


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Update_MinionText : MonoBehaviour
{
    private int minionNum = 0;
    public Text minionText;

    // Update is called once per frame
    void Update()
    {
        //Keep Text Updated
        minionText.text = "Unemployed: " + GetMinionNum() + "\n" +
                           "Total Minons: " + GetMinionNum();
    }

    public int GetMinionNum()
    {
        return minionNum;
    }

    public void SetMinionNum(int value)
    {
        minionNum = value;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Update_People_Text : MonoBehaviour
{
    private int peopleNum = 0;
    public Text peopleText;

    // Update is called once per frame
    void Update()
    {
        //Keep Text Updated
        peopleText.text = "People: " + peopleNum;

    }

    public int GetPeopleNum()
    {
        return peopleNum;
    }

    public void SetPeopleNum(int value)
    {
        peopleNum = value;
    }

}

using UnityEngine;
using UnityEngine.UI;

public class RangerNumText : MonoBehaviour
{
    public Text rangerNumText;
    //Number of Rangers
    private int rangerNum = 0;
    // Wood Produced per Ranger/sec
    private double rangerProductivity = 1.0;
    //Rangers total Wood produced per second
    private double rangerWpS = 0.0;

    




    // Update is called once per frame
    void Update()
    {
        rangerNumText.text = rangerNum.ToString();
        rangerWpS = rangerNum * rangerProductivity;
    }

    /**
     * Getters and Setters
     */

    // rangerNum
    public int GetRangerNum()
    {
        return rangerNum;
    }

    public void SetRangerNum(int value)
    {
        rangerNum = value;
    }

    // rangerProductivity
    public double GetRangerProductivity()
    {
        return rangerProductivity;
    }

    public void SetRangerProductivity(double value)
    {
        rangerProductivity = value;
    }

    // rangerWpS
    public double GetRangerWpS()
    {
        return rangerWpS;
    }

    public void SetRangerWpS(double value)
    {
        rangerWpS = value;
    }

}

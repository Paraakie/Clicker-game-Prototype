using UnityEngine;
using UnityEngine.UI;

public class BranchText : MonoBehaviour
{
    //Branch Values
    public Text branchText;

    private double branch_WpSec = 0.0;
    private double branch_WpClick = 1.0;

    

    // Update is called once per frame
    void Update()
    {
        //Display Text
        branchText.text = "Collect branches(+" + GetBranch_WpClick() + " $W)";
    }

    /**
     * Getters and Setters
     */

    //branch_WpSec
    public double GetBranch_WpSec()
    {
        return branch_WpSec;
    }

    public void SetBranch_WpSec(double newBranch_WpSec)
    {
        branch_WpSec = newBranch_WpSec;
    }

    //branch_WpClick
    public double GetBranch_WpClick()
    {
        return branch_WpClick;
    }

    public void SetBranch_WpClick(double newBranch_WpClick)
    {
        branch_WpClick = newBranch_WpClick;
    }

}

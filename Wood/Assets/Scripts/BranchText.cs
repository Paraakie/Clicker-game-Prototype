using UnityEngine;
using UnityEngine.UI;

public class BranchText : MonoBehaviour
{
    public Text branchText;

    private int branchPerSec = 1;

    // Update is called once per frame
    void Update()
    {
        //Display Text
        branchText.text = "Collect branches(+" + GetBranchPerSec() + " $W)";
    }

    /**
     * Getters and Setters
     */

    public int GetBranchPerSec()
    {
        return branchPerSec;
    }

    public void SetBranchPerSec(int newBranchPerSec)
    {
        branchPerSec = newBranchPerSec;
    }

}

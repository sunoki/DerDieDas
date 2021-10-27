using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recordHandler : MonoBehaviour
{
    private int intRecord;

    //UI
    public Text txtRecord;

    // Start is called before the first frame update
    void Start()
    {
        intRecord = PlayerPrefs.GetInt("record");
        txtRecord.text = "Der Rekord liegt bei " + intRecord + " richtigen Wörtern.";
    }

    public bool checkRecord(int intValue)
    {
        if (intValue > intRecord)
            return true;

        return false;
    }
    public void updateRecord(int intNewValue)
    {
        intRecord = intNewValue;
        txtRecord.text = "Das ist ein neuer Rekord!";
        PlayerPrefs.SetInt("record", intRecord);
    }
}

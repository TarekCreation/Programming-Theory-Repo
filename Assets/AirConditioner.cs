using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirConditioner : Device // INHERITANCE
{
    protected override void OnClosed() // POLYMORPHISM
    {
        Debug.Log("AirConditioner Was Closed");
    }

    protected override void OnOpen() // POLYMORPHISM
    {
        Debug.Log("AirConditioner Was Opened");
    }
}

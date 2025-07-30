using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Microwave : Device // INHERITANCE
{
    protected override void OnClosed() // POLYMORPHISM
    {
        Debug.Log("Microwave Was Closed");
    }

    protected override void OnOpen() // POLYMORPHISM
    {
        Debug.Log("Microwave Was Opened");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oven : Device // INHERITANCE
{
    protected override void OnClosed() // POLYMORPHISM
    {
        Debug.Log("Oven Was Closed");
    }

    protected override void OnOpen() // POLYMORPHISM
    {
        Debug.Log("Oven Was Opened");
    }
}

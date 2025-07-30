using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fridge : Device // INHERITANCE
{
    protected override void OnClosed() // POLYMORPHISM
    {
        Debug.Log("Fridge Was Closed");
    }

    protected override void OnOpen() // POLYMORPHISM
    {
        Debug.Log("Fridge Was Opened");
    }
}

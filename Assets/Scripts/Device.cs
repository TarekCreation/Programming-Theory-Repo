using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public abstract class Device : MonoBehaviour, IPointerClickHandler
{
    protected GameObject OpenVisual { get; private set; } //ENCAPSULATION
    protected GameObject ClosedVisual { get; private set; } //ENCAPSULATION
    protected bool IsOpen { get; private set; } = false; //ENCAPSULATION
    void Start()
    {
        SetUpVisuals(); //ABSTRACTION
    }
    void SetUpVisuals()
    {
        foreach (UnityEngine.UI.Image item in GetComponentsInChildren<UnityEngine.UI.Image>())
        {
            if (item.gameObject.name == "Open")
            {
                OpenVisual = item.gameObject;
            }
            else if (item.gameObject.name == "Closed")
            {
                ClosedVisual = item.gameObject;
            }
        }
        OpenVisual.SetActive(false);
        IsOpen = false;
    }
    protected abstract void OnClosed();
    protected abstract void OnOpen();
    public void OnPointerClick(PointerEventData eventData)
    {
        ActivateCorrectVisual(); //ABSTRACTION
    }
    protected void ActivateCorrectVisual()
    {
        IsOpen = !IsOpen;
        if (IsOpen)
        {
            OpenVisual.SetActive(true);
            ClosedVisual.SetActive(false);
            OnOpen();
        }
        else
        {
            OpenVisual.SetActive(false);
            ClosedVisual.SetActive(true);
            OnClosed();
        }
    }
}

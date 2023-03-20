using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonScr : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();

    public void OnMouseUpAsButton()
    {
        unityEvent.Invoke();
    }
}

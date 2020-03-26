using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EditorOnlyEvent : MonoBehaviour
{
    public UnityEvent onEditor;
    public UnityEvent onRuntime;

    void OnEnable()
    {
        if (Application.isEditor)
        {
            onEditor.Invoke();
        }
        else
        {
            onRuntime.Invoke();
        }
    }
}
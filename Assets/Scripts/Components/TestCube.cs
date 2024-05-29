using System;
using System.Collections;
using System.Collections.Generic;
using Events;
using UnityEngine;
using Zenject;

public class TestCube : MonoBehaviour
{
    [Inject] private ProjectEvents ProjectEvents { get; set; }

    private void OnEnable()
    {
        RegisterEvents();
    }
    private void OnDisable()
    {
        UnRegisterEvents();
    }
    private void RegisterEvents()
    {
        ProjectEvents.ProjectStarted += OnProjectInstalled;
    }

    private void OnProjectInstalled()
    {
        Debug.LogWarning("VAR");
    }
    private void UnRegisterEvents()
    {
        ProjectEvents.ProjectStarted-=OnProjectInstalled;

    }
}

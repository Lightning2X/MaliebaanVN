using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Abstract input interface that can throw away input if possible
/// </summary>
public class InputController : MonoBehaviour
{
    private bool _gamepressed;
    void Awake()
    {
        _gamepressed = false;
        UIActive = false;
    }

    public bool CheckGameClicked()
    {
        if (_gamepressed)
        {
            _gamepressed = false;
            return true;
        }
        else
            return false;
    }

    public void GameWasClicked() => _gamepressed = true;

    public bool UIActive { get; set; }
}

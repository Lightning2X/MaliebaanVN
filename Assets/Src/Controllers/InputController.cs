using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Abstract input interface that can throw away input if possible
/// </summary>
public class InputController : MonoBehaviour
{
    private static InputController _inputController;

    public enum InputLayer
    {
        UI,
        Dialogue,
        Game
    }
    private List<InputConstruct> _inputHandlers; 
    // Start is called before the first frame update
    void Awake()
    {
        _inputHandlers = new List<InputConstruct>();
    }

    void Update()
    {
        foreach (InputConstruct c in _inputHandlers)
        {
            if (c.Enabled)
                c.Handler();
        }
    }

    public void AddHandler(Action handler, InputLayer layer)
    {
        InputConstruct construct = new InputConstruct(handler, layer);
        _inputHandlers.Add(construct);
    }

    public void DisableLayer(InputLayer layer)
    {
        for (int i = 0; i < _inputHandlers.Count; i++)
        {
            if (_inputHandlers[i].Layer == layer)
                _inputHandlers[i].Enabled = false;
        }
    }

    public void EnableLayer(InputLayer layer)
    {
        for (int i = 0; i < _inputHandlers.Count; i++)
        {
            if (_inputHandlers[i].Layer == layer)
                _inputHandlers[i].Enabled = true;
        }
    }

    public class InputConstruct
    {
        public Action Handler { get; set; }
        public InputLayer Layer { get; set; }
        public bool Enabled { get; set; }
        public InputConstruct(Action handler, InputLayer layer)
        {
            this.Handler = handler;
            this.Layer = layer;
            Enabled = true;
        }
    }

}

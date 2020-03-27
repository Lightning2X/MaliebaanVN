using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController _gameController;

    private InputController inputController;
    // Start is called before the first frame update
    void Awake()
    {
        _gameController = this;
        inputController = this.gameObject.GetComponent<InputController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static InputController InputController => _gameController.inputController;

}

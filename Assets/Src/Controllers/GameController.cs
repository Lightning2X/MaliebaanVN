using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity.Example;

public class GameController : MonoBehaviour
{
    private static GameController _gameController;
    public ClassicDialogueUI dialogueHandler;
    private InputController inputController;
    // Start is called before the first frame update
    void Awake()
    {
        _gameController = this;
        inputController = this.gameObject.GetComponent<InputController>();
    }


    public static InputController InputController => _gameController.inputController;
    public static ClassicDialogueUI DialogueHandler => _gameController.dialogueHandler;

}

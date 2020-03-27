using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity.Example;

public class BackLogUpdater : MonoBehaviour
{
    private ClassicDialogueUI dialogueHandler;
    private Text _textBox;
    void Awake()
    {
        _textBox = this.gameObject.GetComponent<Text>();
        dialogueHandler = GameController.DialogueHandler;
    }
    // Update is called once per frame
    void OnEnable()
    {
        const string spacer = "\n\n";
        Queue<string> currentLines = dialogueHandler.LastLines;
        string result = "";
        foreach (string s in currentLines)
        {
            result += s + spacer;
        }

        _textBox.text = result;

    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity.Example;

public class DialogueHandler : MonoBehaviour
{
    public GameObject yarn;

    public void DisableInput()
    {
        yarn.SetActive(false);
    }

    public void EnableInput()
    {
        yarn.SetActive(true);
    }
}

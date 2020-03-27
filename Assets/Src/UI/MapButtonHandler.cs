using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapButtonHandler : MonoBehaviour
{
    public GameObject map, blur;
    public void Clicked()
    {
        if (map.activeSelf)
            CloseMap();
        else
            OpenMap();
    }

    private void OpenMap()
    {
        map.SetActive(true);
        blur.SetActive(true);
        GameController.InputController.UIActive = true;
    }

    private void CloseMap()
    {
        map.SetActive(false);
        blur.SetActive(false);
        GameController.InputController.UIActive = false;
    }
}

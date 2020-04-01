using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomOverlayHandler : MonoBehaviour
{
    public GameObject overlay, blur;
    public void Clicked()
    {
        if (overlay.activeSelf)
            CloseOverlay();
        else if (!GameController.InputController.UIActive)
            OpenOverlay();
    }

    private void OpenOverlay()
    {
        overlay.SetActive(true);
        blur.SetActive(true);
        GameController.InputController.UIActive = true;
    }

    private void CloseOverlay()
    {
        overlay.SetActive(false);
        blur.SetActive(false);
        GameController.InputController.UIActive = false;
    }
}

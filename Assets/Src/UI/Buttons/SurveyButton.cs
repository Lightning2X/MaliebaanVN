using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurveyButton : MonoBehaviour
{
    public void Clicked()
    {
        Application.OpenURL("https://forms.gle/7qAYQoKYBYAtQNsC8");
    }
}

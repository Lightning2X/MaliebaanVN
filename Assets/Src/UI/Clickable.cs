using UnityEngine;
using UnityEngine.EventSystems;

public class Clickable : MonoBehaviour, IPointerClickHandler 
{
    public void OnPointerClick(PointerEventData data) {
        GameController.InputController.GameWasClicked(); 
    }
}

using UnityEngine.SceneManagement;
using UnityEngine;

public class StartButtonHandler : MonoBehaviour
{
    public void Clicked()
    {
        SceneManager.LoadScene("main");
    }
}

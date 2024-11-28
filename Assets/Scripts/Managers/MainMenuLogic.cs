using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{
    [SerializeField] private Button _mainMenuButton;
    void Start()
    {
        _mainMenuButton.onClick.AddListener(LoadMainMenu);
    }

   private void  LoadMainMenu()
    {
        SceneManager.LoadScene("Lobby");
    }
}

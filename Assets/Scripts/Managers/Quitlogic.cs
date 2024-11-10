using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quitlogic : MonoBehaviour
{
    [SerializeField] private Button _quitbutton;


    void Start()
    {
        _quitbutton.onClick.AddListener(Quit);
    }

    private void Quit()
    {
        Application.Quit();
    }
}

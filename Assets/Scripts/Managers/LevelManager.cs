using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Button _button;
   
    public void Awake()
    {
        
    }

    public void Start()
    {
        _button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {

        SceneManager.LoadScene("SnakeGame");
    }
}

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
    private int _currentSceneIndex;
    public void Awake()
    {
        
    }

    public void Start()
    {
        _button.onClick.AddListener(OnClick);

        
        _currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnClick()
    {
        SoundManager.Instance.PlaySoundEfffect(SoundManager.Sounds.button);

        SceneManager.LoadScene(_currentSceneIndex);
    }
}

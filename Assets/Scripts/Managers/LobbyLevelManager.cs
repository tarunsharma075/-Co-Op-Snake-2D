using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyLevelManager : MonoBehaviour
{
    [SerializeField] Button _leveltochoose;
    [SerializeField] string _level;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        _leveltochoose.onClick.AddListener(OnClick);  
    }

    private void OnClick()
    {

        SoundManager.Instance.PlaySoundEfffect(SoundManager.Sounds.button);
        SceneManager.LoadScene(_level);
    }
}

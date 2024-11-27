using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.Timeline;

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
        StartCoroutine(NextScreenLoading());
    }

    private  IEnumerator NextScreenLoading()
    {
        SoundManager.Instance.PlaySoundEfffect(SoundManager.Sounds.button);

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(_currentSceneIndex);

        SoundManager.Instance.PlayBackgroudnMusic(SoundManager.Sounds.background);
    }
}

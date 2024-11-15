using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviour
{
    [SerializeField] private Button _buttonplay;
    [SerializeField] private GameObject _insctruction;
    [SerializeField] private GameObject _lobby;
    [SerializeField] private GameObject _levelchooselobby;


    private void Start()
    {
        // Directly use the button assigned in the inspector, no need to reassign in Awake
        _buttonplay.onClick.AddListener(OnClickPlay);
    }

    private void OnClickPlay()
    {
        StartCoroutine(Instructioslevelchanger());
        SoundManager.Instance.PlaySoundEfffect(SoundManager.Sounds.button);
    }

    private IEnumerator Instructioslevelchanger()
    {
        _lobby.SetActive(false);
        _insctruction.SetActive(true);
        yield return new WaitForSeconds(2);
        _insctruction.SetActive(false);
        _levelchooselobby.SetActive(true);
    }
}


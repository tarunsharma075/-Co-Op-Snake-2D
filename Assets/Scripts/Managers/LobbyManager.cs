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

    private void Start()
    {
        // Directly use the button assigned in the inspector, no need to reassign in Awake
        _buttonplay.onClick.AddListener(OnClickPlay);
    }

    private void OnClickPlay()
    {
        StartCoroutine(Instructioslevelchanger());
    }

    private IEnumerator Instructioslevelchanger()
    {
        _lobby.SetActive(false);
        _insctruction.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("SnakeGame"); // Add the actual scene name
    }
}


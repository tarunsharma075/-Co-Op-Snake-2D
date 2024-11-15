using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _maingameobj;
    [SerializeField] private GameObject _pausemenu;
    [SerializeField] private Button _resume;

    private void Start()
    {
      
        _resume.onClick.AddListener(ClickAction);
    }

    private void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SoundManager.Instance.PlaySoundEfffect(SoundManager.Sounds.pause);
            _maingameobj.SetActive(false);
            _pausemenu.SetActive(true);
        }
    }

    private void ClickAction()
    {
        _maingameobj.SetActive(true);
        _pausemenu.SetActive(false);
    }
}

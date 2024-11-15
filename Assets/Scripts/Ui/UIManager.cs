using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoretextforsnake;
    [SerializeField] private GameObject _winscreenforsnake;
    [SerializeField] private GameObject _maingamescreen;
    private int Score = 0;
    


    private void Awake()
    {
        _scoretextforsnake = GetComponent<TextMeshProUGUI>();
        
    }

    private void Start()
    {
        RefreshUi();
        
    }
    public void IncreaseScore(int increment)
    {
       Score += increment;
        RefreshUi();
        if (Score >= 100)
        {
            SoundManager.Instance.StopBakcgroundMusic();
            SoundManager.Instance.PlaySoundEfffect(SoundManager.Sounds.win); 
            _maingamescreen.SetActive(false);
            _winscreenforsnake.SetActive(isActiveAndEnabled);
        }
    }
    

    public void RefreshUi()
    {
        _scoretextforsnake.text = "Score : " + Score;


    }
   

    public void DecreaseScore(int lossscore) {

        Score -= lossscore;

        RefreshUi();
        if (Score < 0) { 
        Score= 0;   
            RefreshUi() ;
        
        }
    }
   
}

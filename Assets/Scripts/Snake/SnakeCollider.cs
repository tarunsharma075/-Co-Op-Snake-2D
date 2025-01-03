using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeCollider : MonoBehaviour
{
    [SerializeField] private GameObject _maingameobj;
    [SerializeField] private GameObject _restartobj;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<ScreenWrapping>() != null || collision.gameObject.GetComponent<SnakeMovement>())
        {
            SoundManager.Instance.StopBakcgroundMusic();
            SoundManager.Instance.PlaySoundEfffect(SoundManager.Sounds.death);
            _maingameobj.SetActive(false);
            _restartobj.SetActive(true);


        }
    }
}

using System.Collections;
using UnityEngine;



public class BehaviourOfPowerups : MonoBehaviour
{
    [SerializeField] private BoxCollider2D _border;
    [SerializeField] private GameObject _bananavisual;
    [SerializeField] private GameObject _shieldvisual;



   public  void RandomPositionOfPowerups()
    {
        Bounds bounds = this._border.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);



    }


    private void Start()
    {
        StartCoroutine(RandomNessInPowerupsPositionForBanana());
        StartCoroutine(RandomNessInPowerupsPositionForShield());
    }

    private IEnumerator RandomNessInPowerupsPositionForBanana()
    {
        while (true)
        {
            _bananavisual.SetActive(false);


            yield return new WaitForSeconds(Random.Range(10, 15));
            _bananavisual.SetActive(true);
            RandomPositionOfPowerups();
            //Debug.Log("powerup is inactive now");
            yield return new WaitForSeconds(3);

        }

    }

    private IEnumerator RandomNessInPowerupsPositionForShield()
    {
        while (true) {


            _shieldvisual.SetActive(false);
            yield return new WaitForSeconds(Random.Range(15, 20));
            _shieldvisual.SetActive(true);
            RandomPositionOfPowerups();
            yield return new WaitForSeconds(5);

        }




    }
}

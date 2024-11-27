using System.Collections;
using UnityEngine;



public class BehaviourOfPowerups : MonoBehaviour
{
    [SerializeField] private BoxCollider2D _border;
    [SerializeField] private GameObject _childvisual;
  



   public  void RandomPositionOfPowerups()
    {
        Bounds bounds = this._border.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);



    }


    private void Start()
    {
        StartCoroutine(RandomNessInPowerups());

    }

    private IEnumerator RandomNessInPowerups()
    {
        while (true)
        {
            _childvisual.SetActive(false);


            yield return new WaitForSeconds(Random.Range(10, 15));
            _childvisual.SetActive(true);
            RandomPositionOfPowerups();
            //Debug.Log("powerup is inactive now");
            yield return new WaitForSeconds(3);

        }

    }

}

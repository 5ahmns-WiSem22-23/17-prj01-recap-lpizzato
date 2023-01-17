using UnityEngine;

public class PickUps : MonoBehaviour
{
    public GameObject pickUps;
    [SerializeField] GameObject deliveredPickUps;
    [SerializeField] Sprite pinguinCandy;
    [SerializeField] Sprite pinguin;
    SpriteRenderer sr;

    private void Awake()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        InstantiatePickUp(pickUps, -12.5f, 7.0f, 12.8f, -7.2f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            Destroy(other.gameObject);
            sr.sprite = pinguinCandy;
        }

        if (other.gameObject.CompareTag("CandyStation"))
        {
            if (sr.sprite == pinguinCandy)
            {
                sr.sprite = pinguin;
                InstantiatePickUp(deliveredPickUps, 9.6f, 13.1f, -12.8f, -8.8f);
                InstantiatePickUp(pickUps, -12.5f, 7.0f, 12.8f, -7.2f);
            }
        }
    }

    public void InstantiatePickUp(GameObject pickUp, float xStart, float xEnd, float yStart, float yEnd)
    {
        Instantiate(pickUp, new Vector3(Random.Range(xStart, xEnd), Random.Range(yStart, yEnd), -1), Quaternion.Euler(0, 0, Random.Range(0, 360)));
    }
}
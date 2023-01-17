using UnityEngine;

public class CollissionDetection : MonoBehaviour
{
    public bool colliding;
    PickUps pu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        colliding = true;
        Debug.Log(colliding);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        colliding = false;
        Debug.Log(colliding);
    }

    private void Update()
    {
        if (colliding)
        {
            pu.InstantiatePickUp(pu.pickUps, -12.5f, 7.0f, 12.8f, -7.2f);
            Debug.Log("collision!");
            Destroy(gameObject);
            Debug.Log("Destoryed");
        }
    }
}
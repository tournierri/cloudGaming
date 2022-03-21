using UnityEngine;

public class WeakSpot : MonoBehaviour
{
    public GameObject objectToDestroy;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(objectToDestroy);
    }
}

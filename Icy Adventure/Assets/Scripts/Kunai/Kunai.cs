using UnityEngine;

public class Kunai : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
    }
}
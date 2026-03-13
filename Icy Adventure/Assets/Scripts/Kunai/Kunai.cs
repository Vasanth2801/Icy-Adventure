using UnityEngine;

public class Kunai : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        EnemyHealth eh = collision.gameObject.GetComponent<EnemyHealth>();
        if (eh != null)
        {
            eh.TakeDamage(10);
        }

        gameObject.SetActive(false);
    }
}
using UnityEngine;

public class KunaiThrow : MonoBehaviour
{
    [Header("Kunai Speed")]
    [SerializeField] private float kunaiThrow = 20f;

    [Header("References")]
    [SerializeField] private ObjectPooler pooler;
    [SerializeField] private Transform firePoint;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            Kunai();
        }
    }

    void Kunai()
    {
        GameObject kunai = pooler.SpawnFromPools("Kunai",firePoint.position,firePoint.rotation);
        Rigidbody2D rb = kunai.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * kunaiThrow,ForceMode2D.Impulse);
    }
}
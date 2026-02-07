using UnityEngine;

public class FallingLog : MonoBehaviour
{
    private Rigidbody rb;
    private Collider col;

    public float stunDuration = 5f;
    private bool hasFallen = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
    }

    void Start()
    {
        rb.isKinematic = true;
        rb.useGravity = false;

        if (col != null)
            col.enabled = false;
    }

    public void Drop()
    {
        if (hasFallen) return;

        hasFallen = true;

        if (col != null)
            col.enabled = true;

        rb.isKinematic = false;
        rb.useGravity = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        EnemyAI enemy = collision.collider.GetComponentInParent<EnemyAI>();

        if (enemy != null)
        {
            enemy.Stun(stunDuration);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
    EnemyAI enemy = other.GetComponentInParent<EnemyAI>();

    if (enemy != null)
    {
        enemy.Stun(stunDuration);
    }
    }

}

using UnityEngine;

public class LogTrigger : MonoBehaviour
{
    public FallingLog log;
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (triggered) return;

        EnemyAI enemy = other.GetComponentInParent<EnemyAI>();

        if (enemy != null && log != null)
        {
            triggered = true;
            log.Drop();
        }
    }
}

using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;

    public float sightRange = 15f;
    public float attackRange = 2f;

    public bool canChase = false;   

    private bool playerInSight = false;
    private bool isStunned = false;
    private float stunEndTime = 0f;

    private Vector3 spawnPosition;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        spawnPosition = transform.position;

        agent.isStopped = true;
    }

    void Update()
    {
        if (!canChase)
        {
            agent.ResetPath();
            agent.isStopped = true;
            return;
        }

        agent.isStopped = false;

        if (isStunned)
        {
            agent.ResetPath();
            if (Time.time > stunEndTime)
                isStunned = false;

            return;
        }

        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        playerInSight = distanceToPlayer <= sightRange;

        if (playerInSight)
        {
            agent.SetDestination(player.position);

            if (distanceToPlayer <= attackRange)
            {
                PlayerDeath death = player.GetComponent<PlayerDeath>();
                if (death != null)
                    death.KillPlayer();
            }
        }
        else
        {
            agent.ResetPath();
        }
    }

    public void EnableChase()
    {
        canChase = true;
    }

    public void Stun(float duration)
    {
        isStunned = true;
        stunEndTime = Time.time + duration;
        agent.ResetPath();
    }

    public void ResetToSpawn()
    {
        isStunned = false;
        playerInSight = false;

        if (agent != null)
        {
            agent.ResetPath();
            agent.Warp(spawnPosition);
        }
        else
        {
            transform.position = spawnPosition;
        }
    }
}

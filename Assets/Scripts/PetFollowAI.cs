using UnityEngine;
using UnityEngine.AI;

public class PetFollowAI : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent agent;

    public float followDistance = 5f;        
    public float teleportDistance = 20f;     
    public float stoppingDistance = 2f;      

    void Start()
    {
        if (agent == null)
            agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance > teleportDistance)
        {
            agent.Warp(player.position - player.forward * followDistance);
            return;
        }

        if (distance > followDistance)
        {
            agent.stoppingDistance = stoppingDistance;
            agent.SetDestination(player.position);
        }
        else
        {
            agent.ResetPath();
        }
    }
}

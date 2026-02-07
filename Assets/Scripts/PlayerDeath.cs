using UnityEngine;
using TMPro;
using System.Collections;

public class PlayerDeath : MonoBehaviour
{
    public TextMeshProUGUI deathText;
    public Transform respawnPoint;
    public float respawnDelay = 3f;

    public EnemyAI enemy;     

    private FPSController controller;
    private CharacterController characterController;

    void Start()
    {
        controller = GetComponent<FPSController>();
        characterController = GetComponent<CharacterController>();

        if (deathText != null)
            deathText.gameObject.SetActive(false);
    }

    public void KillPlayer()
    {
        StartCoroutine(DeathSequence());
    }

    IEnumerator DeathSequence()
    {
        if (controller != null)
            controller.canMove = false;
        if (deathText != null)
        {
            deathText.text = "You Died!";
            deathText.gameObject.SetActive(true);
        }

        if (enemy != null)
            enemy.ResetToSpawn();

        yield return new WaitForSeconds(respawnDelay);

        if (deathText != null)
            deathText.gameObject.SetActive(false);

        if (respawnPoint != null)
        {
            if (characterController != null)
                characterController.enabled = false;

            transform.position = respawnPoint.position;

            if (characterController != null)
                characterController.enabled = true;
        }

        if (controller != null)
            controller.canMove = true;
    }
}

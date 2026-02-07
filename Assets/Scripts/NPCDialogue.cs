using UnityEngine;
using TMPro;
using System.Collections;

public class NPCDialogue : MonoBehaviour
{
    public string[] dialogueLines;
    public TextMeshProUGUI dialogueText;
    public GameObject dialoguePanel;

    public EnemyAI enemy;   

    bool playerInRange = false;
    bool isTalking = false;
    bool hasFinishedDialogue = false;

    void Start()
    {
        dialoguePanel.SetActive(false);
    }

    void Update()
    {
        if (playerInRange && !isTalking && !hasFinishedDialogue)
        {
            isTalking = true;
            dialoguePanel.SetActive(true);
            StartCoroutine(PlayDialogue());
        }
    }

    IEnumerator PlayDialogue()
    {
        for (int i = 0; i < dialogueLines.Length; i++)
        {
            dialogueText.text = dialogueLines[i];
            yield return new WaitForSeconds(4f);
        }

        dialoguePanel.SetActive(false);
        isTalking = false;
        hasFinishedDialogue = true;

        if (enemy != null)
        {
            enemy.EnableChase();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            playerInRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            dialoguePanel.SetActive(false);
            StopAllCoroutines();

            isTalking = false;
            hasFinishedDialogue = false;
        }
    }
}

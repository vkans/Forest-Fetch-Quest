using UnityEngine;
using TMPro;

public class PageManager : MonoBehaviour
{
    public static PageManager Instance;

    public int totalPages = 3;
    public int pagesCollected = 0;

    public TextMeshProUGUI pageText;
    public TextMeshProUGUI objectiveText;

    public GameObject endPortal;      
    public Transform player;          
    public float activationDistance = 40f;

    private bool allPagesCollected = false;
    private bool portalActivated = false;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        pageText.text = "Pages: 0/" + totalPages;

        if (objectiveText != null)
            objectiveText.gameObject.SetActive(false);

        if (endPortal != null)
            endPortal.SetActive(false);
    }

    void Update()
    {
        if (allPagesCollected && !portalActivated)
        {
            float distance = Vector3.Distance(player.position, endPortal.transform.position);

            if (distance <= activationDistance)
            {
                endPortal.SetActive(true);
                portalActivated = true;
            }
        }
    }

    public void CollectPage()
    {
        pagesCollected++;
        pageText.text = "Pages: " + pagesCollected + "/" + totalPages;

        if (pagesCollected >= totalPages)
        {
            allPagesCollected = true;

            if (objectiveText != null)
            {
                objectiveText.text = "The air feels different... return to the hut.";
                objectiveText.gameObject.SetActive(true);
            }
        }
    }
}

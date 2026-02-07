using UnityEngine;
using TMPro;

public class PageCounterUI : MonoBehaviour
{
    public TextMeshProUGUI pageText;

    void Update()
    {
        pageText.text = "Pages: " + PageManager.Instance.pagesCollected + "/" + PageManager.Instance.totalPages;
    }
}

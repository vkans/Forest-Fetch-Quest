using UnityEngine;
using TMPro;

public class PortalGate : MonoBehaviour
{
    public TextMeshProUGUI endText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            endText.gameObject.SetActive(true);
            endText.text = "You Escaped!";
            Time.timeScale = 0f;
        }
    }
}

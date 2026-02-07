using UnityEngine;

public class Page : MonoBehaviour
{
    public AudioClip pickupSound;
    private bool collected = false;

    private void OnTriggerEnter(Collider other)
    {
        if (collected) return;

        if (other.CompareTag("Player"))
        {
            collected = true;
            if (pickupSound != null)
            {
                AudioSource.PlayClipAtPoint(
                    pickupSound,
                    transform.position,
                    1f
                );
            }

            PageManager.Instance.CollectPage();

            Destroy(gameObject);
        }
    }
}

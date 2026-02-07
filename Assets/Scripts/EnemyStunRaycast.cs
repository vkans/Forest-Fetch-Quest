using UnityEngine;
using TMPro;

public class EnemyStunRaycast : MonoBehaviour
{
    public Camera playerCamera;
    public float rayDistance = 30f;

    public KeyCode stunKey = KeyCode.E;
    public float stunDuration = 3f;

    public float stunCooldown = 5f;
    private float nextStunTime = 0f;

    public TextMeshProUGUI stunText;

    void Start()
    {
        if (stunText != null)
            stunText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(stunKey))
        {
            TryStunEnemy();
        }
    }

    void TryStunEnemy()
    {
        if (Time.time < nextStunTime)
            return;

        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            EnemyAI enemy = hit.collider.GetComponent<EnemyAI>();

            if (enemy != null)
            {
                enemy.Stun(stunDuration);
                nextStunTime = Time.time + stunCooldown;

                ShowStunUI();
            }
        }
    }

    void ShowStunUI()
    {
        if (stunText == null) return;

        stunText.text = "Enemy Stunned!";
        stunText.gameObject.SetActive(true);

        CancelInvoke(nameof(HideStunUI));
        Invoke(nameof(HideStunUI), 1.5f); 
    }

    void HideStunUI()
    {
        if (stunText != null)
            stunText.gameObject.SetActive(false);
    }
}

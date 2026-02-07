using UnityEngine;
using TMPro;

public class EndText : MonoBehaviour
{
    public static EndText Instance; 

    public TextMeshProUGUI endMessage;  

    void Awake()
    {
        Instance = this;
        endMessage.gameObject.SetActive(false); 
    }

    public void ShowEndScreen(string message)
    {
        endMessage.text = message;
        endMessage.gameObject.SetActive(true);
        Time.timeScale = 0f;  
    }
}

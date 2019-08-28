using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class DestroyPlayer : NetworkBehaviour
{
    [SyncVar]
    public int health = 5;
    Text healthText;

    private void Start()
    {
        healthText = GameObject.Find("PlayerHealthText").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (health < 1)
        {
            Destroy();
        }

        healthText.text = "Health: " + health;
    }

    void Destroy()
    {
        FindObjectOfType<GameManager>().EndGame();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            health--;
        }
        if (health < 1)
        {
            Destroy();
        }   
    }
}

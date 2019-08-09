using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyPlayer : MonoBehaviour
{
    public int health = 5;

    // Update is called once per frame
    void Update()
    {
        if (health < 1)
        {
            Destroy();
        }
    }
    void Destroy()
    {
        FindObjectOfType<GameManger>().EndGame();
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

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(20, 20, 250, 120));
        GUILayout.Label("[[ Player Health: " + health + " ]]");
        GUILayout.EndArea();
    }
}

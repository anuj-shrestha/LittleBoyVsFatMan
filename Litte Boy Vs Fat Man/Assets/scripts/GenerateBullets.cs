using UnityEngine;
using System.Collections.Generic;

public class GenerateBullets : MonoBehaviour
{
    public float fireRate = 0.1f;
    public GameObject bullet;
    public int bulletPoolAmount = 5;
    List<GameObject> bullets;

    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>();

        for(int i = 0; i < bulletPoolAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(bullet);
            obj.SetActive(false);
            bullets.Add(obj);

        }
        InvokeRepeating("FireBullet", fireRate, fireRate);
    }

    void FireBullet()
    {
        //GameObject obj = (GameObject) Instantiate(bullet, transform.position, Quaternion.identity);

        for (int i = 0; i < bullets.Count; i++)
        {
            if(!bullets[i].activeInHierarchy)
            {
                bullets[i].transform.position = transform.position;
                bullets[i].transform.rotation = transform.rotation;
                bullets[i].SetActive(true);
                break;
            }
        }
    }

}

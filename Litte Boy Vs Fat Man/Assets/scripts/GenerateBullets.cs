using UnityEngine;
using System.Collections.Generic;

public class GenerateBullets : MonoBehaviour
{
    public static float fireRate = 1f;
    public GameObject bullet;
    public int bulletPoolAmount = 5;
    List<GameObject> bullets;
    float time = 0;

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
    }

    private void FixedUpdate()
    {
        time += Time.fixedDeltaTime;

        if (time > fireRate)
        {
            FireBullet();
            time = 0;
        }

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

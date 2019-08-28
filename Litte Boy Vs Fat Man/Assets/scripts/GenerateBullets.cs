using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Networking;

public class GenerateBullets : NetworkBehaviour
{
    public static float fireRate = 1f;
    public GameObject bullet;
    public int bulletPoolAmount = 20;
    List<GameObject> bullets;
    float time = 0;
    int planeType = 0;

    // Start is called before the first frame update
    void Start()
    {
        fireRate = 1f;
        bullets = new List<GameObject>();

        for(int i = 0; i < bulletPoolAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(bullet);
            obj.SetActive(false);
            bullets.Add(obj);
        }
        planeType = PlayerPrefs.GetInt("PlaneType", 0);
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

        if (planeType == 1)
        {
            for (int i = 0; i < bullets.Count; i = i + 2)
            {
                if (!bullets[i].activeInHierarchy)
                {
                    bullets[i].transform.position = new Vector3(transform.position.x - 0.45f, transform.position.y, transform.position.z);
                    bullets[i].transform.rotation = transform.rotation;
                    bullets[i].SetActive(true);
                }
                if (i + 1 < bullets.Count && !bullets[i + 1].activeInHierarchy)
                {
                    bullets[i + 1].transform.position = new Vector3(transform.position.x + 0.45f, transform.position.y, transform.position.z);
                    bullets[i + 1].transform.rotation = transform.rotation;
                    bullets[i + 1].SetActive(true);
                    break;
                }
            }
        } else if (planeType >= 2)
        {
            for (int i = 0; i < bullets.Count; i = i + 3)
            {
                if (!bullets[i].activeInHierarchy)
                {
                    bullets[i].transform.position = new Vector3(transform.position.x, transform.position.y + 0.25f, transform.position.z);
                    bullets[i].transform.rotation = transform.rotation;
                    bullets[i].SetActive(true);
                }
                if (i + 1 < bullets.Count && !bullets[i + 1].activeInHierarchy)
                {
                    bullets[i+1].transform.position = new Vector3 (transform.position.x - 0.45f, transform.position.y, transform.position.z);
                    bullets[i+1].transform.rotation = transform.rotation;
                    bullets[i+1].SetActive(true);
                }
                if (i + 2 < bullets.Count && !bullets[i + 2].activeInHierarchy)
                {
                    bullets[i + 2].transform.position = new Vector3(transform.position.x + 0.45f, transform.position.y, transform.position.z);
                    bullets[i + 2].transform.rotation = transform.rotation;
                    bullets[i + 2].SetActive(true);
                    break;
                }

            }
        }
        else
        {
            for (int i = 0; i < bullets.Count; i++)
            {
                if (!bullets[i].activeInHierarchy)
                {
                    bullets[i].transform.position = transform.position;
                    bullets[i].transform.rotation = transform.rotation;
                    bullets[i].SetActive(true);
                    break;
                }
            }
        }

    }

}

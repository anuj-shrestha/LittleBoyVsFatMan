using UnityEngine;
using System.Collections.Generic;

public class GameManger : MonoBehaviour
{
    public GameObject bg;
    public int bgPool = 3;
    List<GameObject> bgs;

    void Start()
    {
        bgs = new List<GameObject>();

        for (int i = 0; i < bgPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(bg);
            obj.SetActive(false);
            bgs.Add(obj);

        }

        spawnBg();
    }

    void spawnBg()
    {
        for (int i = 0; i < bgs.Count; i++)
        {
            //RectTransform rt = (RectTransform) bgs[i].transform;
            //float imgHeight = rt.rect.height;
            float imgHeight = bgs[i].GetComponent<SpriteRenderer>().sprite.bounds.size.x;  // this is gonna be our height
            bgs[i].transform.position = new Vector3(transform.position.x, imgHeight * i, transform.position.z);
            bgs[i].SetActive(true);
        }
    }


}

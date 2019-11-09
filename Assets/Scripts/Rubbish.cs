using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rubbish : MonoBehaviour
{
    GameObject[] bulletRB;
    int posititon;
    public GameObject Prefab;
    Object trash;
    float time = 0;
    public string[] imageResources;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        bulletRB = new GameObject[15];

    }
    // Update is called once per frame
    private void Update()
    {
         time += Time.deltaTime;
        if (time > 2)
        {
            time = 0;
            Configure();
        }
    }

    void setImage()
    {
        posititon = UnityEngine.Random.Range(0, 5);
        Debug.Log(posititon);
        trash = Resources.Load(imageResources[posititon]);

    }
    void setPosition()
    {
        Vector3 pos = Vector3.zero;
        pos.x = Random.Range(-0.5f,0.3f);
        pos.y = Random.Range(-2f, 4f);

    }
    void Configure()
    {
        setImage();
        GameObject bullet = (GameObject)Instantiate(trash);
        bulletRB[i] = bullet;
        Vector3 pos = Vector3.zero;
        pos.x = Random.Range(-0.5f, 0.3f);
        pos.y = Random.Range(-2f, 4f);
        bulletRB[i].transform.position = pos;
        for(int i = 0; i < 15; i++)
        {
            if (bulletRB[i] == null) break;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       // if(CompareTag("Voco") &&)
    }
    private void OnMouseDown()
    {
        Debug.Log(i);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjs : Singleton<SpawnObjs>
{
    public List<GameObject> objects;
    public List<GameObject> bonus;
    float spawnObjTimer = 4f;

    void Start()
    {
        System.Random rnd = new System.Random();
        int index = rnd.Next(0, objects.Count);

        Instantiate(objects[index], new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 11.5f, 0), Quaternion.identity);
        Invoke("spawnNewBonus", rnd.Next(10, 15));
    }

    void Update()
    {
        spawnObjTimer -= Time.deltaTime;
        if (spawnObjTimer < 0f)
        {
            spawnObjTimer = 4f - (GameManager.Instance.gameSpeed * 0.1f);
            spawnNewObj();
        }
    }

    public void spawnNewObj()
    {
        System.Random rnd = new System.Random();
        int index = rnd.Next(0, objects.Count);

        Instantiate(objects[index], new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 11.5f, 0), Quaternion.identity);
    }

    public void spawnNewBonus()
    {
        System.Random rnd = new System.Random();
        int index = rnd.Next(0, bonus.Count);

        Instantiate(bonus[index], new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 11.5f, 0), Quaternion.identity);
        Invoke("spawnNewBonus", rnd.Next(5, 15));
    }


}

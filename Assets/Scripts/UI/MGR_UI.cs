using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGR_UI : MonoBehaviour
{

    public GameObject SystemPrefab;
    public GameObject _overlay;
    GameObject prefabInstance;
    


    public void InstantiateSystemPrefab()
    {
        prefabInstance = Instantiate(SystemPrefab);
    }

    void OnDestroy()
    {
        Destroy(prefabInstance);
    }
}

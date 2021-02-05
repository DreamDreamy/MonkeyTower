using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPlay : MonoBehaviour
{
    public GameObject infoPanel;
    
    void Start()
    {
        infoPanel.SetActive(false);
    }

    public void onClick()
    {
        infoPanel.SetActive(true);
    }
}

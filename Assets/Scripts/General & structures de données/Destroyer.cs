using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collid)
    {
        if (collid.gameObject.tag == "Fond") collid.gameObject.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 20f, 0);
        else if (collid.gameObject.tag == "Player") _MGR_SceneManager.Instance.EndGame();
        else if (collid.gameObject.tag != "Obstacle") Destroy(collid.gameObject);
    }

    void OnTriggerExit2D(Collider2D collid)
    {
        if (collid.gameObject.tag == "Obstacle")
        {
            Destroy(collid.gameObject);
        }
    }
}

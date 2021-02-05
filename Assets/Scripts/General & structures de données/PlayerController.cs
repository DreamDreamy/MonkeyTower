using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + GameManager.Instance.gameSpeed * Time.deltaTime, transform.position.z);
        Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + GameManager.Instance.gameSpeed * Time.deltaTime, Camera.main.transform.position.z);
    }

    public void attackOff()
    {
        GetComponent<Animator>().SetBool("isAttacking", false);
    }

    public void crouchOff()
    {
        GetComponent<Animator>().SetBool("isCrouching", false);
    }
}

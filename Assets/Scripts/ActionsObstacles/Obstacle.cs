using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public string actionToDo;
    public bool isActive = true;
    void OnTriggerStay2D(Collider2D collid)
    {
        if (Action.Instance.actionDoing == actionToDo && collid.gameObject.tag == "Player")
        {
            Action.Instance.actionDoing = " ";
            isActive = false;
            this.GetComponent<Animator>().SetBool("isActive", false);
            if (actionToDo == "GetCoin") Coins.Instance.addCoin();
            if (actionToDo == "GetBanana") collid.gameObject.transform.position = new Vector3(collid.gameObject.transform.position.x, collid.gameObject.transform.position.y + PlayerStats.Instance.bananaHeal, 0);
        }
        if(Action.Instance.actionDoing != actionToDo && Action.Instance.actionDoing != " " && Action.Instance.actionDoing != "GetBanana" && Action.Instance.actionDoing != "GetCoin" && actionToDo != "GetBanana" && actionToDo != "GetCoin")
        {
            Action.Instance.actionDoing = " ";
            collid.gameObject.transform.position = new Vector3(collid.gameObject.transform.position.x, collid.gameObject.transform.position.y - PlayerStats.Instance.damage, 0);
        }
    }
}

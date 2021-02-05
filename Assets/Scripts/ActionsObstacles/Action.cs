using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : Singleton<Action>
{
    public string actionDoing;
    float timer;
    public void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.5f)
        {
            actionDoing = " ";
            timer = 0;
        }
    }

    public void doAction(string actionName)
    {
        actionDoing = actionName;
        if(actionName == "Attack" || actionName == "BreakBox") PlayerController.Instance.GetComponent<Animator>().SetBool("isAttacking", true);
        if(actionName == "Crouch") PlayerController.Instance.GetComponent<Animator>().SetBool("isCrouching", true);
        timer = 0;
    }
}

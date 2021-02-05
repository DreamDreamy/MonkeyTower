using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTrigger : MonoBehaviour
{
    float timerInvulnerable = 0;

    void Update()
    {
        timerInvulnerable += Time.deltaTime;
    }
    void OnTriggerEnter2D(Collider2D collid)
    {
        if (collid.gameObject.tag == "Player" && timerInvulnerable > 1f && this.GetComponentInParent<Obstacle>().isActive)
        {
            timerInvulnerable = 0;
            collid.gameObject.transform.position = new Vector3(collid.gameObject.transform.position.x, collid.gameObject.transform.position.y - PlayerStats.Instance.damage, 0);
        }
    }
}

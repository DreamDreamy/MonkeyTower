using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimTitle : MonoBehaviour
{
    public Text m;
    public Outline pink;
    public Outline black;
    public Color brokenColor;
    public Color brokenColorOutline;
    public Color pinkColor;
    public Color pinkColorOutline;
    public GameObject[] lights;

    void Start()
    {
        StartCoroutine("Blinking");
    }

    IEnumerator Blinking()
    {
        float i = 0;
        while (i <= Random.Range(1, 4))
        {

            yield return new WaitForSeconds(0.1f);
            pink.effectColor = brokenColorOutline;
            m.color = brokenColor;
            lights[0].SetActive(true);
            lights[1].SetActive(false);

            yield return new WaitForSeconds(0.1f);
            pink.effectColor = pinkColorOutline;
             m.color = pinkColor;
            lights[0].SetActive(false);
            lights[1].SetActive(true);
            i++;
        }
        yield return new WaitForSeconds(Random.Range(5, 30));
        StartCoroutine("Blinking");
    }
}

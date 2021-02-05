using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Skill
{
    public string name;
    //public bool isActiveSkill = false;
    public bool isActive = false;
    public bool isActivable = false;
    public string precedentSkill = "";
    [HideInInspector] public Button buttonSkill;
    //public Button buttonActiveSkill;
    public int scoreToUnlock;
    //public float cooldownSkill;
    //public float durationSkill;
    //public float timer;
    public Language skillTextInDifferentsLanguage;

    public void Start()
    {
        skillTextInDifferentsLanguage.texte = buttonSkill.GetComponentInChildren<Text>();
        skillTextInDifferentsLanguage.ChangeLanguage();
    }

    public void Update()
    {
        buttonSkill.onClick.AddListener(onButtonClick);
        //if (isActiveSkill)
        //{
        //    timer += Time.deltaTime;
        //    if (timer > cooldownSkill && isActive) buttonActiveSkill.interactable = true;
        //    else
        //    {
        //        buttonActiveSkill.interactable = false;
        //    }
        //}
        if (isActivable == false || PlayerPrefs.GetInt("Coins") < scoreToUnlock) buttonSkill.interactable = false;
        else buttonSkill.interactable = true;
    }

    public void setSkillActivable()
    {
        isActivable = true;
        ColorBlock cb = buttonSkill.colors;
        cb.disabledColor = new Color(1f,1f,1f, 0.5882353f);
        buttonSkill.colors = cb;
    }

    public void setSkillActive()
    {
        isActive = true;
        isActivable = false;
        ColorBlock cb = buttonSkill.colors;
        cb.disabledColor = new Color(1f, 0.8365737f, 0, 1f);
        buttonSkill.colors = cb;
    }

    public void onButtonClick()
    {
        SkillTree.Instance.setSkillActive(name);
    }
}

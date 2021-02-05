using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class SkillTree : Singleton<SkillTree>
{
    public List<Skill> Skills = new List<Skill>();
    Dictionary<string, Skill> SkillsDictionary = new Dictionary<string, Skill>();
    public GameObject buttonPrefab;

    void Start()
    {
        //Skills = SkillWindow.Instance.Skills;
        foreach (Skill sk in Skills)
        {
            GameObject skillButton = Instantiate(buttonPrefab, this.transform);
            sk.buttonSkill = skillButton.GetComponent<Button>();
            skillButton.name = sk.name;
            SkillsDictionary.Add(sk.name, sk);
            if (!PlayerPrefs.HasKey(sk.name)) PlayerPrefs.SetInt(sk.name, 0);
            if (PlayerPrefs.GetInt(sk.name) == 1) sk.setSkillActive();
            sk.Start();
        }
    }

    void Update()
    {
        foreach (Skill sk in Skills)
        {
            if (sk.precedentSkill != "")
            {
                Skill skill = null;
                SkillsDictionary.TryGetValue(sk.precedentSkill, out skill);
                if (skill.isActive == true && sk.isActive == false) sk.setSkillActivable();
            }
            sk.Update();
        }
    }

    public void setSkillActive(string skillName)
    {
        SkillsDictionary.TryGetValue(skillName, out Skill sk);
        if (PlayerPrefs.GetInt("Coins") >= sk.scoreToUnlock)
        {
            sk.setSkillActive();
            Coins.Instance.suppCoin(sk.scoreToUnlock);
            PlayerPrefs.SetInt(sk.name, 1);
            if (sk.name == "LessSpeed") PlayerStats.Instance.gameSpeed -= 0.5f;
            if (sk.name == "MoreScore") PlayerStats.Instance.scoreSpeed *= 2;
            if (sk.name == "LessDamage") PlayerStats.Instance.damage /= 2;
            if (sk.name == "MoreHeal") PlayerStats.Instance.bananaHeal *= 2;
        }
    }

    //Skill skActive;
    //public void activeActiveSkill(string skillName)
    //{
    //    SkillsDictionary.TryGetValue(skillName, out skActive);
    //    if (skActive.timer > skActive.cooldownSkill)
    //    {
    //        if (skActive.name == "Speedx2")
    //        {
    //            skActive.timer = 0;
    //            skActive.buttonActiveSkill.interactable = false;
    //            ColorBlock cb = skActive.buttonActiveSkill.colors;
    //            cb.disabledColor = new Color(1f, 0.8365737f, 0, 1f);
    //            skActive.buttonActiveSkill.colors = cb;
    //            Invoke("desactiveActiveSkill", skActive.durationSkill);
    //        }
    //    }
    //}

    //public void desactiveActiveSkill()
    //{
    //    if (skActive.name == "Speedx2")
    //        {
    //        ColorBlock cb = skActive.buttonActiveSkill.colors;
    //        cb.disabledColor = new Color(1f, 1f, 1f, 0.5882353f);
    //        skActive.buttonActiveSkill.colors = cb;
    //    }
    //}

}

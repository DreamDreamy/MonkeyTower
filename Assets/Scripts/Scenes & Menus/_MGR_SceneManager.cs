using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _MGR_SceneManager : MonoBehaviour
{
    public string[] arr_SceneName;      // paramètre public visible dans l'IDE unity (Editor)

    private static _MGR_SceneManager p_instance = null  ;              //Static instance of GameManager which allows it to be accessed by any other script.
    public static _MGR_SceneManager Instance { get { return p_instance; } }


    private  uint                       p_nbScenes;
    public   uint                       NbScenes { get { return p_nbScenes; } }    // modificateur privé : n'apparaît pas dans l'IDE

    private string[]                    p_arr_Scenes ;                                   // pour stocker les noms de scènes 
    private List<string>                p_list_Scenes = new List<string>();              // une autre facon de stocker les scènes du jeu
    private Dictionary<string, string>  p_dict_Scenes = new Dictionary<string, string>();// encore une autre facon de stocker les scènes du jeu (peu intéressant ici)
    
    public bool isStarted = false;

    //Awake is always called before any Start functions
    void Awake()
    {
        // ===>> SingletonMAnager

        //Check if instance already exists
        if (p_instance == null)
            //if not, set instance to this
            p_instance = this;
        //If instance already exists and it's not this:
        else if (p_instance != this)
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
        //Sets this to not be destroyed when reloading scene
        // DontDestroyOnLoad(gameObject);   par nécessaire ici car déja fait  par script __DDOL sur l'objet _EGO_app qui recueille tous les mgr


        // ====> vérifier si les scènes passées en paramètres existent 
        // ====> les stocke dans un dictionnaire
        p_arr_Scenes = new string[arr_SceneName.Length];
        p_nbScenes = 0;

        foreach (string _scene_name in arr_SceneName) {
            p_arr_Scenes[p_nbScenes]= _scene_name;                 // la scène sera accessible avec son indice 
            p_nbScenes++;


            p_list_Scenes.Add(_scene_name);              // la scène sera accessible avec son indice 
            p_dict_Scenes.Add(_scene_name, _scene_name); // la scène sera accessible avec son NOM
        }

    }

    //Launch one scene by name
    public void LoadScene(string __nom_scene)
    {
        // méthode non robuste : SceneManager.LoadScene(__scene_name);

        // méthode robuste : vérifier que le nom est correct    // le dictionnaire est ici approprié
        string _nom_scene_verifié;
        if (p_dict_Scenes.TryGetValue(__nom_scene, out _nom_scene_verifié))
        {
            if (_nom_scene_verifié == "Scene_Play")
            {
                isStarted = true;
            }
            SceneManager.LoadScene(_nom_scene_verifié);

        }
        else
            CommonDevTools.QUIT_APP("! Erreur de référence de scène !");
    }



    public void EndGame()
    {
        isStarted = false;
        LoadScene("Scene_End");
                

    }
    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _MGR_Son_Musique : MonoBehaviour
{
    private static _MGR_Son_Musique p_instance = null;
    public static _MGR_Son_Musique Instance { get { return p_instance; } }
    public GameObject AudioSourcePrefab;
    [System.Serializable]
    public class Son
    {
        public string nom;
        public AudioClip son;
    }
    // tous les sons à utiliser dans le jeu
    // seront initialisés à la création du manager, dans la scène _preload
    public Son[] sons;
    // tous les audio source prêts à jouer un son
    // plusieurs peuvent être nécessaires car plusieurs sons simultanés possible (e.g. musique+son FX)
    private List<AudioSource> p_listAudioSource = new List<AudioSource>();
    // un dictionnaire pour stocker et accéder aux son du jeu depuis leur nom
    private Dictionary<string, AudioClip> p_sons = new Dictionary<string, AudioClip>();
    // initialisation du manager
    void Awake()
    {
        if (p_instance == null)
            p_instance = this;
        else if (p_instance != this)
            Destroy(gameObject);
        foreach (var son in sons)
        {
            p_sons.Add(son.nom, son.son);
        }
    }
    // jouer un son du jeu
    // vérifier que le son existe
    // trouver un lecteur libre (audioSource) ou en ajouter un s'ils sont tous en lecture
    // jouer le son sur le lecteur libre (avec le délai fourni)
    public void PlaySound(string __nom, float __delay = 0)
    { // à compéter //
        if (!p_sons.ContainsKey(__nom))
        {
            CommonDevTools.ERROR("nom de son non défini : " + __nom, this.gameObject);
        }
        AudioClip clip;
        p_sons.TryGetValue(__nom, out clip);
        if (p_listAudioSource.Count == 0)
        {
            GameObject newaudio;
            newaudio = Instantiate(AudioSourcePrefab);
            p_listAudioSource.Add(newaudio.GetComponent<AudioSource>());
        }
        foreach (var audio in p_listAudioSource)
        {
            if ((!audio.isPlaying))
            {
                audio.clip = clip;
                audio.Play();
            }
        } 
    }
}

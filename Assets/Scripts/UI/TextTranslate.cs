using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTranslate : MonoBehaviour
{
    public Text[] textsToChange;
    void Start()
    {
        foreach (Text text in textsToChange)
        {
            if (PlayerPrefs.HasKey("language") && PlayerPrefs.GetString("language") == "FR")
            {
                switch (text.text)
                {
                    case "Press to play":
                        text.text = "Appuyez pour jouer";
                        break;
                    case "Back":
                        text.text = "Retour";
                        break;
                    case "Play":
                        text.text = "Jouer";
                        break;
                    case "Quit":
                        text.text = "Quitter";
                        break;
                    case "Skills":
                        text.text = "Competences";
                        break;
                    case "GAME OVER":
                        text.text = "PARTIE FINIE";
                        break;
                    case "Developed by Julie Ricou":
                        text.text = "Programmation par Julie Ricou";
                        break;
                    case "Active lever":
                        text.text = "Activer levier";
                        break;
                    case "Attack":
                        text.text = "Attaquer";
                        break;
                    case "Break box":
                        text.text = "Casser";
                        break;
                    case "Crouch":
                        text.text = "S'accroupir";
                        break;
                    case "Get banana":
                        text.text = "Banane";
                        break;
                    case "Get coin":
                        text.text = "Piece";
                        break;
                    case "Unlock skills":
                        text.text = "Debloquez des competences";
                        break;
                    case "Less Speed":
                        text.text = "- de Vitesse";
                        break;
                    case "Less Damage":
                        text.text = "- de Degats";
                        break;
                    case "More Heal":
                        text.text = "+ de Soin";
                        break;
                    case "More Score":
                        text.text = "+ de Score";
                        break;
                    case "Help the monkey go up the tower":
                        text.text = "Aidez le singe a aller tout en haut de la tour";
                        break;
                    case "Active the lever right before those spikes":
                        text.text = "Activez le levier juste avant les piques";
                        break;
                    case "Attack him":
                        text.text = "Attaquez le";
                        break;
                    case "Break that box":
                        text.text = "Cassez cette boite";
                        break;
                    case "Crouch down":
                        text.text = "Accroupissez-vous";
                        break;
                    case "Pick up that banana to heal yourself":
                        text.text = "Recuperez cette banane pour vous soigner";
                        break;
                    case "Pick up that coin to... earn a coin ?":
                        text.text = "Recuperez cette piece pour... gagner une piece ?";
                        break;
                    case "Press to continue":
                        text.text = "Appuyez pour continuer";
                        break;
                    case "Language":
                        text.text = "Langue";
                        break;
                    case "Multiplayer":
                        text.text = "Multijoueur";
                        break;
                    case "Enter a name":
                        text.text = "Entrer un nom";
                        break;
                    case "Your name...":
                        text.text = "Votre nom...";
                        break;
                    case "Enter a room name":
                        text.text = "Entrer un nom de salle";
                        break;
                    case "Room name...":
                        text.text = "Nom de salle...";
                        break;
                    case "Create":
                        text.text = "Creer";
                        break;
                    case "Research":
                        text.text = "Rechercher";
                        break;
                    case "Players":
                        text.text = "Joueurs";
                        break;
                    case "Room name :":
                        text.text = "Nom de salle :";
                        break;
                    default:
                        break;
                }
        }
        }
    }
}

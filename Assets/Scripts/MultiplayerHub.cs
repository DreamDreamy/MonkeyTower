using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiplayerHub : MonoBehaviourPunCallbacks
{
    public GameObject errorText;
    public Text playerNameText;
    public Text roomNameText;


    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
    }

    public void createRoom()
    {
        errorText.SetActive(false);
        string playerName = playerNameText.text;
        string roomName = roomNameText.text;
        if (playerName == "")
        {
            errorText.SetActive(true);
            if (PlayerPrefs.HasKey("language") && PlayerPrefs.GetString("language") == "FR") errorText.GetComponent<Text>().text = "Vous devez entrer un nom";
            else errorText.GetComponent<Text>().text = "You have to enter a username";
        }
        else
        {
            PhotonNetwork.NickName = playerName;

            if (roomName == "")
            {
                errorText.SetActive(true);
                if (PlayerPrefs.HasKey("language") && PlayerPrefs.GetString("language") == "FR") errorText.GetComponent<Text>().text = "Vous devez entrer un nom de salle";
                else errorText.GetComponent<Text>().text = "You have to enter a room name";
            }
            else
            {
                RoomOptions roomOptions = new RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = 2 };

                PhotonNetwork.CreateRoom(roomName, roomOptions, TypedLobby.Default);
            }
        }
    }

    public override void OnCreatedRoom()
    {
        _MGR_SceneManager.Instance.LoadScene("Scene_WaitingLobby");
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        switch (returnCode)
        {
            case 32766:
                errorText.SetActive(true);
                if (PlayerPrefs.HasKey("language") && PlayerPrefs.GetString("language") == "FR") errorText.GetComponent<Text>().text = "Une salle avec ce nom existe deja";
                else errorText.GetComponent<Text>().text = "A room with this name already exist";
                break;
            case 32765:
                errorText.SetActive(true);
                if (PlayerPrefs.HasKey("language") && PlayerPrefs.GetString("language") == "FR") errorText.GetComponent<Text>().text = "Cette salle est pleine";
                else errorText.GetComponent<Text>().text = "This room is full";
                break;
            case 32762:
                errorText.SetActive(true);
                if (PlayerPrefs.HasKey("language") && PlayerPrefs.GetString("language") == "FR") errorText.GetComponent<Text>().text = "Tous les serveurs sont occupes, veuillez reessayer plus tard";
                else errorText.GetComponent<Text>().text = "All servers are busy please try again later";
                break;
            case 32758:
                errorText.SetActive(true);
                if (PlayerPrefs.HasKey("language") && PlayerPrefs.GetString("language") == "FR") errorText.GetComponent<Text>().text = "Il n'y a pas de salle existante avec ce nom";
                else errorText.GetComponent<Text>().text = "There is no room existing with this name";
                break;
            default:
                break;
        }
    }

    public void researchRoom()
    {
        errorText.SetActive(false);
        string playerName = playerNameText.text;
        string roomName = roomNameText.text;
        if (playerName == "")
        {
            errorText.SetActive(true);
            if (PlayerPrefs.HasKey("language") && PlayerPrefs.GetString("language") == "FR") errorText.GetComponent<Text>().text = "Vous devez entrer un nom";
            else errorText.GetComponent<Text>().text = "You have to enter a username";
        }
        else
        {
            PhotonNetwork.NickName = playerName;

            if (roomName == "")
            {
                errorText.SetActive(true);
                if (PlayerPrefs.HasKey("language") && PlayerPrefs.GetString("language") == "FR") errorText.GetComponent<Text>().text = "Vous devez entrer un nom de salle";
                else errorText.GetComponent<Text>().text = "You have to enter a room name";
            }
            else
            {
                PhotonNetwork.JoinRoom(roomName);
            }
        }
    }

    public override void OnJoinedRoom()
    {
        _MGR_SceneManager.Instance.LoadScene("Scene_WaitingLobby");
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        switch (returnCode)
        {
            case 32766:
                errorText.SetActive(true);
                if (PlayerPrefs.HasKey("language") && PlayerPrefs.GetString("language") == "FR") errorText.GetComponent<Text>().text = "Une salle avec ce nom existe deja";
                else errorText.GetComponent<Text>().text = "A room with this name already exist";
                break;
            case 32765:
                errorText.SetActive(true);
                if (PlayerPrefs.HasKey("language") && PlayerPrefs.GetString("language") == "FR") errorText.GetComponent<Text>().text = "Cette salle est pleine";
                else errorText.GetComponent<Text>().text = "This room is full";
                break;
            case 32762:
                errorText.SetActive(true);
                if (PlayerPrefs.HasKey("language") && PlayerPrefs.GetString("language") == "FR") errorText.GetComponent<Text>().text = "Tous les serveurs sont occupes, veuillez reessayer plus tard";
                else errorText.GetComponent<Text>().text = "All servers are busy please try again later";
                break;
            case 32758:
                errorText.SetActive(true);
                if (PlayerPrefs.HasKey("language") && PlayerPrefs.GetString("language") == "FR") errorText.GetComponent<Text>().text = "Il n'y a pas de salle existante avec ce nom";
                else errorText.GetComponent<Text>().text = "There is no room existing with this name";
                break;
            default:
                break;
        }
    }
}

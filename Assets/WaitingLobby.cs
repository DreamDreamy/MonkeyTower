using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaitingLobby : MonoBehaviourPunCallbacks
{
    public Button startButton;
    public Text roomName;

    public void leaveRoom()
    {
        PhotonNetwork.LeaveRoom();
        updateUI();
    }

    void Start()
    {
        updateUI();
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        updateUI();
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        updateUI();
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        updateUI();
    }

    public void updateUI()
    {
        roomName.text = PhotonNetwork.CurrentRoom.Name;
        GameObject[] NamePlaceholders = GameObject.FindGameObjectsWithTag("PlayersName");
        int i = 0;
        foreach (var player in PhotonNetwork.PlayerList)
        {
            NamePlaceholders[i].GetComponent<Text>().text = player.NickName;
            i++;
        }
        if (PhotonNetwork.PlayerList.Length == 1) NamePlaceholders[i].GetComponent<Text>().text = "Player 2";

        if (PhotonNetwork.PlayerList.Length == 2) startButton.interactable = true;
        else startButton.interactable = false;
    }
}

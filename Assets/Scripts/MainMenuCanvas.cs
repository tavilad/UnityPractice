﻿using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuCanvas : MonoBehaviour
{
    [SerializeField] private Text _playerName;

    public void OnClickSinglePlayer()
    {
        GameManager.Instance.GameMode = GameMode.SinglePlayer;
        GameManager.Instance.PlayerName = _playerName.text;
    }


    public void OnClickMultiPlayer()
    {
        GameManager.Instance.GameMode = GameMode.Multiplayer;
        MainCanvasManager.Instance.LobbyCanvas.transform.SetAsLastSibling();
        GameManager.Instance.PlayerName = _playerName.text;
        PhotonNetwork.playerName = _playerName.text;
    }

    public void OnClickTimeTrial()
    {
        GameManager.Instance.GameMode = GameMode.TimeTrial;
        SceneManager.LoadScene("test");
    }
}
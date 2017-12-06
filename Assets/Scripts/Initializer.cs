using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : Photon.PunBehaviour
{
    [SerializeField]
    GameObject prefab;

	[SerializeField]
	GameManager manager;

	void Start ()
    {
		PhotonNetwork.ConnectUsingSettings(0 + "." + SceneManagerHelper.ActiveSceneBuildIndex);
		PhotonNetwork.EnableLobbyStatistics = true;
    }
 

	public virtual void OnConnectedToMaster()
	{
		PhotonNetwork.JoinLobby();
	}

	public override void OnJoinedLobby()
	{
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsVisible = false;
		roomOptions.MaxPlayers = 5;
		PhotonNetwork.JoinOrCreateRoom("LobbyRoom", roomOptions, TypedLobby.Default);

	}

	public void OnJoinedRoom()
	{
		PhotonNetwork.Instantiate (prefab.name, manager.GetStartPoint (PhotonNetwork.countOfPlayers), Quaternion.identity, 0);
	}

}

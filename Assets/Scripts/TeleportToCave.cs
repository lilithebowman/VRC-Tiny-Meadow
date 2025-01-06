
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class TeleportToCave : UdonSharpBehaviour {
	public Transform teleportTo;

	public void OnPlayerTriggerEnter () {
		VRCPlayerApi playerApi;
		playerApi = Networking.LocalPlayer;
		playerApi.TeleportTo(teleportTo.position, Quaternion.identity * teleportTo.rotation);
	}

}
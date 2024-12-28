
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class LilChestOpen : UdonSharpBehaviour {
	public Animator animator;
	public string openingAnimation = "Chest_01_Opening";
	public string closingAnimation = "Chest_01_Closing";
	public bool isOpen;

	void Start () {
		if (animator == null) {
			Debug.LogError("No animator detected! Set up the proper animator!");
		}
		if (openingAnimation == null || closingAnimation == null) {
			Debug.LogError("No animator name is set! We can't start an animation we don't know the name of.");
		}
	}

	public override void Interact () {
		if (animator != null && openingAnimation != null && closingAnimation != null) {
			if (!isOpen) {
				animator.Play(openingAnimation);
				isOpen = true;
			} else {
				animator.Play(closingAnimation);
				isOpen = false;
			}
		}
	}
}

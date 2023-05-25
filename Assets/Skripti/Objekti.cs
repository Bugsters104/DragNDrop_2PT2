using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;

	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atraPKoord;
	[HideInInspector]
	public Vector2 bussKoord;

	public Canvas kanva;

	public AudioSource audioAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;


	// Use this for initialization
	void Start () {
		atkrMKoord =
		atkritumuMasina.GetComponent<RectTransform>().localPosition;

       atraPKoord =
       atraPalidziba.GetComponent<RectTransform>().localPosition;

		bussKoord =
        autobuss.GetComponent<RectTransform>().localPosition;
    }
}

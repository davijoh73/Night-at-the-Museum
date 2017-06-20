using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhibitAction : MonoBehaviour {

    public GameObject photo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void popupPhoto() {
        photo.SetActive(true);
    }

    public void closePopup()
    {
        photo.SetActive(false);
    }
}

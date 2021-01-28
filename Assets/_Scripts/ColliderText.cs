using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderText : MonoBehaviour
{
	public string popUp;
	public string title;
	
	private void OnTriggerEnter(Collider other)
	{
		Debug.Log('a');
		PopUpSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUpSystem>();
		pop.PopUp(popUp,title);
	}
	private void OnTriggerExit(Collider other)
	{
		PopUpSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUpSystem>();
		pop.popUpBox.SetActive(false);
	}
}

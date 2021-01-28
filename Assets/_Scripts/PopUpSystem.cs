using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUpSystem : MonoBehaviour
{

	public GameObject popUpBox;
	public Animator animator;
	public TMP_Text popUpText;
	public TMP_Text textTitle;
	
	public void PopUp(string text, string text2 )
	{
		popUpBox.SetActive(true);
		popUpText.text = text;
		textTitle.text = text2;
		animator.SetTrigger("pop");

	}


}

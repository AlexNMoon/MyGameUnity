using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextChange : MonoBehaviour {
	
	public Text showText;
	
	void OnTriggerEnter(Collider other)
	{
		setText("Press E");
	}
	
	void OnTriggerExit(Collider other)
	{
		setText("");
	}
	
	void setText(string a)
	{
		showText.text = a;
	}

}

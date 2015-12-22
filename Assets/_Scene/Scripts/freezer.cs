using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class freezer : MonoBehaviour {
public Text showText;
public Text count;
public GameObject gameObject;
private int countInt;
	
	void OnTriggerEnter(Collider other)
	{
		setText("Press E");
	}
	
	void OnTriggerStay(Collider other)
	{
		if (Input.GetKeyUp(KeyCode.E)) {
			Destroy(gameObject);
			setText("");
			countInt = System.Int32.Parse(count.text);
			countInt++;
			if (countInt >= 4) {
				count.text = "All!";
			} else {
				count.text = countInt.ToString(); 
			}
		}
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

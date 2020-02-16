using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyControl : MonoBehaviour
{
	//Give player object the "Player" tag, give keys the "Key" custom tag, give doors the "Door" custom tag
	public int keyNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
public void AddKey(GameObject passed)
    {
		
		keyNumber += 1;
		Destroy(passed);
			
    }
public void OpenDoor(GameObject passed)
    {
		keyNumber -= 1;
		Destroy(passed);
			
    }
public string GetKeyUI()
    {
	return "Keys: " + keyNumber;
    }
public int GetKeyNumber()
    {
	return keyNumber;
    }

}

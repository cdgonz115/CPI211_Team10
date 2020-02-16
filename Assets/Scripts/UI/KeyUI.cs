using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyUI : MonoBehaviour
{
    [SerializeField] public Text keyText;
    string key;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
private void FixedUpdate()
    {
        key = GetComponent<PlayerKeyControl>().GetKeyUI();
        keyText.text = key;
    }
}

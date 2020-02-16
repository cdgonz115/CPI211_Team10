using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlyAway : MonoBehaviour
{
    [SerializeField] public Text gameStatusText;
    private void OnEnable() => StartCoroutine("End");

    IEnumerator End()
    {
        for (int x = 0; x < 150; x++)
        {
            transform.position += new Vector3(0, .1f, 0);
            yield return new WaitForFixedUpdate();
        }
        for (int x = 0; x < 80; x++)
        {
            transform.Rotate(new Vector3(0, .8f, -.2f));
            yield return new WaitForFixedUpdate();
        }
        GetComponent<Rigidbody>().velocity = -transform.forward * 50;
        for (int x = 0; x < 500; x++)
        {
            if (x == 250) gameStatusText.enabled = true;
            yield return new WaitForFixedUpdate();
        }
        print("sup");
        Application.Quit();
    }
}

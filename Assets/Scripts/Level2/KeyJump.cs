using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KeyJump : MonoBehaviour
{
    private bool goingDown;
    public AudioSource ads;
    public AudioClip clip;
    private void FixedUpdate()
    {
        if (transform.position.y > 16.2f) goingDown = true;
        if (transform.position.y < 14.8) goingDown = false;
        transform.position += new Vector3(0, (goingDown)?-.05f:0.05f, 0);
        if (!ads.isPlaying) ads.PlayOneShot(clip);
    }

}

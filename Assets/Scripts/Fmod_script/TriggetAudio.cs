using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggetAudio : MonoBehaviour
{
    public void botonSound()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX_Menu");
    }
}

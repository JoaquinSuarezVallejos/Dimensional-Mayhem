using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundEffects : MonoBehaviour
{
    public AudioSource btnClick;

    public void ButtonClick() { btnClick.Play(); }
}

using EmeraldAI.Example;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneFader : MonoBehaviour
{
    public Image Fader;
    bool HasOcurred = false;
    EmeraldAIPlayerHealth Health;
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("PlayerController");
        Health = Player.GetComponent<EmeraldAIPlayerHealth>();
        Fader.canvasRenderer.SetAlpha(0);
        Fader.CrossFadeAlpha(1.0f, 4.0f, false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!HasOcurred && Health.isDead)
        {
            FadeOut();
        }
    }

    public void FadeOut()
    {
        Debug.Log("Fading");
        //Cuando muere, se ejecuta. Hace que en 5 segundos fadee a negro todo. Luego veo como pasarlo de escena.
        Fader.canvasRenderer.SetAlpha(0);
        Fader.CrossFadeAlpha(1.0f, 4.0f, false);
        HasOcurred = true;
    }
}

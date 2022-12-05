using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchHandCanvas : MonoBehaviour
{
    public GameObject healthCanvas, missionCanvas;

    void Start()
    {
        StartCoroutine("switchToHealthCanvas");
    }

    IEnumerator switchToHealthCanvas()
    {
        healthCanvas.SetActive(true);
        missionCanvas.SetActive(false);
        yield return new WaitForSeconds(3);
        StartCoroutine("switchToMissionCanvas");
    }

    IEnumerator switchToMissionCanvas()
    {
        healthCanvas.SetActive(false);
        missionCanvas.SetActive(true);
        yield return new WaitForSeconds(3);
        StartCoroutine("switchToHealthCanvas");
    }
}

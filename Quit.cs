using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour
{
    public void DoQuit()
    {
        Debug.Log("Has quit game");
            Application.Quit();

    }
}
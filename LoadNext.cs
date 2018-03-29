using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;


public class LoadNext : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene(1);
	}
}
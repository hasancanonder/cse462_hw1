using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
	public void GoToSceneStationary() {
		SceneManager.LoadScene("Stationary");
	}
	public void GoToSceneAnimated() {
		SceneManager.LoadScene("Animated");
	}
	public void GoToSceneMove() {
		SceneManager.LoadScene("Move");
	}
	public void GoToScenePicture() {
		SceneManager.LoadScene("Picture");
	}
	public void GoToSceneText() {
		SceneManager.LoadScene("Text");
	}
	public void GoToSceneVideo() {
		SceneManager.LoadScene("Video");
	}
	public void GoToSceneColorObj() {
		SceneManager.LoadScene("ColorObj");
	}

}

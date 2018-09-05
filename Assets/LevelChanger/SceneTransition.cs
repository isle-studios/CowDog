using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {

    public Animator animator;

    private string switchScene;

    private bool sChange = false;
    private float timer = 1f;

    public void GoToScene(string sceneName)
    {
        switchScene = sceneName;
        sChange = true;
        animator.SetTrigger("FadeOut");
    }

    public void QuitRequest()
    {
        Application.Quit();
    }

    private void FinishedAnim()
    {
        SceneManager.LoadScene(switchScene);
    }

	void Update () {
		if (sChange)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0)
        {
            FinishedAnim();
        }
	}
}

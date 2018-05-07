using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadingScript : MonoBehaviour {

    [SerializeField]
    Image img;
    [SerializeField]
    Animator anim;

    public void Fade()
    {
        StartCoroutine(Fading());
    }

	IEnumerator Fading()
    {
        anim.SetBool("isFadingOut", true);
        yield return new WaitUntil(() => img.color.a == 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

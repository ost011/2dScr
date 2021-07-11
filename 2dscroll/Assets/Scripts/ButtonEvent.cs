using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{
    AudioSource buttonClickSound;
    public AudioClip audioClip;
    public string sceneName;

    private void Start()
    {
        buttonClickSound = GetComponent<AudioSource>();
    }
    //public void SceneLoader(string sceneName)
    public void SceneLoader()
    {
        StartCoroutine("LoadAfterSound");
        //SceneManager.LoadScene(sceneName);
    }
    private IEnumerator LoadAfterSound()
    {
        Debug.Log("muyaho");
        if (buttonClickSound != null)
        {
            buttonClickSound.PlayOneShot(audioClip);
        }
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(sceneName);
    }
}
/*
 * File : ButtonEvent.cs
 * Desc : Button UI ������Ʈ�� �����ؼ� ���
 *      : ��ư�� ������ �� ȣ��Ǵ� �Լ����� �ۼ�
 *      
 * Functions : SceneLoader() - �� ��ȯ
 */
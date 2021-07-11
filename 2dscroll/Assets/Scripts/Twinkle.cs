using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twinkle : MonoBehaviour
{
    private float fadeTime = 0.1f;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine("TwinkleLoop");
    }
    private IEnumerator TwinkleLoop()
    {
        while (true)
        {
            // Alpha ���� 1���� 0����, Fade Out
            yield return StartCoroutine(FadeEffect(1, 0));
            // Alpha ���� 0���� 1�� : Fade In
            yield return StartCoroutine(FadeEffect(0, 1));
        }
    }

    private IEnumerator FadeEffect(float start, float end)
    {
        float currentTime = 0f;
        float percent = 0f;

        while(percent < 1)
        {
            //fadeTime �ð����� while() �ݺ��� ����
            currentTime += Time.deltaTime;
            percent = currentTime / fadeTime;
            //����Ƽ�� Ŭ������ �����Ǿ� �ִ� spriteRenderer.color, transform.position�� ������Ƽ��
            // spriteRenderer.color.a = 1.0f�� ���� ������ �Ұ����ϴ�
            //spriteRenderer.color = new Color(spriteRenderer.color.r, .., .., 1.0f)�� ���� �����ؾ� �Ѵ�
            Color color = spriteRenderer.color;
            color.a = Mathf.Lerp(start, end, percent); // start�� end ������ �� �� percent ��ġ�� �ִ� ���� ��ȯ, ex) start=0, end=100, percent=0.3�̸� 30�� ��ȯ
            spriteRenderer.color = color;

            yield return null;
        }
    }
}

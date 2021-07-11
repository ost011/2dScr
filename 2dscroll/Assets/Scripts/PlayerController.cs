using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private string nextSceneName;

    [SerializeField]
    private StageData stageData;
    
    [SerializeField]
    private KeyCode keyCodeAttack = KeyCode.Space;
    private Weapon weapon;
    private Movement2D movement2D;

    private int score;
    public int Score
    {
        //Score ���� ������ ���� �ʵ���
        set => score = Mathf.Max(0, value);
        get => score;
    }

    private void Awake()
    {
        movement2D = GetComponent<Movement2D>();
        weapon = GetComponent<Weapon>();
    }
    private void Update()
    {
        //���� Ű�� ���� �̵� ���� ����
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        movement2D.MoveTo(new Vector3(x, y, 0));

        //���� Ű�� Down/Up���� ���� ����/����
        if (Input.GetKeyDown(keyCodeAttack))
        {
            weapon.StartFiring();
        }
        else if (Input.GetKeyUp(keyCodeAttack))
        {
            weapon.StopFiring();
        }
    }
    private void LateUpdate()
    {
        //�÷��̾� ĳ���Ͱ� ȭ�� ���� �ٱ����� ������ ���ϵ��� ��
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageData.LimitMin.x, stageData.LimitMax.x),
            Mathf.Clamp(transform.position.y, stageData.LimitMin.y, stageData.LimitMax.y));
    }
    public void OnDie()
    {
        //����̽��� ȹ���� ���� score ����
        PlayerPrefs.SetInt("Score", score);
        //�÷��̾� ��� �� nextSceneName ������ �̵�
        SceneManager.LoadScene(nextSceneName);
    }
    /*
     *File : PlayerController.cs
     *Desc : �÷��̾� ĳ���Ϳ� �����ؼ� ���
     * Fuction
     */
}

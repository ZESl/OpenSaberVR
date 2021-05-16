using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    //private int score;
    //public Text scoreBorad;

    //private void Awake()
    //{
    //    score = 0;
    //    scoreBorad.text = score.ToString();
    //}

    //public void addScore()
    //{
    //    // 得分++
    //    score++;
    //    Debug.Log("score:" + score.ToString());
    //    scoreBorad.text = score.ToString();
    //}
    public static Text txt;				//定义静态变量名以用于其他脚本内的引用**
	public static float x = 0;
    void Start()
    {
        txt = GameObject.Find("Canvas/Text").GetComponent<Text>();
    }

    public static void emptyScore()
    {
        x = 0;
    }
}

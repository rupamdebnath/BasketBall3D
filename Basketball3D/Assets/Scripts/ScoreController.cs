using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    private static ScoreController instance;
    public static ScoreController Instance { get { return instance; } }
    private TextMeshProUGUI text;
    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        
    }

    public void SetScoreText(int _score)
    {
        text.SetText("Score:" + _score);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;


    public int currentScore;
    public int scorePerNote = 1;

    public int currentMultiplier;
    public int multiplerTracker;
    public int[] multiplierThresholds;

    [SerializeField] TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        scoreText.text = "0";
        currentMultiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NoteHit() {
        Debug.Log("Hit On Time");

        currentScore += scorePerNote * currentMultiplier;
        scoreText.text = currentScore.ToString();
        
    }


    public void NoteMissed() {
        Debug.Log("Missed Note");
    }
}

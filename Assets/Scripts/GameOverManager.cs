using UnityEngine;
using System.IO;
using TMPro;

public class GameOverManager : MonoBehaviour {

    public TextMeshProUGUI EndScore;
    public TextMeshProUGUI HighScore;
    private int score;
    private string fpath = @"C:\Files\Project\Flappy Bird\Assets\Scripts\Score.txt";
    private string hspath = @"C:\Files\Project\Flappy Bird\Assets\Scripts\HighScore.txt";
    public void Start() {
        score = int.Parse(File.ReadAllText(fpath));
        EndScore.text = "Score : " + score.ToString();
        score = int.Parse(File.ReadAllText(hspath));
        HighScore.text = "High Score : " + score.ToString();
    }
}

using UnityEngine;
using System.IO;
using TMPro;

public class Score_Manager : MonoBehaviour
{
    public Death death;
    public TextMeshProUGUI ScoreDisplay;
    public int score = 0;
    private string fpath = @"C:\Files\Project\Flappy Bird\Assets\Scripts\Score.txt";
    private string hspath = @"C:\Files\Project\Flappy Bird\Assets\Scripts\HighScore.txt";
    void Update() {
        ScoreDisplay.text = score.ToString();

        if ( death.PlayerDeath ) {
            File.WriteAllText(fpath, score.ToString());
            if ( score > int.Parse(File.ReadAllText(hspath)) ) {
                File.WriteAllText(hspath, score.ToString());
            }
        }
    }
}

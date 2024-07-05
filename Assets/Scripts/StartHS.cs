using UnityEngine;
using System.IO;
using TMPro;

public class StartHS : MonoBehaviour
{
    public TextMeshProUGUI HS;
    private string hspath = @"C:\Files\Project\Flappy Bird\Assets\Scripts\HighScore.txt";
    private string content;
    void Start()
    {
        content = File.ReadAllText(hspath);
        if (int.Parse(content) != 0) {
            HS.text = "High Score : " + content;
        }
        else {
            HS.text = "High Score : -";
        }
    }
}

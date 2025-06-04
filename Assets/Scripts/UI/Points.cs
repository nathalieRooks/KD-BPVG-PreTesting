using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static Points instance;
    public TextMeshProUGUI text;
    public int puntentelling;
    public int maxPoints = 5;

    public Button NextLevelButton;

    public bool LevelDone = false;

    private void Start()
    {
        // Singleton pattern. Checkt of er maar 1
        if (instance == null)
        {
            instance = this;
        }
    }

    //  Veranderd de string
    public void punten(int fishValue)
    {
        puntentelling += fishValue;
        text.text = "X" + puntentelling.ToString();

        if(puntentelling >= maxPoints)
        {
            LevelDone = true;
            NextLevelButton.gameObject.SetActive(true);
        }
    }

    // Geeft punten telling terug
    public int GetPunten()
    {
        return puntentelling;
    }
}

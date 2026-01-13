using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    private int seedsLeft;
    private int seedsPlanted;

    private void Start()
    {
        seedsLeft = 5;
        seedsPlanted = 0;
    }

    private void Update()
    {
        _plantedText.text = seedsPlanted.ToString();
        _remainingText.text = seedsLeft.ToString();
        if (Input.GetKeyDown(KeyCode.Space) && seedsLeft > 0)
        {
            seedsLeft--;
            seedsPlanted++;
        }
    }
    
}
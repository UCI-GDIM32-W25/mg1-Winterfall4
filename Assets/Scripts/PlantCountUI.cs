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
            Debug.Log("Space Bar 2");
        }
    }
    

    /* public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        seedsLeft = 5;
        seedsPlanted = 0;
        if (Input.GetKey(KeyCode.Space))
        {
            seedsLeft--;
            seedsPlanted++;
            _plantedText.text = seedsLeft.ToString();
            Debug.Log("Space Bar 2");
        }
   
    }*/

}
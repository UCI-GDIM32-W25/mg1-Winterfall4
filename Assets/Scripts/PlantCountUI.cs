using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        seedsLeft = 5;
        seedsPlanted = 5;
        if (Input.GetKey(KeyCode.Space))
        {
            _plantedText.text = seedsLeft.ToString();
            Debug.Log("Space Bar 2");
        }
   
    }
    private void Update()
    {
    
    }

}
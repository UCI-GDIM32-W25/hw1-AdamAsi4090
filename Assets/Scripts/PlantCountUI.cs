using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        //Puts the amount of seeds planted into the text.
        _plantedText.text = "" + seedsPlanted;
        //Puts the amount of seeds left into the text.
        _remainingText.text = "" + seedsLeft;
    }
}
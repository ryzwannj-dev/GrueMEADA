using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Assurez-vous d'importer le namespace pour l'UI
using TMPro; 

public class Declencheur : MonoBehaviour
{
    public int cubeCount = 0;
    public TextMeshProUGUI cubeCountText; // Référence vers le composant Text de l'UI

    void Start()
    {
        // Initialiser l'affichage du texte avec le nombre initial de cubes
        UpdateCubeCountText();
    }

    void Update()
    {
        // Si des mises à jour en temps réel sont nécessaires
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            cubeCount++;
            UpdateCubeCountText();
            Debug.Log("Cube entré. Nombre de cubes: " + cubeCount);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            cubeCount--;
            UpdateCubeCountText();
            Debug.Log("Cube sorti. Nombre de cargaison : " + cubeCount);
        }
    }

    // Méthode pour mettre à jour le texte de l'UI
    void UpdateCubeCountText()
    {
        if (cubeCountText != null)
        {
            cubeCountText.text = "Cargaison(s) de poudre livrée(s) : " + cubeCount;
        }
    }
}

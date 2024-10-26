using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// on définit ici les états de mouvement utilisés dans Translation Commande
// Fixe ne fait rien, Positif fait "avancer", Negatif fait "reculer"
public enum EtatTranslation { Fixe = 0, Positif = 1, Negatif = -1 };

public class TranslationControleur : MonoBehaviour
{
    // l'articulation est initialisée en mode Fixe pour être "au repos"
    public EtatTranslation moveState = EtatTranslation.Fixe;
    // vitesse de translation par défaut, public signifie qu'elle peut être modifiée dans l'inspecteur
    public float speed = 1.0f;

    private void FixedUpdate() // FixedUpdate est comme Update, mais synchronisé avec le moteur physique d'Unity
    {
        if (moveState != EtatTranslation.Fixe)
        {
            ArticulationBody articulation = GetComponent<ArticulationBody>();

            // Vérifie si l'articulation a une position valide (au moins un degré de liberté)
            if (articulation.jointPosition.dofCount > 0)
            {
                // obtient la position du joint sur l'axe X ([0])
                float xDrivePostion = articulation.jointPosition[0];

                // change la position sur l'axe X
                float targetPosition = xDrivePostion + -(float)moveState * Time.fixedDeltaTime * speed;

                // donne l'ordre au joint de rejoindre la position définie par targetPosition
                var drive = articulation.xDrive;
                drive.target = targetPosition;
                articulation.xDrive = drive;
            }
            else
            {
                // Si l'articulation n'a pas de position, log une erreur
                Debug.LogError("L'articulation ne possède pas de position sur l'axe X.");
            }
        }
    }
}

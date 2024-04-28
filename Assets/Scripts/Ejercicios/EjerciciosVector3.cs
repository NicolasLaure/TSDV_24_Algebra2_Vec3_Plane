using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActividadEjercicios
{
    public class EjerciciosVector3 : MonoBehaviour
    {
        #region UserInputs
        [SerializeField] Ejercicios selectedExercise;
        [SerializeField] Color VectorColor = Color.red;
        [SerializeField] CustomMath.Vec3 A;
        [SerializeField] CustomMath.Vec3 B;
        #endregion
    }
}
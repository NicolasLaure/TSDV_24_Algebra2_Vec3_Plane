using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomMath;

namespace ActividadEjercicios
{
    public class EjerciciosVector3 : MonoBehaviour
    {
        #region Variables

        #region UserInputs
        [SerializeField] private Ejercicios selectedExercise;
        [SerializeField] private Color VectorColor = Color.red;
        [SerializeField] private Vec3 A;
        [SerializeField] private Vec3 B;
        #endregion

        private Vec3 resultVector;

        #endregion

    }
}
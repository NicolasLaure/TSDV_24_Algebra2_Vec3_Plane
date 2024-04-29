using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomMath;
using TMPro;

namespace ActividadEjercicios
{
    public class EjerciciosVector3 : MonoBehaviour
    {
        #region Variables

        #region UserInputs
        [SerializeField] private Ejercicios selectedExercise = Ejercicios.Uno;
        [SerializeField] private Color VectorColor = Color.red;
        [SerializeField] private Vec3 A;
        [SerializeField] private Vec3 B;
        [SerializeField] private GameObject linePrefab;
        #endregion

        private Ejercicios prevFrameSelectedExercise = Ejercicios.Uno;
        private Vec3 resultVector = new Vec3(0,0,0);
        private LineRenderer vectorA_LR;
        private LineRenderer vectorB_LR;
        private LineRenderer vectorResult_LR;
        #endregion
        private void Start()
        {
            InitializeLine(out vectorA_LR, "Vector A", Color.white);
            InitializeLine(out vectorB_LR, "Vector B", Color.black);
            InitializeLine(out vectorResult_LR, "Vector Result", VectorColor);

            SetVector(A, ref vectorA_LR);
            SetVector(B, ref vectorB_LR);
            ResolveExercise();
            prevFrameSelectedExercise = selectedExercise;
        }

        private void Update()
        {
            if (prevFrameSelectedExercise != selectedExercise)
            {
                ResolveExercise();
                prevFrameSelectedExercise = selectedExercise;
            }
        }

        private void ResolveExercise()
        {
            switch (selectedExercise)
            {
                case Ejercicios.Uno:
                    resultVector = A + B;
                    break;
                case Ejercicios.Dos:
                    resultVector = B - A;
                    break;
                case Ejercicios.Tres:
                    break;
                case Ejercicios.Cuatro:
                    break;
                case Ejercicios.Cinco:
                    break;
                case Ejercicios.Seis:
                    break;
                case Ejercicios.Siete:

                    break;
                case Ejercicios.Ocho:
                    break;
                case Ejercicios.Nueve:
                    break;
                case Ejercicios.Diez:
                    //UnclampedLerp
                    break;
                default:
                    break;
            }
            SetVector(resultVector, ref vectorResult_LR);
        }

        #region LineRendering
        private void InitializeLine(out LineRenderer line, string name, Color color)
        {
            GameObject spawnedLine = Instantiate(linePrefab, this.transform);

            spawnedLine.name = name;
            line = spawnedLine.GetComponent<LineRenderer>();
            line.startColor = color;
            line.endColor = color;
        }

        private void SetVector(Vec3 vector, ref LineRenderer line)
        {
            line.SetPosition(1, vector);
            string vectorText = @$"{line.gameObject.name}:
            X: {vector.x}
            Y: {vector.y}
            Z: {vector.z}";
            Transform textGO = line.gameObject.transform.GetChild(0);
            textGO.position = vector;
            TextMeshPro tmpText = textGO.GetComponent<TextMeshPro>();
            tmpText.text = vectorText;
            tmpText.color = line.startColor;
        }
        #endregion
    }
}
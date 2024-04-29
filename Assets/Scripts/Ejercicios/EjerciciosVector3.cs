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
        [SerializeField] private GameObject linePrefab;
        #endregion

        private Vec3 resultVector;
        private LineRenderer vectorA_LR;
        private LineRenderer vectorB_LR;
        private LineRenderer vectorResult_LR;
        #endregion
        private void Start()
        {
            InitializeLine(out vectorA_LR, "Vector A", Color.white);
            InitializeLine(out vectorB_LR, "Vector B", Color.black);
            InitializeLine(out vectorResult_LR, "Vector Result", VectorColor);

            vectorA_LR.SetPosition(1, A);
            vectorB_LR.SetPosition(1, B);
        }

        private void Update()
        {

        }

        private void InitializeLine(out LineRenderer line, string name, Color color)
        {
            GameObject spawnedLine = Instantiate(linePrefab, this.transform);
            spawnedLine.name = name;
            line = spawnedLine.GetComponent<LineRenderer>();
            line.startColor = color;
            line.endColor = color;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace popup
{
    public class theMainPage : MonoBehaviour
    {
        float speed = 100f;
        float currentRotation1 = 0f;
        float maxRotation1 = 180f;
        float minRotation1 = 0f;
        public GameObject gameObject1;
        public GameObject gameObject2;
        public GameObject sndpage;
        public GameObject alight;
        float lightSpeed = 70f;
        Vector3 maxScale = new Vector3(1.5f, 1.5f, 1.5f);
        Vector3 minScale = new Vector3(0.001f, 0.5f, 0.5f);
        float scaleSpeed = .5f;
        private float currentRotation2 = 0f;
        float maxRotation2 = 180f;
        float minRotation2 = 0f;


        void Update()
        {
            if (Input.GetKey(KeyCode.RightArrow) && currentRotation1 < maxRotation1)
            {
                float rotationStep1 = speed * Time.deltaTime;

                if (currentRotation1 + rotationStep1 > maxRotation1)
                {
                    rotationStep1 = maxRotation1 - currentRotation1;
                }

                transform.Rotate(Vector3.right, rotationStep1);
                currentRotation1 += rotationStep1;
                gameObject1.transform.Rotate(Vector3.back, rotationStep1 / 2);
                gameObject1.transform.Translate(new Vector3(0, 5 * Time.deltaTime, 6 * Time.deltaTime));
                gameObject1.transform.localScale = Vector3.Min(
                   gameObject1.transform.localScale + Vector3.one * scaleSpeed * Time.deltaTime,
                   maxScale
               );
                alight.transform.Rotate(Vector3.right, lightSpeed * Time.deltaTime);

            }
            if (Input.GetKey(KeyCode.LeftArrow) && currentRotation1 > minRotation1)
            {
                float rotationStep1 = speed * Time.deltaTime;

                if (currentRotation1 - rotationStep1 < minRotation1)
                {
                    rotationStep1 = currentRotation1 - minRotation1;
                }

                transform.Rotate(Vector3.left, rotationStep1);
                currentRotation1 -= rotationStep1;
                gameObject1.transform.Rotate(Vector3.forward, rotationStep1 / 2);
                gameObject1.transform.Translate(new Vector3(0, -5 * Time.deltaTime, -6 * Time.deltaTime));
                gameObject1.transform.localScale = Vector3.Max(
                    gameObject1.transform.localScale - Vector3.one * scaleSpeed * Time.deltaTime,
                    minScale
                );
                alight.transform.Rotate(Vector3.left, lightSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.UpArrow) && currentRotation2 < maxRotation2)
            {
                float rotationStep = speed * Time.deltaTime;

                if (currentRotation2 + rotationStep > maxRotation2)
                {
                    rotationStep = maxRotation2 - currentRotation2;
                }

                sndpage.transform.Rotate(Vector3.right, rotationStep);
                currentRotation2 += rotationStep;
                gameObject1.transform.Rotate(Vector3.forward, rotationStep / 2);
                gameObject1.transform.Translate(new Vector3(0, -5 * Time.deltaTime, 6 * Time.deltaTime));
                gameObject1.transform.localScale = Vector3.Max(
                    gameObject1.transform.localScale - Vector3.one * scaleSpeed * Time.deltaTime,
                    minScale
                );
                alight.transform.Rotate(Vector3.left, lightSpeed * Time.deltaTime);

                gameObject2.transform.Rotate(Vector3.back, rotationStep / 2);
                gameObject2.transform.Translate(new Vector3(0, 5 * Time.deltaTime, 6 * Time.deltaTime));
                gameObject2.transform.localScale = Vector3.Min(
                   gameObject2.transform.localScale + Vector3.one * scaleSpeed * Time.deltaTime,
                   maxScale
               );

            }
            if (Input.GetKey(KeyCode.DownArrow) && currentRotation2 > minRotation2)
            {
                float rotationStep = speed * Time.deltaTime;

                if (currentRotation2 - rotationStep < minRotation2)
                {
                    rotationStep = currentRotation2 - minRotation2;
                }

                sndpage.transform.Rotate(Vector3.left, rotationStep);
                currentRotation2 -= rotationStep;
                gameObject1.transform.Rotate(Vector3.back, rotationStep / 2);
                gameObject1.transform.Translate(new Vector3(0, 5 * Time.deltaTime, -6 * Time.deltaTime));
                gameObject1.transform.localScale = Vector3.Min(
                     gameObject1.transform.localScale + Vector3.one * scaleSpeed * Time.deltaTime,
                     maxScale
                );
                alight.transform.Rotate(Vector3.right, lightSpeed * Time.deltaTime);

                gameObject2.transform.Rotate(Vector3.forward, rotationStep / 2);
                gameObject2.transform.Translate(new Vector3(0, -5 * Time.deltaTime, -6 * Time.deltaTime));
                gameObject2.transform.localScale = Vector3.Max(
                   gameObject2.transform.localScale - Vector3.one * scaleSpeed * Time.deltaTime,
                   minScale
               );

            }

        }
    }
}
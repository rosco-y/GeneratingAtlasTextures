using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BatchRename : ScriptableWizard
{
        // wizard-exposed fields:
        public string BaseName = "MyObject_";
        public int StartNumber = 0;
        public int Increment = 1;
        //Random _rnd;        

        [MenuItem("Edit/Chapter 4/Batch Rename...")]
        static void CreateWizard()
        {
                DisplayWizard("Batch Rename", typeof(BatchRename), "Rename");
        }

        // called when the window first appears
        private void OnEnable()
        {
                UpdateSelectionHelper();
        }

        private void OnSelectionChange() => UpdateSelectionHelper();

        private void UpdateSelectionHelper()
        {
                helpString = "";
                if (Selection.objects != null)
                        helpString = "Number of objects selected:" + Selection.objects.Length;
        }

        private void OnWizardCreate()
        {
                if (Selection.objects == null)
                        return;
                int PostFix = StartNumber;
                foreach (GameObject o in Selection.objects)
                {
                        float x, y, z;
                        x = y = z = 1f;
                        x = Random.Range(0f, 360f);
                        y = Random.Range(0f, 360f);
                        z = Random.Range(0f, 360f);
                        Vector3 pos = o.GetComponent<Transform>().position;
                        Quaternion rot = o.GetComponent<Transform>().rotation;
                        rot.x = x;
                        rot.y = y;
                        rot.z = z;
                        o.GetComponent<Transform>().SetPositionAndRotation(pos, rot);

                        o.name = BaseName + PostFix;                                            
                        PostFix += Increment;
                }
        }
}

using System.Collections;
using UnityEngine;
using UnityEditor;


public class TexturePacker : ScriptableWizard
{
        [MenuItem("GameObject/Create Other/Atlas Texture")]
        static void CreateWizard()
        {
                ScriptableWizard.DisplayWizard("Create Atlas", typeof(TexturePacker));
        }

        private void OnEnable()
        {
                
        }

        private void OnWizardCreate()
        {
                
        }
}

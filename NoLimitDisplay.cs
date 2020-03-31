using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoLimitDisplay : MonoBehaviour
{
    public Texture BoxTexture; // Drag a Texture onto this item in the Inspector

    GUIContent content;
    GUIStyle style = new GUIStyle();

    // Start is called before the first frame update
    void Start()
    {
        content = new GUIContent("No Limit\n - Unlimited Time\n - Unlimited Fences", BoxTexture, "This is a tooltip");

        // Position the Text and Texture in the center of the box
        style.alignment = TextAnchor.MiddleCenter;
        // Position the Text below the Texture (rather than to the right of it)
        style.imagePosition = ImagePosition.ImageAbove;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), content, style);
    }
}

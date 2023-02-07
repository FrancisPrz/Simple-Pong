using UnityEngine;
using TMPro;

public class VersionManager : MonoBehaviour
{
    public TMP_Text version_Text;

    void Start() => version_Text.text = Application.version.ToString();
}

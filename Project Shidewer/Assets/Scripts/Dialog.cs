using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("dialogue")]
public class Dialog
{
    [XmlElement("node")]
    public Node[] nodes;

    public static Dialog Load(TextAsset _xml)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Dialog));
        StringReader reader = new StringReader(_xml.text);
        Dialog dial = serializer.Deserialize (reader) as Dialog;
        return dial;
    }
}

[System.Serializable]
public class Node
{
    [XmlElement("text")]
    public string text;

    [XmlElement("endnode")]
    public string end;
}

[System.Serializable]
public class Answer
{
    [XmlAttribute("tonode")]
    public int n;

    [XmlElement("end")]
    public string end;
}

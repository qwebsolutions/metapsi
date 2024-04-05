using System.Collections.Generic;

public class IonicMetadata
{
    public List<IonicComponentMetadata> components { get; set; } = new();
    public Dictionary<string,IonicLibraryInterface> typeLibrary { get; set; }
}

public class IonicTypeOptions
{
    public bool IsCollection { get; set; }
    public bool IsLiteral { get; set; }
    public bool IsFunction { get; set; }
    public string LeafType { get; set; }
    public List<IonicTypeOptions> Options { get; set; } = new();
}

public class IonicComponentMetadata
{
    public string tag { get; set; }
    public string docs { get; set; }
    public List<IonicPropMetadata> props { get; set; } = new();
    public List<IonicEventMetadata> events { get; set; } = new();
    public List<IonicSlotMetadata> slots { get; set; } = new();
    public List<IonicMethodMetadata> methods { get; set; } = new();
}

public class IonicPropMetadata
{
    public string name { get; set; }
    public string attr { get; set; }
    public string type { get; set; }
    public string docs { get; set; }
    public string @default { get; set; }
    public bool optional { get; set; }
    public bool required { get; set; }
}

public class IonicEventMetadata
{
    public string @event { get; set; }
    public string detail { get; set; }
    public string docs { get; set; }
    public IonicEventTypeMetadata complexType { get; set; } = new();
}

public class IonicEventTypeMetadata
{
    public string original { get; set; }
    public string resolved { get; set; }
}

public class IonicSlotMetadata
{
    public string name { get; set; }
    public string docs { get; set; }
}

public class IonicMethodMetadata
{
    public string name { get; set; }
    public string docs { get; set; }
    public IonicMethodType complexType { get; set; } = new();
}

public class IonicMethodType
{
    public string signature { get; set; }
    public List<IonicMethodParameter> parameters { get; set; } = new();
}

public class IonicMethodParameter
{
    public string name { get; set; }
    public string type { get; set; }
    public string docs { get; set; }
}

public class IonicLibraryInterface
{
    public string declaration { get; set; }
}